namespace ProjectNeon
{
    partial class Form1
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
            this.database1DataSet = new ProjectNeon.Database1DataSet();
            this.lblStatus = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelAddInvoice = new System.Windows.Forms.Panel();
            this.btnSaveToDatabase = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.lstBxItems = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBxDesc = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBxPriceEach = new System.Windows.Forms.TextBox();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBxItemCode = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBxInvoiceId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBxCheckNum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbBxPayment = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateIssued = new System.Windows.Forms.DateTimePicker();
            this.ckBxTaxExempt = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbBxJobType = new System.Windows.Forms.ComboBox();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.txtBxZip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxState = new System.Windows.Forms.TextBox();
            this.txtBxAddress1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxCity = new System.Windows.Forms.TextBox();
            this.txtBxAddress2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnShowAddInvoice = new System.Windows.Forms.Button();
            this.btnShowManageInvoice = new System.Windows.Forms.Button();
            this.btnShowTransactions = new System.Windows.Forms.Button();
            this.btnShowCustomers = new System.Windows.Forms.Button();
            this.panelManageInvoices = new System.Windows.Forms.Panel();
            this.panelTransactions = new System.Windows.Forms.Panel();
            this.panelCustomers = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.panelAddInvoice.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelManageInvoices.SuspendLayout();
            this.panelTransactions.SuspendLayout();
            this.panelCustomers.SuspendLayout();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(13, 585);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Welcome";
            // 
            // panelAddInvoice
            // 
            this.panelAddInvoice.Controls.Add(this.btnSaveToDatabase);
            this.panelAddInvoice.Controls.Add(this.btnDeleteItem);
            this.panelAddInvoice.Controls.Add(this.label16);
            this.panelAddInvoice.Controls.Add(this.lstBxItems);
            this.panelAddInvoice.Controls.Add(this.groupBox3);
            this.panelAddInvoice.Controls.Add(this.groupBox2);
            this.panelAddInvoice.Controls.Add(this.groupBox1);
            this.panelAddInvoice.Location = new System.Drawing.Point(141, 23);
            this.panelAddInvoice.Name = "panelAddInvoice";
            this.panelAddInvoice.Size = new System.Drawing.Size(849, 519);
            this.panelAddInvoice.TabIndex = 2;
            // 
            // btnSaveToDatabase
            // 
            this.btnSaveToDatabase.Location = new System.Drawing.Point(315, 333);
            this.btnSaveToDatabase.Name = "btnSaveToDatabase";
            this.btnSaveToDatabase.Size = new System.Drawing.Size(228, 54);
            this.btnSaveToDatabase.TabIndex = 25;
            this.btnSaveToDatabase.Text = "Save Invoice";
            this.btnSaveToDatabase.UseVisualStyleBackColor = true;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(604, 486);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(210, 27);
            this.btnDeleteItem.TabIndex = 24;
            this.btnDeleteItem.Text = "Delete Selected Item";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(601, 317);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "Current Items";
            // 
            // lstBxItems
            // 
            this.lstBxItems.FormattingEnabled = true;
            this.lstBxItems.Location = new System.Drawing.Point(604, 333);
            this.lstBxItems.Name = "lstBxItems";
            this.lstBxItems.Size = new System.Drawing.Size(210, 147);
            this.lstBxItems.TabIndex = 22;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddItem);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtBxDesc);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtBxPriceEach);
            this.groupBox3.Controls.Add(this.nudQty);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtBxItemCode);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(604, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 298);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Item Information";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(15, 253);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(170, 27);
            this.btnAddItem.TabIndex = 19;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 173);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Description (optional)";
            // 
            // txtBxDesc
            // 
            this.txtBxDesc.Location = new System.Drawing.Point(15, 189);
            this.txtBxDesc.Multiline = true;
            this.txtBxDesc.Name = "txtBxDesc";
            this.txtBxDesc.Size = new System.Drawing.Size(173, 46);
            this.txtBxDesc.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Price Each";
            // 
            // txtBxPriceEach
            // 
            this.txtBxPriceEach.Location = new System.Drawing.Point(15, 139);
            this.txtBxPriceEach.Name = "txtBxPriceEach";
            this.txtBxPriceEach.Size = new System.Drawing.Size(173, 20);
            this.txtBxPriceEach.TabIndex = 15;
            // 
            // nudQty
            // 
            this.nudQty.Location = new System.Drawing.Point(15, 88);
            this.nudQty.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(173, 20);
            this.nudQty.TabIndex = 14;
            this.nudQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Quantity";
            // 
            // txtBxItemCode
            // 
            this.txtBxItemCode.Location = new System.Drawing.Point(15, 44);
            this.txtBxItemCode.Name = "txtBxItemCode";
            this.txtBxItemCode.Size = new System.Drawing.Size(173, 20);
            this.txtBxItemCode.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Item Code";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBxInvoiceId);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtBxCheckNum);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cmbBxPayment);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dateIssued);
            this.groupBox2.Controls.Add(this.ckBxTaxExempt);
            this.groupBox2.Location = new System.Drawing.Point(315, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 305);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "‌Invoice Information";
            // 
            // txtBxInvoiceId
            // 
            this.txtBxInvoiceId.Location = new System.Drawing.Point(15, 39);
            this.txtBxInvoiceId.Name = "txtBxInvoiceId";
            this.txtBxInvoiceId.Size = new System.Drawing.Size(173, 20);
            this.txtBxInvoiceId.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Invoice ID";
            // 
            // txtBxCheckNum
            // 
            this.txtBxCheckNum.Location = new System.Drawing.Point(15, 260);
            this.txtBxCheckNum.Name = "txtBxCheckNum";
            this.txtBxCheckNum.Size = new System.Drawing.Size(173, 20);
            this.txtBxCheckNum.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Check Number (if applicable)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Payment Method";
            // 
            // cmbBxPayment
            // 
            this.cmbBxPayment.FormattingEnabled = true;
            this.cmbBxPayment.Items.AddRange(new object[] {
            "Cash",
            "Check"});
            this.cmbBxPayment.Location = new System.Drawing.Point(15, 196);
            this.cmbBxPayment.Name = "cmbBxPayment";
            this.cmbBxPayment.Size = new System.Drawing.Size(173, 21);
            this.cmbBxPayment.TabIndex = 10;
            this.cmbBxPayment.Text = "Cash";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Date Issued";
            // 
            // dateIssued
            // 
            this.dateIssued.Location = new System.Drawing.Point(15, 135);
            this.dateIssued.Name = "dateIssued";
            this.dateIssued.Size = new System.Drawing.Size(198, 20);
            this.dateIssued.TabIndex = 9;
            // 
            // ckBxTaxExempt
            // 
            this.ckBxTaxExempt.AutoSize = true;
            this.ckBxTaxExempt.Location = new System.Drawing.Point(15, 81);
            this.ckBxTaxExempt.Name = "ckBxTaxExempt";
            this.ckBxTaxExempt.Size = new System.Drawing.Size(82, 17);
            this.ckBxTaxExempt.TabIndex = 8;
            this.ckBxTaxExempt.Text = "Tax Exempt";
            this.ckBxTaxExempt.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbBxJobType);
            this.groupBox1.Controls.Add(this.txtBxName);
            this.groupBox1.Controls.Add(this.txtBxZip);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBxState);
            this.groupBox1.Controls.Add(this.txtBxAddress1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBxCity);
            this.groupBox1.Controls.Add(this.txtBxAddress2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(35, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 455);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Job Type";
            // 
            // cmbBxJobType
            // 
            this.cmbBxJobType.FormattingEnabled = true;
            this.cmbBxJobType.Items.AddRange(new object[] {
            "Company",
            "Private"});
            this.cmbBxJobType.Location = new System.Drawing.Point(16, 398);
            this.cmbBxJobType.Name = "cmbBxJobType";
            this.cmbBxJobType.Size = new System.Drawing.Size(173, 21);
            this.cmbBxJobType.TabIndex = 6;
            this.cmbBxJobType.Text = "Company";
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(16, 39);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(173, 20);
            this.txtBxName.TabIndex = 0;
            // 
            // txtBxZip
            // 
            this.txtBxZip.Location = new System.Drawing.Point(16, 344);
            this.txtBxZip.MaxLength = 5;
            this.txtBxZip.Name = "txtBxZip";
            this.txtBxZip.Size = new System.Drawing.Size(173, 20);
            this.txtBxZip.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Zip Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Street Address";
            // 
            // txtBxState
            // 
            this.txtBxState.Location = new System.Drawing.Point(16, 285);
            this.txtBxState.MaxLength = 2;
            this.txtBxState.Name = "txtBxState";
            this.txtBxState.Size = new System.Drawing.Size(173, 20);
            this.txtBxState.TabIndex = 4;
            // 
            // txtBxAddress1
            // 
            this.txtBxAddress1.Location = new System.Drawing.Point(16, 97);
            this.txtBxAddress1.Name = "txtBxAddress1";
            this.txtBxAddress1.Size = new System.Drawing.Size(173, 20);
            this.txtBxAddress1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "State (abbreviated)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apt, Suite, Unit, Building (optional)";
            // 
            // txtBxCity
            // 
            this.txtBxCity.Location = new System.Drawing.Point(16, 222);
            this.txtBxCity.Name = "txtBxCity";
            this.txtBxCity.Size = new System.Drawing.Size(173, 20);
            this.txtBxCity.TabIndex = 3;
            // 
            // txtBxAddress2
            // 
            this.txtBxAddress2.Location = new System.Drawing.Point(16, 159);
            this.txtBxAddress2.Name = "txtBxAddress2";
            this.txtBxAddress2.Size = new System.Drawing.Size(173, 20);
            this.txtBxAddress2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "City";
            // 
            // btnShowAddInvoice
            // 
            this.btnShowAddInvoice.Location = new System.Drawing.Point(12, 96);
            this.btnShowAddInvoice.Name = "btnShowAddInvoice";
            this.btnShowAddInvoice.Size = new System.Drawing.Size(123, 76);
            this.btnShowAddInvoice.TabIndex = 3;
            this.btnShowAddInvoice.Text = "Add Invoice";
            this.btnShowAddInvoice.UseVisualStyleBackColor = true;
            this.btnShowAddInvoice.Click += new System.EventHandler(this.btnShowAddInvoice_Click);
            // 
            // btnShowManageInvoice
            // 
            this.btnShowManageInvoice.Location = new System.Drawing.Point(12, 179);
            this.btnShowManageInvoice.Name = "btnShowManageInvoice";
            this.btnShowManageInvoice.Size = new System.Drawing.Size(123, 76);
            this.btnShowManageInvoice.TabIndex = 4;
            this.btnShowManageInvoice.Text = "Manage Invoices";
            this.btnShowManageInvoice.UseVisualStyleBackColor = true;
            this.btnShowManageInvoice.Click += new System.EventHandler(this.btnShowManageInvoice_Click);
            // 
            // btnShowTransactions
            // 
            this.btnShowTransactions.Location = new System.Drawing.Point(12, 262);
            this.btnShowTransactions.Name = "btnShowTransactions";
            this.btnShowTransactions.Size = new System.Drawing.Size(123, 76);
            this.btnShowTransactions.TabIndex = 5;
            this.btnShowTransactions.Text = "Transactions";
            this.btnShowTransactions.UseVisualStyleBackColor = true;
            this.btnShowTransactions.Click += new System.EventHandler(this.btnShowTransactions_Click);
            // 
            // btnShowCustomers
            // 
            this.btnShowCustomers.Location = new System.Drawing.Point(12, 345);
            this.btnShowCustomers.Name = "btnShowCustomers";
            this.btnShowCustomers.Size = new System.Drawing.Size(123, 76);
            this.btnShowCustomers.TabIndex = 6;
            this.btnShowCustomers.Text = "Customers";
            this.btnShowCustomers.UseVisualStyleBackColor = true;
            this.btnShowCustomers.Click += new System.EventHandler(this.btnShowCustomers_Click);
            // 
            // panelManageInvoices
            // 
            this.panelManageInvoices.Controls.Add(this.label17);
            this.panelManageInvoices.Location = new System.Drawing.Point(141, 23);
            this.panelManageInvoices.Name = "panelManageInvoices";
            this.panelManageInvoices.Size = new System.Drawing.Size(849, 519);
            this.panelManageInvoices.TabIndex = 7;
            // 
            // panelTransactions
            // 
            this.panelTransactions.Controls.Add(this.label18);
            this.panelTransactions.Location = new System.Drawing.Point(141, 23);
            this.panelTransactions.Name = "panelTransactions";
            this.panelTransactions.Size = new System.Drawing.Size(849, 519);
            this.panelTransactions.TabIndex = 26;
            // 
            // panelCustomers
            // 
            this.panelCustomers.Controls.Add(this.label19);
            this.panelCustomers.Location = new System.Drawing.Point(141, 23);
            this.panelCustomers.Name = "panelCustomers";
            this.panelCustomers.Size = new System.Drawing.Size(849, 519);
            this.panelCustomers.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Manage Invoices";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Transactions";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(10, 12);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Customers";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 610);
            this.Controls.Add(this.btnShowCustomers);
            this.Controls.Add(this.btnShowTransactions);
            this.Controls.Add(this.btnShowManageInvoice);
            this.Controls.Add(this.btnShowAddInvoice);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.panelAddInvoice);
            this.Controls.Add(this.panelManageInvoices);
            this.Controls.Add(this.panelTransactions);
            this.Controls.Add(this.panelCustomers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.panelAddInvoice.ResumeLayout(false);
            this.panelAddInvoice.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelManageInvoices.ResumeLayout(false);
            this.panelManageInvoices.PerformLayout();
            this.panelTransactions.ResumeLayout(false);
            this.panelTransactions.PerformLayout();
            this.panelCustomers.ResumeLayout(false);
            this.panelCustomers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panelAddInvoice;
        private System.Windows.Forms.Button btnSaveToDatabase;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox lstBxItems;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtBxDesc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBxPriceEach;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBxItemCode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBxInvoiceId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBxCheckNum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbBxPayment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateIssued;
        private System.Windows.Forms.CheckBox ckBxTaxExempt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbBxJobType;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.TextBox txtBxZip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxState;
        private System.Windows.Forms.TextBox txtBxAddress1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxCity;
        private System.Windows.Forms.TextBox txtBxAddress2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnShowAddInvoice;
        private System.Windows.Forms.Button btnShowManageInvoice;
        private System.Windows.Forms.Button btnShowTransactions;
        private System.Windows.Forms.Button btnShowCustomers;
        private System.Windows.Forms.Panel panelManageInvoices;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panelTransactions;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panelCustomers;
        private System.Windows.Forms.Label label19;
    }
}

