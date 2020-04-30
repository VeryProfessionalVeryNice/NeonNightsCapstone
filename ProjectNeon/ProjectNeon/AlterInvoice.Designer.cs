namespace ProjectNeon
{
    partial class AlterInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterInvoice));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBxId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBxCheckNum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbBxPayment = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateIssued = new System.Windows.Forms.DateTimePicker();
            this.ckBxTaxExempt = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAlterItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBxDesc = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBxPriceEach = new System.Windows.Forms.TextBox();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBxItemCode = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.lstBxItems = new System.Windows.Forms.ListBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBxId);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtBxCheckNum);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cmbBxPayment);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dateIssued);
            this.groupBox2.Controls.Add(this.ckBxTaxExempt);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 305);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "‌Invoice Information";
            // 
            // txtBxId
            // 
            this.txtBxId.Location = new System.Drawing.Point(15, 44);
            this.txtBxId.Name = "txtBxId";
            this.txtBxId.ReadOnly = true;
            this.txtBxId.Size = new System.Drawing.Size(173, 20);
            this.txtBxId.TabIndex = 20;
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
            this.txtBxCheckNum.Text = " ";
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAlterItem);
            this.groupBox3.Controls.Add(this.btnAddItem);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtBxDesc);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtBxPriceEach);
            this.groupBox3.Controls.Add(this.nudQty);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtBxItemCode);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(246, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 298);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Item Information";
            // 
            // btnAlterItem
            // 
            this.btnAlterItem.Location = new System.Drawing.Point(15, 257);
            this.btnAlterItem.Name = "btnAlterItem";
            this.btnAlterItem.Size = new System.Drawing.Size(75, 23);
            this.btnAlterItem.TabIndex = 20;
            this.btnAlterItem.Text = "Alter Item";
            this.btnAlterItem.UseVisualStyleBackColor = true;
            this.btnAlterItem.Click += new System.EventHandler(this.btnAlterItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(113, 257);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
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
            this.txtBxDesc.Multiline = true;
            this.txtBxDesc.Name = "txtBxDesc";
            this.txtBxDesc.Size = new System.Drawing.Size(173, 46);
            this.txtBxDesc.TabIndex = 17;
            this.txtBxDesc.Text = " ";
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
            this.txtBxPriceEach.Text = " ";
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
            this.txtBxItemCode.Tag = " ";
            this.txtBxItemCode.Text = " ";
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
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(246, 432);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(210, 27);
            this.btnDeleteItem.TabIndex = 27;
            this.btnDeleteItem.Text = "Delete Selected Item";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(243, 315);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "Current Items";
            // 
            // lstBxItems
            // 
            this.lstBxItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.lstBxItems.FormattingEnabled = true;
            this.lstBxItems.Location = new System.Drawing.Point(246, 331);
            this.lstBxItems.Name = "lstBxItems";
            this.lstBxItems.Size = new System.Drawing.Size(210, 95);
            this.lstBxItems.TabIndex = 25;
            this.lstBxItems.SelectedIndexChanged += new System.EventHandler(this.lstBxItems_SelectedIndexChanged);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(46, 368);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(154, 58);
            this.btnSaveChanges.TabIndex = 28;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // AlterInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 479);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lstBxItems);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlterInvoice";
            this.Text = "AlterInvoice";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBxCheckNum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbBxPayment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateIssued;
        private System.Windows.Forms.CheckBox ckBxTaxExempt;
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
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox lstBxItems;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox txtBxId;
        private System.Windows.Forms.Button btnAlterItem;
    }
}