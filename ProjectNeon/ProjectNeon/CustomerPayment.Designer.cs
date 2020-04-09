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
            this.btnRecordPayment = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBxCheckNum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbBxPayment = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.paymentDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtBxPaymentAmount = new System.Windows.Forms.TextBox();
            this.lblPaymentAmount = new System.Windows.Forms.Label();
            this.txtBxBalance = new System.Windows.Forms.TextBox();
            this.lblOutstandingBalance = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRecordPayment
            // 
            this.btnRecordPayment.Location = new System.Drawing.Point(21, 359);
            this.btnRecordPayment.Name = "btnRecordPayment";
            this.btnRecordPayment.Size = new System.Drawing.Size(228, 54);
            this.btnRecordPayment.TabIndex = 28;
            this.btnRecordPayment.Text = "Record Payment";
            this.btnRecordPayment.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBxPaymentAmount);
            this.groupBox2.Controls.Add(this.lblPaymentAmount);
            this.groupBox2.Controls.Add(this.txtBxCheckNum);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cmbBxPayment);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.paymentDate);
            this.groupBox2.Location = new System.Drawing.Point(21, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 198);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment Information";
            // 
            // txtBxCheckNum
            // 
            this.txtBxCheckNum.Location = new System.Drawing.Point(6, 154);
            this.txtBxCheckNum.Name = "txtBxCheckNum";
            this.txtBxCheckNum.Size = new System.Drawing.Size(197, 20);
            this.txtBxCheckNum.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Check Number (if applicable)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 98);
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
            this.cmbBxPayment.Location = new System.Drawing.Point(6, 114);
            this.cmbBxPayment.Name = "cmbBxPayment";
            this.cmbBxPayment.Size = new System.Drawing.Size(197, 21);
            this.cmbBxPayment.TabIndex = 10;
            this.cmbBxPayment.Text = "Cash";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Date";
            // 
            // paymentDate
            // 
            this.paymentDate.Location = new System.Drawing.Point(6, 36);
            this.paymentDate.Name = "paymentDate";
            this.paymentDate.Size = new System.Drawing.Size(198, 20);
            this.paymentDate.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBxBalance);
            this.groupBox1.Controls.Add(this.lblOutstandingBalance);
            this.groupBox1.Controls.Add(this.txtBxName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 121);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // txtBxName
            // 
            this.txtBxName.Enabled = false;
            this.txtBxName.Location = new System.Drawing.Point(16, 39);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(188, 20);
            this.txtBxName.TabIndex = 0;
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtBxPaymentAmount
            // 
            this.txtBxPaymentAmount.Location = new System.Drawing.Point(7, 75);
            this.txtBxPaymentAmount.Name = "txtBxPaymentAmount";
            this.txtBxPaymentAmount.Size = new System.Drawing.Size(197, 20);
            this.txtBxPaymentAmount.TabIndex = 19;
            this.txtBxPaymentAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxPaymentAmount_KeyPress);
            // 
            // lblPaymentAmount
            // 
            this.lblPaymentAmount.AutoSize = true;
            this.lblPaymentAmount.Location = new System.Drawing.Point(4, 59);
            this.lblPaymentAmount.Name = "lblPaymentAmount";
            this.lblPaymentAmount.Size = new System.Drawing.Size(87, 13);
            this.lblPaymentAmount.TabIndex = 20;
            this.lblPaymentAmount.Text = "Payment Amount";
            // 
            // txtBxBalance
            // 
            this.txtBxBalance.Enabled = false;
            this.txtBxBalance.Location = new System.Drawing.Point(16, 80);
            this.txtBxBalance.Name = "txtBxBalance";
            this.txtBxBalance.Size = new System.Drawing.Size(188, 20);
            this.txtBxBalance.TabIndex = 19;
            // 
            // lblOutstandingBalance
            // 
            this.lblOutstandingBalance.AutoSize = true;
            this.lblOutstandingBalance.Location = new System.Drawing.Point(13, 64);
            this.lblOutstandingBalance.Name = "lblOutstandingBalance";
            this.lblOutstandingBalance.Size = new System.Drawing.Size(106, 13);
            this.lblOutstandingBalance.TabIndex = 20;
            this.lblOutstandingBalance.Text = "Outstanding Balance";
            // 
            // CustomerPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 435);
            this.Controls.Add(this.btnRecordPayment);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
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
        private System.Windows.Forms.Label label10;
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