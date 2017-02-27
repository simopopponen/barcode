using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcode
{
    class clsBarcode
    {
        //local variables
        private string iban;
        private string reference;
        private string amount;
        private string duedate;
        private string barcode;
        private bool domorint;

        //Properties
        public string Iban
        {
            set { iban = value; }
        }

        public string Reference
        {
            set { reference = value; }
        }

        public string Amount
        {
            set { amount = value; }
        }

        public string Duedate
        {
            set { duedate = value; }
        }

        public string Barcode
        {
            get { return barcode; }
        }

        public bool DomOrInt
        {
            set { domorint = value; }
        }
        


        //Methods
        public string calculatebarcode()
        {
            if (domorint == false)
            {
                barcode = "4";
            }
            else
            {
                barcode = "5";
            }

            barcode = barcode + checkiban();
            barcode = barcode + checkamount();
            barcode = barcode + "000";
            barcode = barcode + calculatereference();
            barcode = barcode + calculateduedate();

            return "0";
        }
        private string checkiban()
        {
            //16 digits without FI
            iban = iban.Substring(2);

            return iban;
        }

        private string checkamount()
        {
            //TODO if there is no zeros in the end you must add them.....
            amount = amount.Replace(",", "");
            amount = amount.Replace(".", "");

            int hlpamount = 0;

            if (int.TryParse(amount, out hlpamount))
            {
                if (hlpamount > 99999999)
                {
                    amount = "00000000";
                }
                else
                {
                    amount = Convert.ToString(hlpamount);
                    int j = amount.Length;
                    for (int i = 0; i < j; i++)
                    {
                        amount = "0" + amount;
                        int k = amount.Length;
                        if (k > 8)
                        {
                            i = j;
                        }
                    }
                }
            }

            return amount;
        }
        private string calculatereference()
        {

            int j = 20 - reference.Length;
            for (int i = 0; i < j; i++)
            {
                reference = "0" + reference;
                int k = reference.Length;
                if (k > 19)
                {
                    i = j;
                }

            }
            return reference;
        }
        private string calculateduedate()
        {
            //vvkkpp

            return duedate;
        }
        
    }

}