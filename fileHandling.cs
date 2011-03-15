using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOFT130Project
{
    public class fileHandling
    {
        public static ArrayList readFile()
        {
            //Setup variables
            Dictionary<string, int> linesPerType = new Dictionary<string, int>();
            Dictionary<string, int> loopCount = new Dictionary<string, int>();
            Dictionary<string, int> numLoops = new Dictionary<string, int>();
            int lineCount = 0;
            string currentType = "customer";
            string line;
            string TEMPreturnString = "";
            ArrayList fileData = new ArrayList();
            ArrayList tempCustomerData = new ArrayList();
            ArrayList tempAccountData = new ArrayList();
            ArrayList tempTransactionData = new ArrayList();

            ArrayList tempAccountList = new ArrayList();
            ArrayList tempTransactionList = new ArrayList();

            //Initialize them
            linesPerType.Add("customer", 15); loopCount.Add("customer", 0); numLoops.Add("customer", 0);
            linesPerType.Add("account", 8); loopCount.Add("account", 0); numLoops.Add("account", 0);
            linesPerType.Add("transaction", 6); loopCount.Add("transaction", 0); numLoops.Add("transaction", 0);

            System.IO.StreamReader file = new System.IO.StreamReader("e-Softies.txt");
            while ((line = file.ReadLine()) != null)
            {
                lineCount++;
                line = line.Trim();
                if (line == "") { break; }

                TEMPreturnString += currentType + " - \t" + line + Environment.NewLine;

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

                if (lineCount >= linesPerType[currentType] - 1)
                {
                    TEMPreturnString += Environment.NewLine;

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

                        //End of Transaction.

                        Transaction thisTransaction = new Transaction(Convert.ToString(tempTransactionData[0]), 
                                Convert.ToString(tempTransactionData[1]), 
                                Convert.ToString(tempTransactionData[2]), 
                                Convert.ToDecimal(tempTransactionData[3]), 
                                Convert.ToDecimal(tempTransactionData[4])
                            );
                      
                        tempTransactionData.Clear();
                        tempTransactionList.Add(thisTransaction);

                        if (loopCount[currentType] >= numLoops["transaction"])
                        {
                            //All transactions finished, add to account.

                           

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
                                //All accounts finished. Add to customer

                             

                                Customer thisCustomer = new Customer(Convert.ToInt32(tempCustomerData[0]),
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
                                //Finished this account ONLY, there are more to be imported.
                                currentType = "account";
                                loopCount["transaction"] = 0;
                            }
                        }
                        loopCount[currentType]++;
                    }

                    lineCount = 0;

                }
                
            }

            file.Close();

            int nextAccount = 0;
            int numAccounts = 0;
            int nextTransaction = 0;
            int numTransactions = 0;

            foreach(Customer oneCustomer in fileData){

                numAccounts = oneCustomer.getnumAccounts();
                oneCustomer.setaccountList(tempAccountList.GetRange(nextAccount, numAccounts));
                nextAccount = nextAccount + numAccounts;

                foreach(Account oneAccount in oneCustomer.getaccountList()){
                    numTransactions = oneAccount.getnumTransasctions();
                    oneAccount.settransactionList(tempTransactionList.GetRange(nextTransaction, numTransactions));
                    nextTransaction = nextTransaction + numTransactions;
                }

            }



            return fileData;
            //return TEMPreturnString;

        }

    }
}
