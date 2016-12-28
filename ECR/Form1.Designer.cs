namespace ECR
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelPayment = new System.Windows.Forms.Panel();
            this.tableLayoutReports = new System.Windows.Forms.TableLayoutPanel();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.tableLayoutProduct = new System.Windows.Forms.TableLayoutPanel();
            this.panelProductName = new System.Windows.Forms.Panel();
            this.panelProductGroup = new System.Windows.Forms.Panel();
            this.panelProductTax = new System.Windows.Forms.Panel();
            this.panelProductCount = new System.Windows.Forms.Panel();
            this.panelProductCode = new System.Windows.Forms.Panel();
            this.panelProductDepartment = new System.Windows.Forms.Panel();
            this.panelProductPrice = new System.Windows.Forms.Panel();
            this.panelSum = new System.Windows.Forms.Panel();
            this.panelProductPaymentType = new System.Windows.Forms.Panel();
            this.panelComment = new System.Windows.Forms.Panel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnZReport = new ECR.CustomControls.CustomButton();
            this.btnXReport = new ECR.CustomControls.CustomButton();
            this.lblDivider = new ECR.CustomControls.CustomLabel();
            this.btnPaymentOut = new ECR.CustomControls.CustomButton();
            this.textboxSum = new ECR.CustomControls.CustomTextbox();
            this.btnPaymentIn = new ECR.CustomControls.CustomButton();
            this.lblSum = new ECR.CustomControls.CustomLabel();
            this.comboPaymentType = new ECR.CustomControls.CustomCombobox();
            this.lblPaymentType = new ECR.CustomControls.CustomLabel();
            this.btnConnect = new ECR.CustomControls.CustomButton();
            this.textboxPassword = new ECR.CustomControls.CustomTextbox();
            this.labelPassword = new ECR.CustomControls.CustomLabel();
            this.textboxUsername = new ECR.CustomControls.CustomTextbox();
            this.labelUsername = new ECR.CustomControls.CustomLabel();
            this.textboxIP = new ECR.CustomControls.CustomTextbox();
            this.labelIP = new ECR.CustomControls.CustomLabel();
            this.textboxProductName = new ECR.CustomControls.CustomTextbox();
            this.lblProductName = new ECR.CustomControls.CustomLabel();
            this.comboGroups = new ECR.CustomControls.CustomCombobox();
            this.lblGroup = new ECR.CustomControls.CustomLabel();
            this.comboTaxes = new ECR.CustomControls.CustomCombobox();
            this.lblTax = new ECR.CustomControls.CustomLabel();
            this.textboxProductCount = new ECR.CustomControls.CustomTextbox();
            this.lblProductCount = new ECR.CustomControls.CustomLabel();
            this.textboxProductCode = new ECR.CustomControls.CustomTextbox();
            this.lblProductCode = new ECR.CustomControls.CustomLabel();
            this.comboDepartments = new ECR.CustomControls.CustomCombobox();
            this.lblProductDepartment = new ECR.CustomControls.CustomLabel();
            this.textboxProductPrice = new ECR.CustomControls.CustomTextbox();
            this.lblProductPrice = new ECR.CustomControls.CustomLabel();
            this.textboxProductSum = new ECR.CustomControls.CustomTextbox();
            this.lblProductSum = new ECR.CustomControls.CustomLabel();
            this.comboProductPaymentTypes = new ECR.CustomControls.CustomCombobox();
            this.lblProductPaymentType = new ECR.CustomControls.CustomLabel();
            this.btnProduct = new ECR.CustomControls.CustomButton();
            this.textboxProductComment = new ECR.CustomControls.CustomTextbox();
            this.lblProductComment = new ECR.CustomControls.CustomLabel();
            this.tableLayoutPanel.SuspendLayout();
            this.panelPayment.SuspendLayout();
            this.tableLayoutReports.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.panelProduct.SuspendLayout();
            this.tableLayoutProduct.SuspendLayout();
            this.panelProductName.SuspendLayout();
            this.panelProductGroup.SuspendLayout();
            this.panelProductTax.SuspendLayout();
            this.panelProductCount.SuspendLayout();
            this.panelProductCode.SuspendLayout();
            this.panelProductDepartment.SuspendLayout();
            this.panelProductPrice.SuspendLayout();
            this.panelSum.SuspendLayout();
            this.panelProductPaymentType.SuspendLayout();
            this.panelComment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.panelPayment, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.panelLogin, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.panelProduct, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(1007, 490);
            this.tableLayoutPanel.TabIndex = 2;
            // 
            // panelPayment
            // 
            this.panelPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPayment.Controls.Add(this.tableLayoutReports);
            this.panelPayment.Controls.Add(this.lblDivider);
            this.panelPayment.Controls.Add(this.btnPaymentOut);
            this.panelPayment.Controls.Add(this.textboxSum);
            this.panelPayment.Controls.Add(this.btnPaymentIn);
            this.panelPayment.Controls.Add(this.lblSum);
            this.panelPayment.Controls.Add(this.comboPaymentType);
            this.panelPayment.Controls.Add(this.lblPaymentType);
            this.panelPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPayment.Enabled = false;
            this.panelPayment.Location = new System.Drawing.Point(3, 178);
            this.panelPayment.Name = "panelPayment";
            this.panelPayment.Size = new System.Drawing.Size(497, 312);
            this.panelPayment.TabIndex = 5;
            // 
            // tableLayoutReports
            // 
            this.tableLayoutReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutReports.ColumnCount = 2;
            this.tableLayoutReports.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutReports.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutReports.Controls.Add(this.btnZReport, 1, 0);
            this.tableLayoutReports.Controls.Add(this.btnXReport, 0, 0);
            this.tableLayoutReports.Location = new System.Drawing.Point(8, 148);
            this.tableLayoutReports.Name = "tableLayoutReports";
            this.tableLayoutReports.RowCount = 1;
            this.tableLayoutReports.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutReports.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tableLayoutReports.Size = new System.Drawing.Size(484, 159);
            this.tableLayoutReports.TabIndex = 7;
            // 
            // panelLogin
            // 
            this.panelLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogin.Controls.Add(this.btnConnect);
            this.panelLogin.Controls.Add(this.textboxPassword);
            this.panelLogin.Controls.Add(this.labelPassword);
            this.panelLogin.Controls.Add(this.textboxUsername);
            this.panelLogin.Controls.Add(this.labelUsername);
            this.panelLogin.Controls.Add(this.textboxIP);
            this.panelLogin.Controls.Add(this.labelIP);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(3, 3);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(497, 169);
            this.panelLogin.TabIndex = 0;
            // 
            // panelProduct
            // 
            this.panelProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProduct.Controls.Add(this.tableLayoutProduct);
            this.panelProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProduct.Enabled = false;
            this.panelProduct.Location = new System.Drawing.Point(506, 3);
            this.panelProduct.Name = "panelProduct";
            this.tableLayoutPanel.SetRowSpan(this.panelProduct, 2);
            this.panelProduct.Size = new System.Drawing.Size(498, 487);
            this.panelProduct.TabIndex = 1;
            // 
            // tableLayoutProduct
            // 
            this.tableLayoutProduct.ColumnCount = 2;
            this.tableLayoutProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutProduct.Controls.Add(this.panelProductName, 0, 0);
            this.tableLayoutProduct.Controls.Add(this.panelProductGroup, 1, 2);
            this.tableLayoutProduct.Controls.Add(this.panelProductTax, 0, 3);
            this.tableLayoutProduct.Controls.Add(this.panelProductCount, 1, 1);
            this.tableLayoutProduct.Controls.Add(this.panelProductCode, 0, 1);
            this.tableLayoutProduct.Controls.Add(this.panelProductDepartment, 1, 3);
            this.tableLayoutProduct.Controls.Add(this.panelProductPrice, 0, 2);
            this.tableLayoutProduct.Controls.Add(this.panelSum, 0, 4);
            this.tableLayoutProduct.Controls.Add(this.panelProductPaymentType, 1, 4);
            this.tableLayoutProduct.Controls.Add(this.btnProduct, 0, 6);
            this.tableLayoutProduct.Controls.Add(this.panelComment, 0, 5);
            this.tableLayoutProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutProduct.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutProduct.Name = "tableLayoutProduct";
            this.tableLayoutProduct.RowCount = 7;
            this.tableLayoutProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutProduct.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutProduct.Size = new System.Drawing.Size(496, 485);
            this.tableLayoutProduct.TabIndex = 0;
            // 
            // panelProductName
            // 
            this.tableLayoutProduct.SetColumnSpan(this.panelProductName, 2);
            this.panelProductName.Controls.Add(this.textboxProductName);
            this.panelProductName.Controls.Add(this.lblProductName);
            this.panelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProductName.Location = new System.Drawing.Point(3, 3);
            this.panelProductName.Name = "panelProductName";
            this.panelProductName.Size = new System.Drawing.Size(490, 64);
            this.panelProductName.TabIndex = 0;
            // 
            // panelProductGroup
            // 
            this.panelProductGroup.Controls.Add(this.comboGroups);
            this.panelProductGroup.Controls.Add(this.lblGroup);
            this.panelProductGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProductGroup.Location = new System.Drawing.Point(251, 143);
            this.panelProductGroup.Name = "panelProductGroup";
            this.panelProductGroup.Size = new System.Drawing.Size(242, 64);
            this.panelProductGroup.TabIndex = 4;
            // 
            // panelProductTax
            // 
            this.panelProductTax.Controls.Add(this.comboTaxes);
            this.panelProductTax.Controls.Add(this.lblTax);
            this.panelProductTax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProductTax.Location = new System.Drawing.Point(3, 213);
            this.panelProductTax.Name = "panelProductTax";
            this.panelProductTax.Size = new System.Drawing.Size(242, 64);
            this.panelProductTax.TabIndex = 5;
            // 
            // panelProductCount
            // 
            this.panelProductCount.Controls.Add(this.textboxProductCount);
            this.panelProductCount.Controls.Add(this.lblProductCount);
            this.panelProductCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProductCount.Location = new System.Drawing.Point(251, 73);
            this.panelProductCount.Name = "panelProductCount";
            this.panelProductCount.Size = new System.Drawing.Size(242, 64);
            this.panelProductCount.TabIndex = 2;
            // 
            // panelProductCode
            // 
            this.panelProductCode.Controls.Add(this.textboxProductCode);
            this.panelProductCode.Controls.Add(this.lblProductCode);
            this.panelProductCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProductCode.Location = new System.Drawing.Point(3, 73);
            this.panelProductCode.Name = "panelProductCode";
            this.panelProductCode.Size = new System.Drawing.Size(242, 64);
            this.panelProductCode.TabIndex = 1;
            // 
            // panelProductDepartment
            // 
            this.panelProductDepartment.Controls.Add(this.comboDepartments);
            this.panelProductDepartment.Controls.Add(this.lblProductDepartment);
            this.panelProductDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProductDepartment.Location = new System.Drawing.Point(251, 213);
            this.panelProductDepartment.Name = "panelProductDepartment";
            this.panelProductDepartment.Size = new System.Drawing.Size(242, 64);
            this.panelProductDepartment.TabIndex = 6;
            // 
            // panelProductPrice
            // 
            this.panelProductPrice.Controls.Add(this.textboxProductPrice);
            this.panelProductPrice.Controls.Add(this.lblProductPrice);
            this.panelProductPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProductPrice.Location = new System.Drawing.Point(3, 143);
            this.panelProductPrice.Name = "panelProductPrice";
            this.panelProductPrice.Size = new System.Drawing.Size(242, 64);
            this.panelProductPrice.TabIndex = 3;
            // 
            // panelSum
            // 
            this.panelSum.Controls.Add(this.textboxProductSum);
            this.panelSum.Controls.Add(this.lblProductSum);
            this.panelSum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSum.Location = new System.Drawing.Point(3, 283);
            this.panelSum.Name = "panelSum";
            this.panelSum.Size = new System.Drawing.Size(242, 64);
            this.panelSum.TabIndex = 7;
            // 
            // panelProductPaymentType
            // 
            this.panelProductPaymentType.Controls.Add(this.comboProductPaymentTypes);
            this.panelProductPaymentType.Controls.Add(this.lblProductPaymentType);
            this.panelProductPaymentType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProductPaymentType.Location = new System.Drawing.Point(251, 283);
            this.panelProductPaymentType.Name = "panelProductPaymentType";
            this.panelProductPaymentType.Size = new System.Drawing.Size(242, 64);
            this.panelProductPaymentType.TabIndex = 8;
            // 
            // panelComment
            // 
            this.tableLayoutProduct.SetColumnSpan(this.panelComment, 2);
            this.panelComment.Controls.Add(this.textboxProductComment);
            this.panelComment.Controls.Add(this.lblProductComment);
            this.panelComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelComment.Location = new System.Drawing.Point(3, 353);
            this.panelComment.Name = "panelComment";
            this.panelComment.Size = new System.Drawing.Size(490, 64);
            this.panelComment.TabIndex = 9;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 0;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // btnZReport
            // 
            this.btnZReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZReport.BackColor = System.Drawing.Color.White;
            this.btnZReport.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnZReport.Location = new System.Drawing.Point(245, 3);
            this.btnZReport.Name = "btnZReport";
            this.btnZReport.Size = new System.Drawing.Size(236, 50);
            this.btnZReport.TabIndex = 1;
            this.btnZReport.Text = "Z-звіт";
            this.btnZReport.UseVisualStyleBackColor = false;
            this.btnZReport.Click += new System.EventHandler(this.btnZReport_Click);
            // 
            // btnXReport
            // 
            this.btnXReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXReport.BackColor = System.Drawing.Color.White;
            this.btnXReport.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnXReport.Location = new System.Drawing.Point(3, 3);
            this.btnXReport.Name = "btnXReport";
            this.btnXReport.Size = new System.Drawing.Size(236, 50);
            this.btnXReport.TabIndex = 0;
            this.btnXReport.Text = "X-звіт";
            this.btnXReport.UseVisualStyleBackColor = false;
            this.btnXReport.Click += new System.EventHandler(this.btnXReport_Click);
            // 
            // lblDivider
            // 
            this.lblDivider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDivider.BackColor = System.Drawing.Color.Transparent;
            this.lblDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDivider.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDivider.Location = new System.Drawing.Point(8, 132);
            this.lblDivider.Name = "lblDivider";
            this.lblDivider.Size = new System.Drawing.Size(484, 2);
            this.lblDivider.TabIndex = 6;
            // 
            // btnPaymentOut
            // 
            this.btnPaymentOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPaymentOut.BackColor = System.Drawing.Color.White;
            this.btnPaymentOut.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPaymentOut.Location = new System.Drawing.Point(230, 66);
            this.btnPaymentOut.Name = "btnPaymentOut";
            this.btnPaymentOut.Size = new System.Drawing.Size(194, 50);
            this.btnPaymentOut.TabIndex = 5;
            this.btnPaymentOut.Text = "Винесення";
            this.btnPaymentOut.UseVisualStyleBackColor = false;
            this.btnPaymentOut.Click += new System.EventHandler(this.btnPaymentOut_Click);
            // 
            // textboxSum
            // 
            this.textboxSum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxSum.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textboxSum.Location = new System.Drawing.Point(12, 35);
            this.textboxSum.Name = "textboxSum";
            this.textboxSum.Size = new System.Drawing.Size(202, 26);
            this.textboxSum.TabIndex = 1;
            this.textboxSum.Tag = "Required|Float";
            // 
            // btnPaymentIn
            // 
            this.btnPaymentIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPaymentIn.BackColor = System.Drawing.Color.White;
            this.btnPaymentIn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPaymentIn.Location = new System.Drawing.Point(11, 66);
            this.btnPaymentIn.Name = "btnPaymentIn";
            this.btnPaymentIn.Size = new System.Drawing.Size(203, 50);
            this.btnPaymentIn.TabIndex = 4;
            this.btnPaymentIn.Text = "Внесення";
            this.btnPaymentIn.UseVisualStyleBackColor = false;
            this.btnPaymentIn.Click += new System.EventHandler(this.btnPaymentIn_Click);
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.BackColor = System.Drawing.Color.Transparent;
            this.lblSum.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSum.Location = new System.Drawing.Point(8, 10);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(41, 20);
            this.lblSum.TabIndex = 0;
            this.lblSum.Text = "Сума";
            // 
            // comboPaymentType
            // 
            this.comboPaymentType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPaymentType.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboPaymentType.FormattingEnabled = true;
            this.comboPaymentType.Location = new System.Drawing.Point(230, 32);
            this.comboPaymentType.Name = "comboPaymentType";
            this.comboPaymentType.Size = new System.Drawing.Size(259, 28);
            this.comboPaymentType.TabIndex = 3;
            this.comboPaymentType.Tag = "Required";
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.BackColor = System.Drawing.Color.Transparent;
            this.lblPaymentType.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPaymentType.Location = new System.Drawing.Point(226, 9);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(76, 20);
            this.lblPaymentType.TabIndex = 2;
            this.lblPaymentType.Text = "Тип оплати";
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnConnect.BackColor = System.Drawing.Color.White;
            this.btnConnect.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConnect.Location = new System.Drawing.Point(310, 28);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(182, 50);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "З\'єднання";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // textboxPassword
            // 
            this.textboxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxPassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textboxPassword.Location = new System.Drawing.Point(12, 134);
            this.textboxPassword.Name = "textboxPassword";
            this.textboxPassword.PasswordChar = '*';
            this.textboxPassword.Size = new System.Drawing.Size(292, 26);
            this.textboxPassword.TabIndex = 5;
            this.textboxPassword.Tag = "Required";
            this.textboxPassword.Text = "751426";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(12, 111);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(60, 20);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Пароль:";
            // 
            // textboxUsername
            // 
            this.textboxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxUsername.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textboxUsername.Location = new System.Drawing.Point(12, 82);
            this.textboxUsername.Name = "textboxUsername";
            this.textboxUsername.Size = new System.Drawing.Size(292, 26);
            this.textboxUsername.TabIndex = 3;
            this.textboxUsername.Tag = "Required";
            this.textboxUsername.Text = "service";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUsername.Location = new System.Drawing.Point(9, 59);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(45, 20);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Логін:";
            // 
            // textboxIP
            // 
            this.textboxIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxIP.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textboxIP.Location = new System.Drawing.Point(12, 28);
            this.textboxIP.Name = "textboxIP";
            this.textboxIP.Size = new System.Drawing.Size(292, 26);
            this.textboxIP.TabIndex = 1;
            this.textboxIP.Tag = "Required";
            this.textboxIP.Text = "http://169.254.186.21";
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.BackColor = System.Drawing.Color.Transparent;
            this.labelIP.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIP.Location = new System.Drawing.Point(8, 5);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(74, 20);
            this.labelIP.TabIndex = 0;
            this.labelIP.Text = "IP адреса:";
            // 
            // textboxProductName
            // 
            this.textboxProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxProductName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textboxProductName.Location = new System.Drawing.Point(7, 26);
            this.textboxProductName.MaxLength = 50;
            this.textboxProductName.Name = "textboxProductName";
            this.textboxProductName.Size = new System.Drawing.Size(480, 26);
            this.textboxProductName.TabIndex = 1;
            this.textboxProductName.Tag = "Required";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.BackColor = System.Drawing.Color.Transparent;
            this.lblProductName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductName.Location = new System.Drawing.Point(3, 2);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(45, 20);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Назва";
            // 
            // comboGroups
            // 
            this.comboGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGroups.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboGroups.FormattingEnabled = true;
            this.comboGroups.Location = new System.Drawing.Point(7, 23);
            this.comboGroups.Name = "comboGroups";
            this.comboGroups.Size = new System.Drawing.Size(232, 28);
            this.comboGroups.TabIndex = 1;
            this.comboGroups.Tag = "Required";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.BackColor = System.Drawing.Color.Transparent;
            this.lblGroup.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGroup.Location = new System.Drawing.Point(3, 0);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(45, 20);
            this.lblGroup.TabIndex = 0;
            this.lblGroup.Text = "Група";
            // 
            // comboTaxes
            // 
            this.comboTaxes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboTaxes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTaxes.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboTaxes.FormattingEnabled = true;
            this.comboTaxes.Location = new System.Drawing.Point(7, 23);
            this.comboTaxes.Name = "comboTaxes";
            this.comboTaxes.Size = new System.Drawing.Size(232, 28);
            this.comboTaxes.TabIndex = 1;
            this.comboTaxes.Tag = "Required";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.BackColor = System.Drawing.Color.Transparent;
            this.lblTax.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTax.Location = new System.Drawing.Point(3, 0);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(60, 20);
            this.lblTax.TabIndex = 0;
            this.lblTax.Text = "Податок";
            // 
            // textboxProductCount
            // 
            this.textboxProductCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxProductCount.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textboxProductCount.Location = new System.Drawing.Point(7, 24);
            this.textboxProductCount.MaxLength = 10;
            this.textboxProductCount.Name = "textboxProductCount";
            this.textboxProductCount.Size = new System.Drawing.Size(232, 26);
            this.textboxProductCount.TabIndex = 1;
            this.textboxProductCount.Tag = "Count";
            this.textboxProductCount.TextChanged += new System.EventHandler(this.textboxProductCount_TextChanged);
            // 
            // lblProductCount
            // 
            this.lblProductCount.AutoSize = true;
            this.lblProductCount.BackColor = System.Drawing.Color.Transparent;
            this.lblProductCount.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductCount.Location = new System.Drawing.Point(3, 0);
            this.lblProductCount.Name = "lblProductCount";
            this.lblProductCount.Size = new System.Drawing.Size(63, 20);
            this.lblProductCount.TabIndex = 0;
            this.lblProductCount.Text = "Кількість";
            // 
            // textboxProductCode
            // 
            this.textboxProductCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxProductCode.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textboxProductCode.Location = new System.Drawing.Point(7, 24);
            this.textboxProductCode.MaxLength = 14;
            this.textboxProductCode.Name = "textboxProductCode";
            this.textboxProductCode.Size = new System.Drawing.Size(232, 26);
            this.textboxProductCode.TabIndex = 1;
            this.textboxProductCode.Tag = "Required";
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.BackColor = System.Drawing.Color.Transparent;
            this.lblProductCode.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductCode.Location = new System.Drawing.Point(3, 1);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(79, 20);
            this.lblProductCode.TabIndex = 0;
            this.lblProductCode.Text = "Код товару";
            // 
            // comboDepartments
            // 
            this.comboDepartments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboDepartments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDepartments.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboDepartments.FormattingEnabled = true;
            this.comboDepartments.Location = new System.Drawing.Point(7, 23);
            this.comboDepartments.Name = "comboDepartments";
            this.comboDepartments.Size = new System.Drawing.Size(232, 28);
            this.comboDepartments.TabIndex = 1;
            this.comboDepartments.Tag = "Required";
            // 
            // lblProductDepartment
            // 
            this.lblProductDepartment.AutoSize = true;
            this.lblProductDepartment.BackColor = System.Drawing.Color.Transparent;
            this.lblProductDepartment.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductDepartment.Location = new System.Drawing.Point(3, 0);
            this.lblProductDepartment.Name = "lblProductDepartment";
            this.lblProductDepartment.Size = new System.Drawing.Size(48, 20);
            this.lblProductDepartment.TabIndex = 0;
            this.lblProductDepartment.Text = "Відділ";
            // 
            // textboxProductPrice
            // 
            this.textboxProductPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxProductPrice.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textboxProductPrice.Location = new System.Drawing.Point(7, 24);
            this.textboxProductPrice.MaxLength = 10;
            this.textboxProductPrice.Name = "textboxProductPrice";
            this.textboxProductPrice.Size = new System.Drawing.Size(232, 26);
            this.textboxProductPrice.TabIndex = 1;
            this.textboxProductPrice.Tag = "Required|Price";
            this.textboxProductPrice.TextChanged += new System.EventHandler(this.textboxProductPrice_TextChanged);
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblProductPrice.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductPrice.Location = new System.Drawing.Point(3, 0);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(36, 20);
            this.lblProductPrice.TabIndex = 0;
            this.lblProductPrice.Text = "Ціна";
            // 
            // textboxProductSum
            // 
            this.textboxProductSum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxProductSum.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textboxProductSum.Location = new System.Drawing.Point(7, 27);
            this.textboxProductSum.MaxLength = 10;
            this.textboxProductSum.Name = "textboxProductSum";
            this.textboxProductSum.Size = new System.Drawing.Size(232, 26);
            this.textboxProductSum.TabIndex = 1;
            this.textboxProductSum.Tag = "Required|Price";
            // 
            // lblProductSum
            // 
            this.lblProductSum.AutoSize = true;
            this.lblProductSum.BackColor = System.Drawing.Color.Transparent;
            this.lblProductSum.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductSum.Location = new System.Drawing.Point(3, 3);
            this.lblProductSum.Name = "lblProductSum";
            this.lblProductSum.Size = new System.Drawing.Size(41, 20);
            this.lblProductSum.TabIndex = 0;
            this.lblProductSum.Text = "Сума";
            // 
            // comboProductPaymentTypes
            // 
            this.comboProductPaymentTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboProductPaymentTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProductPaymentTypes.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboProductPaymentTypes.FormattingEnabled = true;
            this.comboProductPaymentTypes.Location = new System.Drawing.Point(7, 26);
            this.comboProductPaymentTypes.Name = "comboProductPaymentTypes";
            this.comboProductPaymentTypes.Size = new System.Drawing.Size(232, 28);
            this.comboProductPaymentTypes.TabIndex = 1;
            this.comboProductPaymentTypes.Tag = "Required";
            // 
            // lblProductPaymentType
            // 
            this.lblProductPaymentType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProductPaymentType.AutoSize = true;
            this.lblProductPaymentType.BackColor = System.Drawing.Color.Transparent;
            this.lblProductPaymentType.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductPaymentType.Location = new System.Drawing.Point(3, 3);
            this.lblProductPaymentType.Name = "lblProductPaymentType";
            this.lblProductPaymentType.Size = new System.Drawing.Size(76, 20);
            this.lblProductPaymentType.TabIndex = 0;
            this.lblProductPaymentType.Text = "Тип оплати";
            // 
            // btnProduct
            // 
            this.btnProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProduct.BackColor = System.Drawing.Color.White;
            this.btnProduct.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProduct.Location = new System.Drawing.Point(3, 423);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(242, 50);
            this.btnProduct.TabIndex = 10;
            this.btnProduct.Text = "Run";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // textboxProductComment
            // 
            this.textboxProductComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxProductComment.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textboxProductComment.Location = new System.Drawing.Point(7, 23);
            this.textboxProductComment.Name = "textboxProductComment";
            this.textboxProductComment.Size = new System.Drawing.Size(478, 26);
            this.textboxProductComment.TabIndex = 1;
            this.textboxProductComment.Tag = "";
            // 
            // lblProductComment
            // 
            this.lblProductComment.AutoSize = true;
            this.lblProductComment.BackColor = System.Drawing.Color.Transparent;
            this.lblProductComment.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductComment.Location = new System.Drawing.Point(7, 0);
            this.lblProductComment.Name = "lblProductComment";
            this.lblProductComment.Size = new System.Drawing.Size(69, 20);
            this.lblProductComment.TabIndex = 0;
            this.lblProductComment.Text = "Коментар";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 490);
            this.Controls.Add(this.tableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 529);
            this.Name = "MainForm";
            this.Text = "ECR";
            this.tableLayoutPanel.ResumeLayout(false);
            this.panelPayment.ResumeLayout(false);
            this.panelPayment.PerformLayout();
            this.tableLayoutReports.ResumeLayout(false);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelProduct.ResumeLayout(false);
            this.tableLayoutProduct.ResumeLayout(false);
            this.panelProductName.ResumeLayout(false);
            this.panelProductName.PerformLayout();
            this.panelProductGroup.ResumeLayout(false);
            this.panelProductGroup.PerformLayout();
            this.panelProductTax.ResumeLayout(false);
            this.panelProductTax.PerformLayout();
            this.panelProductCount.ResumeLayout(false);
            this.panelProductCount.PerformLayout();
            this.panelProductCode.ResumeLayout(false);
            this.panelProductCode.PerformLayout();
            this.panelProductDepartment.ResumeLayout(false);
            this.panelProductDepartment.PerformLayout();
            this.panelProductPrice.ResumeLayout(false);
            this.panelProductPrice.PerformLayout();
            this.panelSum.ResumeLayout(false);
            this.panelSum.PerformLayout();
            this.panelProductPaymentType.ResumeLayout(false);
            this.panelProductPaymentType.PerformLayout();
            this.panelComment.ResumeLayout(false);
            this.panelComment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Panel panelProduct;
        private CustomControls.CustomLabel labelIP;
        private CustomControls.CustomTextbox textboxIP;
        private CustomControls.CustomTextbox textboxUsername;
        private CustomControls.CustomLabel labelUsername;
        private CustomControls.CustomLabel labelPassword;
        private CustomControls.CustomTextbox textboxPassword;
        private CustomControls.CustomButton btnConnect;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel panelPayment;
        private CustomControls.CustomButton btnPaymentOut;
        private CustomControls.CustomTextbox textboxSum;
        private CustomControls.CustomButton btnPaymentIn;
        private CustomControls.CustomLabel lblSum;
        private CustomControls.CustomCombobox comboPaymentType;
        private CustomControls.CustomLabel lblPaymentType;
        private CustomControls.CustomLabel lblDivider;
        private System.Windows.Forms.TableLayoutPanel tableLayoutReports;
        private CustomControls.CustomButton btnXReport;
        private CustomControls.CustomButton btnZReport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutProduct;
        private System.Windows.Forms.Panel panelProductName;
        private CustomControls.CustomTextbox textboxProductName;
        private CustomControls.CustomLabel lblProductName;
        private System.Windows.Forms.Panel panelProductCount;
        private CustomControls.CustomTextbox textboxProductCount;
        private CustomControls.CustomLabel lblProductCount;
        private System.Windows.Forms.Panel panelProductPrice;
        private CustomControls.CustomTextbox textboxProductPrice;
        private CustomControls.CustomLabel lblProductPrice;
        private System.Windows.Forms.Panel panelProductDepartment;
        private CustomControls.CustomCombobox comboDepartments;
        private CustomControls.CustomLabel lblProductDepartment;
        private System.Windows.Forms.Panel panelProductGroup;
        private CustomControls.CustomCombobox comboGroups;
        private CustomControls.CustomLabel lblGroup;
        private System.Windows.Forms.Panel panelProductTax;
        private CustomControls.CustomCombobox comboTaxes;
        private CustomControls.CustomLabel lblTax;
        private CustomControls.CustomButton btnProduct;
        private System.Windows.Forms.Panel panelProductCode;
        private CustomControls.CustomTextbox textboxProductCode;
        private CustomControls.CustomLabel lblProductCode;
        private System.Windows.Forms.Panel panelSum;
        private CustomControls.CustomTextbox textboxProductSum;
        private CustomControls.CustomLabel lblProductSum;
        private System.Windows.Forms.Panel panelProductPaymentType;
        private CustomControls.CustomCombobox comboProductPaymentTypes;
        private CustomControls.CustomLabel lblProductPaymentType;
        private System.Windows.Forms.Panel panelComment;
        private CustomControls.CustomLabel lblProductComment;
        private CustomControls.CustomTextbox textboxProductComment;
    }
}

