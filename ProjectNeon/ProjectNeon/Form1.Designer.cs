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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblStatus = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelAddInvoice = new System.Windows.Forms.Panel();
            this.chBxCustPaid = new System.Windows.Forms.CheckBox();
            this.chBxPrint = new System.Windows.Forms.CheckBox();
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
            this.btnShowTransactions = new System.Windows.Forms.Button();
            this.btnShowCustomers = new System.Windows.Forms.Button();
            this.panelTransactions = new System.Windows.Forms.Panel();
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            this.btnVoid = new System.Windows.Forms.Button();
            this.btnOpenInvoice = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cmBxSearch = new System.Windows.Forms.ComboBox();
            this.txtBxSearch = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dataGridViewTransactions = new System.Windows.Forms.DataGridView();
            this.panelCustomers = new System.Windows.Forms.Panel();
            this.btnSaveDataGrid = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressLine1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressLine2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new ProjectNeon.Database1DataSet1();
            this.btnTestData = new System.Windows.Forms.Button();
            this.btnTestCon = new System.Windows.Forms.Button();
            this.btnCustomerPayment = new System.Windows.Forms.Button();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new ProjectNeon.Database1DataSet();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.customerTableAdapter = new ProjectNeon.Database1DataSet1TableAdapters.CustomerTableAdapter();
            this.customerTableAdapter1 = new ProjectNeon.Database1DataSetTableAdapters.CustomerTableAdapter();
            this.invoiceTableAdapter = new ProjectNeon.Database1DataSetTableAdapters.InvoiceTableAdapter();
            this.panelAddInvoice.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).BeginInit();
            this.panelCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(151, 545);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(428, 67);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Welcome";
            // 
            // panelAddInvoice
            // 
            this.panelAddInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.panelAddInvoice.Controls.Add(this.chBxCustPaid);
            this.panelAddInvoice.Controls.Add(this.chBxPrint);
            this.panelAddInvoice.Controls.Add(this.btnSaveToDatabase);
            this.panelAddInvoice.Controls.Add(this.btnDeleteItem);
            this.panelAddInvoice.Controls.Add(this.label16);
            this.panelAddInvoice.Controls.Add(this.lstBxItems);
            this.panelAddInvoice.Controls.Add(this.groupBox3);
            this.panelAddInvoice.Controls.Add(this.groupBox2);
            this.panelAddInvoice.Controls.Add(this.groupBox1);
            this.panelAddInvoice.Location = new System.Drawing.Point(154, 20);
            this.panelAddInvoice.Name = "panelAddInvoice";
            this.panelAddInvoice.Size = new System.Drawing.Size(849, 519);
            this.panelAddInvoice.TabIndex = 2;
            // 
            // chBxCustPaid
            // 
            this.chBxCustPaid.AutoSize = true;
            this.chBxCustPaid.Location = new System.Drawing.Point(430, 333);
            this.chBxCustPaid.Name = "chBxCustPaid";
            this.chBxCustPaid.Size = new System.Drawing.Size(113, 17);
            this.chBxCustPaid.TabIndex = 27;
            this.chBxCustPaid.Text = "Customer has paid";
            this.chBxCustPaid.UseVisualStyleBackColor = true;
            // 
            // chBxPrint
            // 
            this.chBxPrint.AutoSize = true;
            this.chBxPrint.Location = new System.Drawing.Point(315, 333);
            this.chBxPrint.Name = "chBxPrint";
            this.chBxPrint.Size = new System.Drawing.Size(89, 17);
            this.chBxPrint.TabIndex = 26;
            this.chBxPrint.Text = "Save as PDF";
            this.chBxPrint.UseVisualStyleBackColor = true;
            // 
            // btnSaveToDatabase
            // 
            this.btnSaveToDatabase.Location = new System.Drawing.Point(315, 356);
            this.btnSaveToDatabase.Name = "btnSaveToDatabase";
            this.btnSaveToDatabase.Size = new System.Drawing.Size(228, 54);
            this.btnSaveToDatabase.TabIndex = 25;
            this.btnSaveToDatabase.Text = "Save Invoice";
            this.btnSaveToDatabase.UseVisualStyleBackColor = true;
            this.btnSaveToDatabase.Click += new System.EventHandler(this.btnSaveToDatabase_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(604, 486);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(210, 27);
            this.btnDeleteItem.TabIndex = 24;
            this.btnDeleteItem.Text = "Delete Selected Item";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
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
            this.lstBxItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
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
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
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
            this.txtBxDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.txtBxDesc.Location = new System.Drawing.Point(15, 189);
            this.txtBxDesc.MaxLength = 50;
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
            this.txtBxPriceEach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.txtBxPriceEach.Location = new System.Drawing.Point(15, 139);
            this.txtBxPriceEach.Name = "txtBxPriceEach";
            this.txtBxPriceEach.Size = new System.Drawing.Size(173, 20);
            this.txtBxPriceEach.TabIndex = 15;
            // 
            // nudQty
            // 
            this.nudQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
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
            this.txtBxItemCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
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
            this.txtBxInvoiceId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
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
            this.txtBxCheckNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
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
            this.cmbBxPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
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
            this.dateIssued.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
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
            this.cmbBxJobType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
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
            this.txtBxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.txtBxName.Location = new System.Drawing.Point(16, 39);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(173, 20);
            this.txtBxName.TabIndex = 0;
            // 
            // txtBxZip
            // 
            this.txtBxZip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.txtBxZip.Location = new System.Drawing.Point(16, 344);
            this.txtBxZip.MaxLength = 5;
            this.txtBxZip.Name = "txtBxZip";
            this.txtBxZip.Size = new System.Drawing.Size(173, 20);
            this.txtBxZip.TabIndex = 5;
            this.txtBxZip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxZip_KeyPress);
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
            this.txtBxState.AutoCompleteCustomSource.AddRange(new string[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "DC",
            "FL",
            "GA",
            "HA",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.txtBxState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBxState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBxState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.txtBxState.Location = new System.Drawing.Point(16, 285);
            this.txtBxState.MaxLength = 2;
            this.txtBxState.Name = "txtBxState";
            this.txtBxState.Size = new System.Drawing.Size(173, 20);
            this.txtBxState.TabIndex = 4;
            // 
            // txtBxAddress1
            // 
            this.txtBxAddress1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
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
            this.txtBxCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.txtBxCity.Location = new System.Drawing.Point(16, 222);
            this.txtBxCity.Name = "txtBxCity";
            this.txtBxCity.Size = new System.Drawing.Size(173, 20);
            this.txtBxCity.TabIndex = 3;
            // 
            // txtBxAddress2
            // 
            this.txtBxAddress2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
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
            this.btnShowAddInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.btnShowAddInvoice.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnShowAddInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAddInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAddInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(176)))), ((int)(((byte)(218)))));
            this.btnShowAddInvoice.Location = new System.Drawing.Point(3, 167);
            this.btnShowAddInvoice.Name = "btnShowAddInvoice";
            this.btnShowAddInvoice.Size = new System.Drawing.Size(148, 76);
            this.btnShowAddInvoice.TabIndex = 3;
            this.btnShowAddInvoice.Text = "Add Invoice";
            this.btnShowAddInvoice.UseVisualStyleBackColor = false;
            this.btnShowAddInvoice.Click += new System.EventHandler(this.btnShowAddInvoice_Click);
            // 
            // btnShowTransactions
            // 
            this.btnShowTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.btnShowTransactions.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnShowTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowTransactions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(176)))), ((int)(((byte)(218)))));
            this.btnShowTransactions.Location = new System.Drawing.Point(3, 85);
            this.btnShowTransactions.Name = "btnShowTransactions";
            this.btnShowTransactions.Size = new System.Drawing.Size(148, 76);
            this.btnShowTransactions.TabIndex = 5;
            this.btnShowTransactions.Text = "Transactions";
            this.btnShowTransactions.UseVisualStyleBackColor = false;
            this.btnShowTransactions.Click += new System.EventHandler(this.btnShowTransactions_Click);
            // 
            // btnShowCustomers
            // 
            this.btnShowCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.btnShowCustomers.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnShowCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(176)))), ((int)(((byte)(218)))));
            this.btnShowCustomers.Location = new System.Drawing.Point(3, 3);
            this.btnShowCustomers.Name = "btnShowCustomers";
            this.btnShowCustomers.Size = new System.Drawing.Size(148, 76);
            this.btnShowCustomers.TabIndex = 6;
            this.btnShowCustomers.Text = "Customers";
            this.btnShowCustomers.UseVisualStyleBackColor = false;
            this.btnShowCustomers.Click += new System.EventHandler(this.btnShowCustomers_Click);
            // 
            // panelTransactions
            // 
            this.panelTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.panelTransactions.Controls.Add(this.btnPrintInvoice);
            this.panelTransactions.Controls.Add(this.btnVoid);
            this.panelTransactions.Controls.Add(this.btnOpenInvoice);
            this.panelTransactions.Controls.Add(this.label20);
            this.panelTransactions.Controls.Add(this.lblSearch);
            this.panelTransactions.Controls.Add(this.cmBxSearch);
            this.panelTransactions.Controls.Add(this.txtBxSearch);
            this.panelTransactions.Controls.Add(this.label18);
            this.panelTransactions.Controls.Add(this.dataGridViewTransactions);
            this.panelTransactions.Location = new System.Drawing.Point(154, 20);
            this.panelTransactions.Name = "panelTransactions";
            this.panelTransactions.Size = new System.Drawing.Size(849, 519);
            this.panelTransactions.TabIndex = 26;
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.btnPrintInvoice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrintInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(176)))), ((int)(((byte)(218)))));
            this.btnPrintInvoice.Location = new System.Drawing.Point(731, 341);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(110, 69);
            this.btnPrintInvoice.TabIndex = 31;
            this.btnPrintInvoice.Text = "Save Invoice to PDF";
            this.btnPrintInvoice.UseVisualStyleBackColor = false;
            this.btnPrintInvoice.Click += new System.EventHandler(this.btnPrintInvoice_Click);
            // 
            // btnVoid
            // 
            this.btnVoid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.btnVoid.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVoid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(176)))), ((int)(((byte)(218)))));
            this.btnVoid.Location = new System.Drawing.Point(731, 247);
            this.btnVoid.Name = "btnVoid";
            this.btnVoid.Size = new System.Drawing.Size(110, 69);
            this.btnVoid.TabIndex = 30;
            this.btnVoid.Text = "Void  Invoice";
            this.btnVoid.UseVisualStyleBackColor = false;
            this.btnVoid.Click += new System.EventHandler(this.btnVoid_Click);
            // 
            // btnOpenInvoice
            // 
            this.btnOpenInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.btnOpenInvoice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOpenInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(176)))), ((int)(((byte)(218)))));
            this.btnOpenInvoice.Location = new System.Drawing.Point(731, 153);
            this.btnOpenInvoice.Name = "btnOpenInvoice";
            this.btnOpenInvoice.Size = new System.Drawing.Size(110, 69);
            this.btnOpenInvoice.TabIndex = 29;
            this.btnOpenInvoice.Text = "Open Invoice";
            this.btnOpenInvoice.UseVisualStyleBackColor = false;
            this.btnOpenInvoice.Click += new System.EventHandler(this.btnOpenInvoice_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(230, 59);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(15, 13);
            this.label20.TabIndex = 6;
            this.label20.Text = "in";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(73, 39);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 5;
            this.lblSearch.Text = "Search";
            // 
            // cmBxSearch
            // 
            this.cmBxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.cmBxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBxSearch.FormattingEnabled = true;
            this.cmBxSearch.Items.AddRange(new object[] {
            "CompanyName",
            "InvoiceID"});
            this.cmBxSearch.Location = new System.Drawing.Point(252, 55);
            this.cmBxSearch.Name = "cmBxSearch";
            this.cmBxSearch.Size = new System.Drawing.Size(152, 21);
            this.cmBxSearch.TabIndex = 4;
            // 
            // txtBxSearch
            // 
            this.txtBxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.txtBxSearch.Location = new System.Drawing.Point(73, 55);
            this.txtBxSearch.Name = "txtBxSearch";
            this.txtBxSearch.Size = new System.Drawing.Size(151, 20);
            this.txtBxSearch.TabIndex = 3;
            this.txtBxSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // dataGridViewTransactions
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.dataGridViewTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransactions.Location = new System.Drawing.Point(73, 86);
            this.dataGridViewTransactions.Name = "dataGridViewTransactions";
            this.dataGridViewTransactions.Size = new System.Drawing.Size(652, 410);
            this.dataGridViewTransactions.TabIndex = 2;
            // 
            // panelCustomers
            // 
            this.panelCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.panelCustomers.Controls.Add(this.btnSaveDataGrid);
            this.panelCustomers.Controls.Add(this.label19);
            this.panelCustomers.Controls.Add(this.dataGridViewCustomer);
            this.panelCustomers.Location = new System.Drawing.Point(154, 20);
            this.panelCustomers.Name = "panelCustomers";
            this.panelCustomers.Size = new System.Drawing.Size(849, 519);
            this.panelCustomers.TabIndex = 0;
            // 
            // btnSaveDataGrid
            // 
            this.btnSaveDataGrid.Location = new System.Drawing.Point(371, 473);
            this.btnSaveDataGrid.Name = "btnSaveDataGrid";
            this.btnSaveDataGrid.Size = new System.Drawing.Size(172, 23);
            this.btnSaveDataGrid.TabIndex = 2;
            this.btnSaveDataGrid.Text = "Save Data";
            this.btnSaveDataGrid.UseVisualStyleBackColor = true;
            this.btnSaveDataGrid.Click += new System.EventHandler(this.btnSaveDataGrid_Click);
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
            // dataGridViewCustomer
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.dataGridViewCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCustomer.AutoGenerateColumns = false;
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.addressLine1DataGridViewTextBoxColumn,
            this.addressLine2DataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.zipDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn});
            this.dataGridViewCustomer.DataSource = this.customerBindingSource;
            this.dataGridViewCustomer.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(0, 40);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.Size = new System.Drawing.Size(854, 414);
            this.dataGridViewCustomer.TabIndex = 1;
            this.dataGridViewCustomer.SelectionChanged += new System.EventHandler(this.dataGridViewCustomer_SelectionChanged);
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            // 
            // addressLine1DataGridViewTextBoxColumn
            // 
            this.addressLine1DataGridViewTextBoxColumn.DataPropertyName = "AddressLine1";
            this.addressLine1DataGridViewTextBoxColumn.HeaderText = "AddressLine1";
            this.addressLine1DataGridViewTextBoxColumn.Name = "addressLine1DataGridViewTextBoxColumn";
            // 
            // addressLine2DataGridViewTextBoxColumn
            // 
            this.addressLine2DataGridViewTextBoxColumn.DataPropertyName = "AddressLine2";
            this.addressLine2DataGridViewTextBoxColumn.HeaderText = "AddressLine2";
            this.addressLine2DataGridViewTextBoxColumn.Name = "addressLine2DataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            // 
            // zipDataGridViewTextBoxColumn
            // 
            this.zipDataGridViewTextBoxColumn.DataPropertyName = "Zip";
            this.zipDataGridViewTextBoxColumn.HeaderText = "Zip";
            this.zipDataGridViewTextBoxColumn.Name = "zipDataGridViewTextBoxColumn";
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.balanceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnTestData
            // 
            this.btnTestData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.btnTestData.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTestData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(176)))), ((int)(((byte)(218)))));
            this.btnTestData.Location = new System.Drawing.Point(750, 572);
            this.btnTestData.Name = "btnTestData";
            this.btnTestData.Size = new System.Drawing.Size(82, 35);
            this.btnTestData.TabIndex = 27;
            this.btnTestData.Text = "Load Data";
            this.btnTestData.UseVisualStyleBackColor = false;
            this.btnTestData.Click += new System.EventHandler(this.btnTestData_Click);
            // 
            // btnTestCon
            // 
            this.btnTestCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.btnTestCon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTestCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestCon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(176)))), ((int)(((byte)(218)))));
            this.btnTestCon.Location = new System.Drawing.Point(634, 572);
            this.btnTestCon.Name = "btnTestCon";
            this.btnTestCon.Size = new System.Drawing.Size(110, 35);
            this.btnTestCon.TabIndex = 28;
            this.btnTestCon.Text = "Test Page";
            this.btnTestCon.UseVisualStyleBackColor = false;
            this.btnTestCon.Click += new System.EventHandler(this.btnTestCon_Click);
            // 
            // btnCustomerPayment
            // 
            this.btnCustomerPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.btnCustomerPayment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCustomerPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(176)))), ((int)(((byte)(218)))));
            this.btnCustomerPayment.Location = new System.Drawing.Point(840, 545);
            this.btnCustomerPayment.Name = "btnCustomerPayment";
            this.btnCustomerPayment.Size = new System.Drawing.Size(163, 62);
            this.btnCustomerPayment.TabIndex = 29;
            this.btnCustomerPayment.Text = "Enter Customer Payment";
            this.btnCustomerPayment.UseVisualStyleBackColor = false;
            this.btnCustomerPayment.Visible = false;
            this.btnCustomerPayment.Click += new System.EventHandler(this.btnCustomerPayment_Click);
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "Customer";
            this.customerBindingSource1.DataSource = this.database1DataSetBindingSource;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "Invoice";
            this.invoiceBindingSource.DataSource = this.database1DataSetBindingSource;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.flowLayoutPanel1.Controls.Add(this.btnShowCustomers);
            this.flowLayoutPanel1.Controls.Add(this.btnShowTransactions);
            this.flowLayoutPanel1.Controls.Add(this.btnShowAddInvoice);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-6, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(154, 617);
            this.flowLayoutPanel1.TabIndex = 30;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(210)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1007, 610);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnCustomerPayment);
            this.Controls.Add(this.btnTestCon);
            this.Controls.Add(this.btnTestData);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.panelTransactions);
            this.Controls.Add(this.panelCustomers);
            this.Controls.Add(this.panelAddInvoice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Neon Nights";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelAddInvoice.ResumeLayout(false);
            this.panelAddInvoice.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelTransactions.ResumeLayout(false);
            this.panelTransactions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).EndInit();
            this.panelCustomers.ResumeLayout(false);
            this.panelCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnShowTransactions;
        private System.Windows.Forms.Button btnShowCustomers;
        private System.Windows.Forms.Panel panelTransactions;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panelCustomers;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnTestData;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private Database1DataSet1TableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.Button btnTestCon;
        private System.Windows.Forms.Button btnSaveDataGrid;
        private System.Windows.Forms.Button btnCustomerPayment;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private Database1DataSetTableAdapters.CustomerTableAdapter customerTableAdapter1;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private Database1DataSetTableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewTransactions;
        private System.Windows.Forms.ComboBox cmBxSearch;
        private System.Windows.Forms.TextBox txtBxSearch;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressLine1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressLine2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnVoid;
        private System.Windows.Forms.Button btnOpenInvoice;
        private System.Windows.Forms.Button btnPrintInvoice;
        private System.Windows.Forms.CheckBox chBxPrint;
        private System.Windows.Forms.CheckBox chBxCustPaid;
    }
}

