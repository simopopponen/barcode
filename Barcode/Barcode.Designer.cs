namespace Barcode
{
    partial class Barcode
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
            this.btnBarcode = new System.Windows.Forms.Button();
            this.lblIbanAcc = new System.Windows.Forms.Label();
            this.txtIbanAcc = new System.Windows.Forms.TextBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.dtDueDate = new System.Windows.Forms.DateTimePicker();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnInt = new System.Windows.Forms.RadioButton();
            this.radioBtnDom = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.txtEncodedBarcode = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBarcode
            // 
            this.btnBarcode.Location = new System.Drawing.Point(60, 532);
            this.btnBarcode.Name = "btnBarcode";
            this.btnBarcode.Size = new System.Drawing.Size(162, 23);
            this.btnBarcode.TabIndex = 0;
            this.btnBarcode.Text = "Barcode";
            this.btnBarcode.UseVisualStyleBackColor = true;
            this.btnBarcode.Click += new System.EventHandler(this.btnBarcode_Click);
            // 
            // lblIbanAcc
            // 
            this.lblIbanAcc.AutoSize = true;
            this.lblIbanAcc.Location = new System.Drawing.Point(60, 43);
            this.lblIbanAcc.Name = "lblIbanAcc";
            this.lblIbanAcc.Size = new System.Drawing.Size(115, 13);
            this.lblIbanAcc.TabIndex = 1;
            this.lblIbanAcc.Text = "IBAN account number:";
            // 
            // txtIbanAcc
            // 
            this.txtIbanAcc.Location = new System.Drawing.Point(60, 59);
            this.txtIbanAcc.Name = "txtIbanAcc";
            this.txtIbanAcc.Size = new System.Drawing.Size(200, 20);
            this.txtIbanAcc.TabIndex = 2;
            // 
            // lblBarcode
            // 
            this.lblBarcode.Location = new System.Drawing.Point(57, 274);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(611, 40);
            this.lblBarcode.TabIndex = 3;
            this.lblBarcode.Text = "Barcode";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(57, 136);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(46, 13);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(60, 152);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(200, 20);
            this.txtAmount.TabIndex = 5;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(60, 196);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(74, 13);
            this.lblDueDate.TabIndex = 6;
            this.lblDueDate.Text = "The due date:";
            // 
            // dtDueDate
            // 
            this.dtDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDueDate.Location = new System.Drawing.Point(60, 212);
            this.dtDueDate.Name = "dtDueDate";
            this.dtDueDate.Size = new System.Drawing.Size(200, 20);
            this.dtDueDate.TabIndex = 7;
            this.dtDueDate.Value = new System.DateTime(2017, 2, 22, 0, 0, 0, 0);
            this.dtDueDate.ValueChanged += new System.EventHandler(this.dtDueDate_ValueChanged);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(60, 317);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(608, 20);
            this.txtBarcode.TabIndex = 8;
            this.txtBarcode.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnInt);
            this.groupBox1.Controls.Add(this.radioBtnDom);
            this.groupBox1.Location = new System.Drawing.Point(307, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Domestic or international";
            // 
            // radioBtnInt
            // 
            this.radioBtnInt.AutoSize = true;
            this.radioBtnInt.Location = new System.Drawing.Point(7, 59);
            this.radioBtnInt.Name = "radioBtnInt";
            this.radioBtnInt.Size = new System.Drawing.Size(83, 17);
            this.radioBtnInt.TabIndex = 1;
            this.radioBtnInt.Text = "International";
            this.radioBtnInt.UseVisualStyleBackColor = true;
            // 
            // radioBtnDom
            // 
            this.radioBtnDom.AutoSize = true;
            this.radioBtnDom.Checked = true;
            this.radioBtnDom.Location = new System.Drawing.Point(7, 20);
            this.radioBtnDom.Name = "radioBtnDom";
            this.radioBtnDom.Size = new System.Drawing.Size(69, 17);
            this.radioBtnDom.TabIndex = 0;
            this.radioBtnDom.TabStop = true;
            this.radioBtnDom.Text = "Domestic";
            this.radioBtnDom.UseVisualStyleBackColor = true;
            this.radioBtnDom.CheckedChanged += new System.EventHandler(this.radioBtnDom_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Reference:";
            // 
            // txtReference
            // 
            this.txtReference.Location = new System.Drawing.Point(60, 103);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(200, 20);
            this.txtReference.TabIndex = 11;
            // 
            // txtEncodedBarcode
            // 
            this.txtEncodedBarcode.Font = new System.Drawing.Font("Code 128", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncodedBarcode.Location = new System.Drawing.Point(60, 385);
            this.txtEncodedBarcode.Name = "txtEncodedBarcode";
            this.txtEncodedBarcode.Size = new System.Drawing.Size(608, 72);
            this.txtEncodedBarcode.TabIndex = 12;
            this.txtEncodedBarcode.TextChanged += new System.EventHandler(this.txtEncodedBarcode_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Barcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 620);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtEncodedBarcode);
            this.Controls.Add(this.txtReference);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.dtDueDate);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblBarcode);
            this.Controls.Add(this.txtIbanAcc);
            this.Controls.Add(this.lblIbanAcc);
            this.Controls.Add(this.btnBarcode);
            this.Name = "Barcode";
            this.Text = "Barcode";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBarcode;
        private System.Windows.Forms.Label lblIbanAcc;
        private System.Windows.Forms.TextBox txtIbanAcc;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.DateTimePicker dtDueDate;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnInt;
        private System.Windows.Forms.RadioButton radioBtnDom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.TextBox txtEncodedBarcode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}

