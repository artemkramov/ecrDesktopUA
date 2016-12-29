using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECR.Models
{

    /// <summary>
    /// Entity for working with device data
    /// </summary>
    class ECRDevice
    {

        /// <summary>
        /// Constant for sending of the X report
        /// </summary>
        public const int X_REPORT = 10;

        /// <summary>
        /// Constant for sending of the Z report
        /// </summary>
        public const int Z_REPORT = 0;

        /// <summary>
        /// Http client for request sending
        /// </summary>
        private HttpClientInstance httpClient = new HttpClientInstance();

        /// <summary>
        /// Payment types of device
        /// </summary>
        private List<ExpandoObject> paymentTypes;

        /// <summary>
        /// Departments of device
        /// </summary>
        private List<ExpandoObject> departments;

        /// <summary>
        /// Groups of device
        /// </summary>
        private List<ExpandoObject> groups;

        /// <summary>
        /// Taxes of device
        /// </summary>
        private List<ExpandoObject> taxes;

        /// <summary>
        /// Validator entity
        /// </summary>
        private Validator validator = new Validator();

        /// <summary>
        /// Initialize http client data with the credentials
        /// </summary>
        /// <param name="baseAddress"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public void Connect(string baseAddress, string username, string password)
        {
            this.httpClient.Connect(baseAddress, username, password);
        }

        /// <summary>
        /// Get current state info
        /// </summary>
        /// <returns></returns>
        public dynamic GetState()
        {
            var parameters = new Dictionary<string, string>();
            return httpClient.RequestGet("/cgi/state", parameters, false).Result;
        }

        /// <summary>
        /// Send payment data
        /// </summary>
        /// <param name="number"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public dynamic SendPayment(int number, float sum)
        {
            Payment payment = new Payment();
            payment.Set("number", number);
            payment.Set("sum", sum);
            return httpClient.RequestPost("/cgi/chk", payment, false);
        }

        /// <summary>
        /// Send general payment data
        /// </summary>
        /// <param name="payment"></param>
        /// <returns></returns>
        public dynamic SendPaymentGeneral(PaymentGeneral payment)
        {
            return httpClient.RequestPost("/cgi/chk", payment, false);
        }

        /// <summary>
        /// Send report by the appropriate type 
        /// </summary>
        /// <param name="reportType"></param>
        /// <returns></returns>
        public dynamic SendReport(int reportType)
        {
            var parameters = new Dictionary<string, string>();
            return httpClient.RequestGet("/cgi/proc/printreport?" + reportType.ToString(), parameters, false);
        }

        /// <summary>
        /// Load all necessary device data
        /// </summary>
        public void LoadDeviceData()
        {
            this.PaymentTypes = httpClient.RequestGet("/cgi/tbl/Pay", new Dictionary<string,string>(), false).Result;
            this.Departments = httpClient.RequestGet("/cgi/tbl/Dep", new Dictionary<string, string>(), false).Result;
            this.Groups = httpClient.RequestGet("/cgi/tbl/Grp", new Dictionary<string, string>(), false).Result;
            this.Taxes = httpClient.RequestGet("/cgi/tbl/Tax", new Dictionary<string, string>(), false).Result;
            /**
             * Prepend the item "Without taxes" to Taxes collection and rename all items
             * due to the Ukrainian alphabet
             */ 
            dynamic emptyObject = new ExpandoObject();
            emptyObject.id = 0;
            emptyObject.Prc = ECRDictionary.GetTranslation("Without taxes");
            string alphabet = @"АБВГДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ";
            int counter = 0;
            foreach (ExpandoObject tax in this.Taxes)
            {
                ((dynamic)tax).Prc = alphabet[counter].ToString();
                counter++;
            }
            this.Taxes.Insert(0, emptyObject);
        }

        /// <summary>
        /// Load all error translations from device
        /// </summary>
        public void LoadTranslations()
        {
            try
            {
                var descriptions = httpClient.RequestGet("/desc", new Dictionary<string, string>(), true).Result;
                var defaultLanguage = descriptions.def;
                var byName = (IDictionary<string, object>)descriptions;
                var data = byName[defaultLanguage];
                var errors = data.err;
                foreach (KeyValuePair<string, object> kvp in errors)
                {
                    ECRDictionary.AddTranslations(kvp.Key.ToString(), kvp.Value.ToString());
                }
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Return the application cultural info (decimal point type etc.)
        /// </summary>
        /// <returns></returns>
        public CultureInfo GetDefaultCulturalInfo()
        {
            CultureInfo ci = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            ci.NumberFormat.NumberDecimalSeparator = this.validator.GetDecimalDelimiter();
            return ci;
        }

        /// <summary>
        /// Parse price value due to common rules
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public float ReadPrice(string value)
        {
            try
            {
                CultureInfo ci = this.GetDefaultCulturalInfo();
                ci.NumberFormat.NumberDecimalDigits = 2;
                return (float)(Math.Truncate(100 * float.Parse(value, NumberStyles.Float, ci)) / 100);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }

        /// <summary>
        /// Read count value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public float ReadCount(string value)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    value = "1";
                }
                CultureInfo ci = this.GetDefaultCulturalInfo();
                return (float)Math.Round(float.Parse(value, NumberStyles.Float, ci));
            }
            catch (Exception)
            {
                return 0;
            }
        }

        /// <summary>
        /// HttpClient property
        /// </summary>
        public HttpClientInstance HttpClient
        {
            private set { httpClient = value; }
            get { return httpClient; }
        }

        /// <summary>
        /// PaymentTypes property
        /// </summary>
        public List<ExpandoObject> PaymentTypes
        {
            private set { paymentTypes = value; }
            get { return paymentTypes; }
        }

        /// <summary>
        /// Departments property
        /// </summary>
        public List<ExpandoObject> Departments
        {
            private set { departments = value; }
            get { return departments; }
        }

        /// <summary>
        /// Groups property
        /// </summary>
        public List<ExpandoObject> Groups
        {
            private set { groups = value; }
            get { return groups; }
        }

        /// <summary>
        /// Taxes property
        /// </summary>
        public List<ExpandoObject> Taxes
        {
            private set { taxes = value; }
            get { return taxes; }
        }

    }
}
