using ECR.Events;
using ECR.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECR
{
    public partial class MainForm : Form
    {

        private Validator validator;
        private ECRDevice device;
        private BackgroundWorker bgWorker = new BackgroundWorker();

        private NameValueCollection buttonStates = new NameValueCollection();

        public MainForm()
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            //this.MaximumSize = new System.Drawing.Size(screenWidth, this.Height);
            InitializeComponent();
            validator = new Validator();
            device = new ECRDevice();
            device.HttpClient.HttpErrorEvent += OnHttpError;
            ECRDictionary.InitTranslations();
        }

        private bool IsPanelDataValid(Panel panel, bool isErrorClear)
        {
            bool isValid = true;
            if (isErrorClear)
                errorProvider.Clear();
            foreach (Control control in panel.Controls)
            {
                string rules = (string)control.Tag;
                if (!String.IsNullOrWhiteSpace(rules))
                {
                    ValidationResult response = validator.Validate(control.Text, rules);
                    if (response.success == false)
                    {
                        isValid = false;
                       
                        errorProvider.SetIconPadding(control, -20);
                        errorProvider.SetError(control, ECRDictionary.GetTranslation(response.message));
                    }
                }
            }
            return isValid;
        }

        private NameValueCollection FetchPanelData(Panel panel)
        {
            var list = new NameValueCollection();
            foreach (Control control in panel.Controls)
            {
                if (control is TextBox)
                {
                    list[control.Name] = control.Text;
                }
                if (control is ComboBox)
                {
                    list[control.Name] = ((ComboBox)control).SelectedValue.ToString();
                }
            }
            return list;
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            if (IsPanelDataValid(panelLogin, true))
            {

                ChangePanelsState(false);

                LoadingButton(btnConnect);
                var panelData = this.FetchPanelData(panelLogin);
                try
                {
                    device.Connect(panelData["textboxIP"], panelData["textboxUsername"], panelData["textboxPassword"]);
                    Task<dynamic> task = Task.Factory.StartNew(() => device.GetState());
                    dynamic state = await task;
                    task.Dispose();
                    if (state != null)
                    {
                        Task taskLoadData = Task.Factory.StartNew(() => device.LoadDeviceData());
                        await taskLoadData;
                        taskLoadData.Dispose();

                        Task taskLoadDescriptions = Task.Factory.StartNew(() => device.LoadTranslations());
                        await taskLoadDescriptions;

                        FillFormPayment();
                        FillFormProduct();
                        ResetButton(btnConnect);
                        ShowInfoMessage(ECRDictionary.GetTranslation("Connected successfully"));
                        ChangePanelsState(true);
                    }
                    else
                    {
                        ResetButton(btnConnect);
                    }
                }
                catch (Exception ex) 
                {
                    ResetButton(btnConnect);
                    ShowErrorMessage(ECRDictionary.GetTranslation(ex.Message));
                }   
            }
        }

        private void btnXReport_Click(object sender, EventArgs e)
        {
            SendReport(ECRDevice.X_REPORT, btnXReport);
        }

        private void btnZReport_Click(object sender, EventArgs e)
        {
            SendReport(ECRDevice.Z_REPORT, btnZReport);
        }

        private void btnPaymentIn_Click(object sender, EventArgs e)
        {
            SendPayment(true, btnPaymentIn);
        }

        private void btnPaymentOut_Click(object sender, EventArgs e)
        {
            SendPayment(false, btnPaymentOut);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            List<Panel> panels = new List<Panel>();
            foreach (Control control in tableLayoutProduct.Controls)
            {
                if (control is Panel)
                {
                    panels.Add((Panel)control);
                }
            }
            bool isPanelValid = true;
            errorProvider.Clear();
            foreach (Panel panel in panels)
            {
                if (!IsPanelDataValid(panel, false))
                {
                    isPanelValid = false;
                }
            }
            if (isPanelValid)
            {
                dynamic data = new ExpandoObject();
                data.Name = textboxProductName.Text;
                data.Code = textboxProductCode.Text;
                data.Count = device.ReadCount(textboxProductCount.Text);
                data.Price = device.ReadPrice(textboxProductPrice.Text);
                data.Group = ReadComboData(comboGroups);
                data.Department = ReadComboData(comboDepartments);
                data.Tax = ReadComboData(comboTaxes);
                data.Sum = device.ReadPrice(textboxSum.Text);
                data.PaymentType = ReadComboData(comboProductPaymentTypes);
                data.Comment = textboxProductComment.Text;
                MessageBox.Show(data.Tax.ToString());
            }
        }

        private int ReadComboData(ComboBox combo)
        {
            var selectedItem = (ComboboxItem)combo.SelectedItem;
            return int.Parse(selectedItem.Value.ToString());
        }

        private async void SendReport(int reportType, Button currentButton)
        {
            try
            {
                LoadingButton(currentButton);
                Task<dynamic> task = Task.Factory.StartNew(() => device.SendReport(reportType));
                dynamic response = await task;

                ResetButton(currentButton);
            }
            catch (Exception) { }
        }

        private async void SendPayment(bool isIn, Button currentButton)
        {
            if (IsPanelDataValid(panelPayment, true))
            {
                try
                {
                    LoadingButton(currentButton);
                    float sum = Math.Abs(float.Parse(textboxSum.Text));
                    var selectedItem = (ComboboxItem)comboPaymentType.SelectedItem;
                    int number = int.Parse(selectedItem.Value.ToString());
                    if (isIn == false)
                    {
                        sum = -sum;
                    }
                    Task<dynamic> task = Task.Factory.StartNew(() => device.SendPayment(number, sum));
                    dynamic response = await task;

                    ResetButton(currentButton);
                }
                catch (Exception) { }
            }
        }

        private void LoadingButton(Button button)
        {
            buttonStates.Add(button.Name, button.Text);
            button.Text = ECRDictionary.GetTranslation("In work...");
            button.Enabled = false;
        }

        private void ResetButton(Button button)
        {
            string buttonText = buttonStates[button.Name];
            button.Text = buttonText;
            button.Enabled = true;
            buttonStates.Remove(button.Name);
        }

        private void OnHttpError(object sender, HttpErrorEventArgs e)
        {
            ShowErrorMessage(ECRDictionary.GetTranslation(e.Message));
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, ECRDictionary.GetTranslation("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowInfoMessage(string message)
        {
            MessageBox.Show(message, ECRDictionary.GetTranslation("Information"), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FillFormPayment()
        {
            FillCombobox(device.PaymentTypes, "Name", "id", comboPaymentType);
        }

        private void FillFormProduct()
        {
            FillCombobox(device.Departments, "Name", "id", comboDepartments);
            FillCombobox(device.Groups, "Name", "id", comboGroups);
            FillCombobox(device.Taxes, "Prc", "id", comboTaxes);
            FillCombobox(device.PaymentTypes, "Name", "id", comboProductPaymentTypes);
        }

        private void FillCombobox(List<ExpandoObject> list, string displayMember, string valueMember, ComboBox combo)
        {
            combo.Items.Clear();
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
            foreach (ExpandoObject listItem in list)
            {
                var item = new ComboboxItem();
                item.Text = GetProperty((dynamic)listItem, displayMember);
                item.Value = GetProperty((dynamic)listItem, valueMember);
                combo.Items.Add(item);
            }
            if (list.Count > 0)
            {
                combo.Text = GetProperty((dynamic)list[0], displayMember);
            }
        }

        private void UpdateCurrentSum()
        {
            float price = device.ReadPrice(textboxProductPrice.Text);
            float count = device.ReadCount(textboxProductCount.Text);
            float sum = (float)Math.Round(price * count, 2);
            textboxProductSum.Text = sum.ToString("F");
        }

        public static object GetProperty(object target, string name)
        {
            return Microsoft.VisualBasic.CompilerServices.Versioned.CallByName(target, name, CallType.Get);
        }

        private void ChangePanelsState(bool enabledState)
        {
            panelPayment.Enabled = enabledState;
            panelProduct.Enabled = enabledState;
        }

        private void textboxProductCount_TextChanged(object sender, EventArgs e)
        {
            UpdateCurrentSum();
        }

        private void textboxProductPrice_TextChanged(object sender, EventArgs e)
        {
            UpdateCurrentSum();
        }

        

    }
}
