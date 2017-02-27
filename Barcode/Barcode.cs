using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Barcode
{
    public partial class Barcode : Form
    {
        public Barcode()
        {



            InitializeComponent();
            txtIbanAcc.Text = "FI8957800720058432";
            txtReference.Text = "750473873";
            txtAmount.Text = "334,50";
            dtDueDate.Text = "15.02.2017";

            dtDueDate.Format = DateTimePickerFormat.Custom;
            dtDueDate.CustomFormat = "yyMMdd";

        }    

        private void btnBarcode_Click(object sender, EventArgs e)
        {
            string Iban = txtIbanAcc.Text;
            string Amount = txtAmount.Text;
            string DueDate = dtDueDate.Text;
            string Reference = txtReference.Text;
            bool DomOrInt = false;
            
            if (radioBtnDom.Checked == true)
            {
                DomOrInt = false;
            }
            else
            {
                DomOrInt = true;
            }

            if (Iban !="" && Amount !="" && DueDate !="")
            {
                
                clsBarcode Barcode = new clsBarcode();
                Barcode.Iban = Iban;
                Barcode.Amount = Amount;
                Barcode.Duedate = DueDate;
                Barcode.Reference = Reference;
                Barcode.DomOrInt = DomOrInt;
                Barcode.calculatebarcode();

                lblBarcode.Text = Barcode.Barcode;
                txtBarcode.Text = lblBarcode.Text;
                txtEncodedBarcode.Text = lblBarcode.Text;
                
            }
            else
            {
                MessageBox.Show("Please give all necessary values!");
            }

        }

        private void dtDueDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioBtnDom_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtEncodedBarcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }
    }
}
