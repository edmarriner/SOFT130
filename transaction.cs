using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOFT130Project
{
    class Transaction
    {

        private string date;
        private string type;
        private string description;
        private decimal amount;
        private decimal balanceAfter;

        public Transaction(string this_date, string this_type, 
                string this_description, decimal this_amount, 
                decimal this_balanceAfter)
        {
            date = this_date;
            type = this_type;
            description = this_description;
            amount = this_amount;
            balanceAfter = this_balanceAfter;
        }

        public string getdate()
        {
            return date;
        }

        public string gettype()
        {
            return type;
        }

        public string getdescription()
        {
            return description;
        }

        public decimal getamount()
        {
            return amount;
        }

        public decimal getbalanceAfter()
        {
            return balanceAfter;
        }


    }
}
