using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace SOFT130Project
{
    class Customer
    {
        private int ID;
        private string title;
        private string firstName;
        private string initials; //Optional
        private string surname;
        private string dob;
        private string houseNameNumber;
        private string streetName;
        private string addressArea; //Optional
        private string cityTown;
        private string county;
        private string postcode;
        private string password;
        private ArrayList accountList;

        //constructor
        public Customer(int this_ID, string this_title, string this_firstName, 
                string this_initials, string this_surname, string this_dob, 
                string this_houseNameNumber, string this_streetName, string this_addressArea, 
                string this_cityTown, string this_county, string this_postcode, 
                string this_password, ArrayList this_accountList)
        {
            ID = this_ID;
            title = this_title;
            firstName = this_firstName;
            initials = this_initials;
            surname = this_surname;
            dob = this_dob;
            houseNameNumber = this_houseNameNumber;
            streetName = this_streetName;
            addressArea = this_addressArea;
            cityTown = this_cityTown;
            county = this_county;
            postcode = this_postcode;
            password = this_password;
            accountList = this_accountList;
        }

        //all class 'getter' methods
        public int getID()
        {
            return ID;
        }

        public string gettitle()
        {
            return title;
        }

        public string getfirstName()
        {
            return firstName;
        }

        public string getinitials()
        {
            return initials;
        }

        public string getsurname()
        {
            return surname;
        }

        public string getdob()
        {
            return dob;
        }

        public string gethouseNameNumber()
        {
            return houseNameNumber;
        }

        public string getstreetName()
        {
            return streetName;
        }

        public string getaddressArea()
        {
            return addressArea;
        }

        public string getcityTown()
        {
            return cityTown;
        }

        public string getcounty()
        {
            return county;
        }

        public string getpostcode()
        {
            return postcode;
        }

        public string getpassword()
        {
            return password;
        }

        public ArrayList getaccountList()
        {
            return accountList;
        }

    }
}
