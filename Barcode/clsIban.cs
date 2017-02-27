using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcode
{
    class clsIban
    {
        //local variables
        private string iban;
        private string reference;
        private string amount;
        private string duedate;
        private string barcode;

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



        //Methods
        public string calculatebarcode()
        {


            return "0";
        }

    }
}
