using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace SOFT130Project
{
    class Account
    {

        private string sortCode;
        private long accountNumber;
        private string nickName;
        private string dateCreated;
        private decimal currentBalance;
        private decimal overdraftLimit;
        private int numTransasctions;

        private ArrayList transactionList;

        public Account(string this_sortCode, long this_accountNumber, string this_nickName,
                string this_dateCreated, decimal this_currentBalance, decimal this_overdraftLimit,
                int this_numTransasctions)
        {
            sortCode = this_sortCode;
            accountNumber = this_accountNumber;
            nickName = this_nickName;
            dateCreated = this_dateCreated;
            currentBalance = this_currentBalance;
            overdraftLimit = this_overdraftLimit;
            numTransasctions = this_numTransasctions;
           
        }

        //all public 'setter' methods
        public void settransactionList(ArrayList this_transactionList)
        {
            transactionList = this_transactionList;
        }  


        //all public 'getter' methods
        public string getsortCode()
        {
            return sortCode;
        }

        public long getaccountNumber()
        {
            return accountNumber;
        }

        public string getnickName()
        {
            return nickName;
        }

        public string getdateCreated()
        {
            return dateCreated;
        }

        public decimal getcurrentBalance()
        {
            return currentBalance;
        }

        public decimal getoverdraftLimit()
        {
            return overdraftLimit;
        }

        public int getnumTransasctions()
        {
            return numTransasctions;
        }

        public ArrayList gettransactionList()
        {
            return transactionList;
        }


    }
}
