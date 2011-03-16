using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOFT130Project
{
    public class file
    {

        private int currentCustomerNum = 0;
        private int currentAccountNum = 0;
        private ArrayList fileData = new ArrayList();

        public file()
        {
            //Do nothing
        }

        public void setcurrentCustomerNum(int this_currentCustomerNum){
            currentCustomerNum = this_currentCustomerNum;
        }

        public int getcurrentCustomerNum()
        {
            return currentCustomerNum;
        }

        public ArrayList readFile()
        {
            //Setup variables
            Dictionary<string, int> linesPerType = new Dictionary<string, int>();
            Dictionary<string, int> loopCount = new Dictionary<string, int>();
            Dictionary<string, int> numLoops = new Dictionary<string, int>();
            int lineCount = 0;
            string currentType = "customer";
            string line;

            fileData.Clear();
            
            ArrayList tempCustomerData = new ArrayList();
            ArrayList tempAccountData = new ArrayList();
            ArrayList tempTransactionData = new ArrayList();
            ArrayList tempAccountList = new ArrayList();
            ArrayList tempTransactionList = new ArrayList();

            //Initialize them
            linesPerType.Add("customer", 15); loopCount.Add("customer", 0); numLoops.Add("customer", 0);
            linesPerType.Add("account", 8); loopCount.Add("account", 0); numLoops.Add("account", 0);
            linesPerType.Add("transaction", 6); loopCount.Add("transaction", 0); numLoops.Add("transaction", 0);

            //Load the file then loop until there are no lines left

            //Old file name: e-Softies.txt. New file name: e-SOFT_v1.txt
            System.IO.StreamReader file = new System.IO.StreamReader("e-SOFT_v1.txt");
            while ((line = file.ReadLine()) != null)
            {
                //Incriment the line number, remove any whitespace at the start/end of lines
                //Stop if the line is blank
                lineCount++;
                line = line.Trim();
                if (line == "") { break; }

                //Put the line in the various ArrayLists depending on what we are doing at the moment
                if (currentType == "customer")
                {
                    tempCustomerData.Add(line);
                }
                else if (currentType == "account")
                {
                    tempAccountData.Add(line);
                }
                else
                {
                    tempTransactionData.Add(line);
                }

                //Have we reached the end of this type?
                if (lineCount >= linesPerType[currentType] - 1)
                {
                    
                    //Change the type to whatever is next, and setup the number of loops required
                    if (currentType == "customer")
                    {
                        currentType = "account";
                        numLoops["account"] = Convert.ToInt32(line) - 1;
                    }
                    else if (currentType == "account")
                    {
                        currentType = "transaction";
                        numLoops["transaction"] = Convert.ToInt32(line) - 1;
                    }
                    else
                    {

                        //We have come to the end of a single transaction
                        //Put the data in the class

                        Transaction thisTransaction = new Transaction(Convert.ToString(tempTransactionData[0]), 
                                Convert.ToString(tempTransactionData[1]), 
                                Convert.ToString(tempTransactionData[2]), 
                                Convert.ToDecimal(tempTransactionData[3]), 
                                Convert.ToDecimal(tempTransactionData[4])
                            );
                      

                        //Clear the data ArrayList ready for the next transaction, and add the data in the class to
                        //a list
                        tempTransactionData.Clear();
                        tempTransactionList.Add(thisTransaction);

                        //Have all the transactions finished?
                        if (loopCount[currentType] >= numLoops["transaction"])
                        {
                            //Add them to the account, along with the data for that account
                            Account thisAccount = new Account(Convert.ToString(tempAccountData[0]),
                                       Convert.ToInt64(tempAccountData[1]),
                                       Convert.ToString(tempAccountData[2]),
                                       Convert.ToString(tempAccountData[3]),
                                       Convert.ToDecimal(tempAccountData[4]),
                                       Convert.ToDecimal(tempAccountData[5]),
                                       Convert.ToInt32(tempAccountData[6])
                                   );

                            tempAccountList.Add(thisAccount);
                            tempAccountData.Clear();
                           

                            if (loopCount["account"] >= numLoops["account"])
                            {
                                //All accounts finished. Add to customer.
                         
                                Customer thisCustomer = new Customer(Convert.ToInt64(tempCustomerData[0]),
                                        Convert.ToString(tempCustomerData[1]),
                                        Convert.ToString(tempCustomerData[2]),
                                        Convert.ToString(tempCustomerData[3]),
                                        Convert.ToString(tempCustomerData[4]),
                                        Convert.ToString(tempCustomerData[5]),
                                        Convert.ToString(tempCustomerData[6]),
                                        Convert.ToString(tempCustomerData[7]),
                                        Convert.ToString(tempCustomerData[8]),
                                        Convert.ToString(tempCustomerData[9]),
                                        Convert.ToString(tempCustomerData[10]),
                                        Convert.ToString(tempCustomerData[11]),
                                        Convert.ToString(tempCustomerData[12]),
                                        Convert.ToInt32(tempCustomerData[13])
                                    );

                            
                                fileData.Add(thisCustomer);
                                tempCustomerData.Clear();
                                

                                //Finished this customer completely, setup for new customer.
                                currentType = "customer";
                                numLoops["account"] = 0;
                                numLoops["transaction"] = 0;
                                loopCount["account"] = 0;
                                loopCount["transaction"] = 0;
                            }
                            else
                            {
                                //Finished this account, there are more to be imported.
                                currentType = "account";
                                loopCount["transaction"] = 0;
                            }
                        }


                        //Inc the current loop
                        loopCount[currentType]++;
                    }

                    //Reset the line count to zero (as we have changed type)
                    lineCount = 0;

                }
                
            }

            //Close the file for use later
            file.Close();

            int nextAccount = 0;
            int numAccounts = 0;
            int nextTransaction = 0;
            int numTransactions = 0;

            //Put the customers accounts in the customer class
            foreach(Customer oneCustomer in fileData){

                numAccounts = oneCustomer.getnumAccounts();
                oneCustomer.setaccountList(tempAccountList.GetRange(nextAccount, numAccounts));
                nextAccount = nextAccount + numAccounts;

                //Put the transactions for each account in the correct class
                foreach(Account oneAccount in oneCustomer.getaccountList()){
                    numTransactions = oneAccount.getnumTransasctions();
                    oneAccount.settransactionList(tempTransactionList.GetRange(nextTransaction, numTransactions));
                    nextTransaction = nextTransaction + numTransactions;
                }

            }

            //Send the whole data back to where it was requested!
            return fileData;
           
        }

    }
}
