namespace ProjectNeon
{
    partial class CustomerPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerPayment));
            this.btnRecordPayment = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBxPaymentAmount = new System.Windows.Forms.TextBox();
            this.lblPaymentAmount = new System.Windows.Forms.Label();
            this.txtBxCheckNum = new System.Windows.Forms.TextBox();
            this.lblCheckNumber = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbBxPayment = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.paymentDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBxBalance = new System.Windows.Forms.TextBox();
            this.lblOutstandingBalance = new System.Windows.Forms.Label();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRecordPayment
            // 
            this.btnRecordPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.btnRecordPayment.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecordPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(176)))), ((int)(((byte)(218)))));
            this.btnRecordPayment.Location = new System.Drawing.Point(-3, 508);
            this.btnRecordPayment.Name = "btnRecordPayment";
            this.btnRecordPayment.Size = new System.Drawing.Size(404, 66);
            this.btnRecordPayment.TabIndex = 28;
            this.btnRecordPayment.Text = "Record Payment";
            this.btnRecordPayment.UseVisualStyleBackColor = false;
            this.btnRecordPayment.Click += new System.EventHandler(this.btnRecordPayment_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBxPaymentAmount);
            this.groupBox2.Controls.Add(this.lblPaymentAmount);
            this.groupBox2.Controls.Add(this.txtBxCheckNum);
            this.groupBox2.Controls.Add(this.lblCheckNumber);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cmbBxPayment);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.paymentDate);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(-3, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 324);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment Information";
            // 
            // txtBxPaymentAmount
            // 
            this.txtBxPaymentAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.txtBxPaymentAmount.Location = new System.Drawing.Point(22, 129);
            this.txtBxPaymentAmount.Name = "txtBxPaymentAmount";
            this.txtBxPaymentAmount.Size = new System.Drawing.Size(364, 34);
            this.txtBxPaymentAmount.TabIndex = 19;
            this.txtBxPaymentAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxPaymentAmount_KeyPress);
            // 
            // lblPaymentAmount
            // 
            this.lblPaymentAmount.AutoSize = true;
            this.lblPaymentAmount.Location = new System.Drawing.Point(10, 98);
            this.lblPaymentAmount.Name = "lblPaymentAmount";
            this.lblPaymentAmount.Size = new System.Drawing.Size(200, 28);
            this.lblPaymentAmount.TabIndex = 20;
            this.lblPaymentAmount.Text = "Payment Amount";
            // 
            // txtBxCheckNum
            // 
            this.txtBxCheckNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.txtBxCheckNum.Location = new System.Drawing.Point(22, 272);
            this.txtBxCheckNum.Name = "txtBxCheckNum";
            this.txtBxCheckNum.Size = new System.Drawing.Size(364, 34);
            this.txtBxCheckNum.TabIndex = 11;
            this.txtBxCheckNum.Visible = false;
            // 
            // lblCheckNumber
            // 
            this.lblCheckNumber.AutoSize = true;
            this.lblCheckNumber.Location = new System.Drawing.Point(10, 236);
            this.lblCheckNumber.Name = "lblCheckNumber";
            this.lblCheckNumber.Size = new System.Drawing.Size(170, 28);
            this.lblCheckNumber.TabIndex = 16;
            this.lblCheckNumber.Text = "Check Number";
            this.lblCheckNumber.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 28);
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
            this.cmbBxPayment.Location = new System.Drawing.Point(22, 197);
            this.cmbBxPayment.Name = "cmbBxPayment";
            this.cmbBxPayment.Size = new System.Drawing.Size(369, 36);
            this.cmbBxPayment.TabIndex = 10;
            this.cmbBxPayment.Text = "Cash";
            this.cmbBxPayment.SelectedIndexChanged += new System.EventHandler(this.cmbBxPayment_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 28);
            this.label8.TabIndex = 6;
            this.label8.Text = "Date";
            // 
            // paymentDate
            // 
            this.paymentDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.paymentDate.Location = new System.Drawing.Point(22, 61);
            this.paymentDate.Name = "paymentDate";
            this.paymentDate.Size = new System.Drawing.Size(369, 34);
            this.paymentDate.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBxBalance);
            this.groupBox1.Controls.Add(this.lblOutstandingBalance);
            this.groupBox1.Controls.Add(this.txtBxName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 168);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // txtBxBalance
            // 
            this.txtBxBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.txtBxBalance.Enabled = false;
            this.txtBxBalance.Location = new System.Drawing.Point(143, 128);
            this.txtBxBalance.Name = "txtBxBalance";
            this.txtBxBalance.Size = new System.Drawing.Size(227, 34);
            this.txtBxBalance.TabIndex = 19;
            // 
            // lblOutstandingBalance
            // 
            this.lblOutstandingBalance.AutoSize = true;
            this.lblOutstandingBalance.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblOutstandingBalance.Location = new System.Drawing.Point(139, 91);
            this.lblOutstandingBalance.Name = "lblOutstandingBalance";
            this.lblOutstandingBalance.Size = new System.Drawing.Size(232, 28);
            this.lblOutstandingBalance.TabIndex = 20;
            this.lblOutstandingBalance.Text = "Outstanding Balance";
            // 
            // txtBxName
            // 
            this.txtBxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.txtBxName.Enabled = false;
            this.txtBxName.Location = new System.Drawing.Point(144, 54);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(227, 34);
            this.txtBxName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(295, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CustomerPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(210)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(401, 577);
            this.Controls.Add(this.btnRecordPayment);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(223, 20);
            this.Name = "CustomerPayment";
            this.Text = "Customer Payment";
            this.Load += new System.EventHandler(this.CustomerPayment_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRecordPayment;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBxCheckNum;
        private System.Windows.Forms.Label lblCheckNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbBxPayment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker paymentDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxPaymentAmount;
        private System.Windows.Forms.Label lblPaymentAmount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtBxBalance;
        private System.Windows.Forms.Label lblOutstandingBalance;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}