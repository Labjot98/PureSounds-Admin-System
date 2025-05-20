using System;
using System.Collections.Generic;
using System.Net;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        public clsCustomerCollection()
        {
            //variable for the index
            Int32 Index = 0;

            //variable to store the record count
            Int32 RecordCount = 0;

            //creating the db connection
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");

            //get the count of records
            RecordCount = DB.Count;

            //while there are records to process
            while(Index < RecordCount)
            {
                //create a blank Customer
                clsCustomer ACustomer = new clsCustomer();

                //read in the fields for the current record
                ACustomer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                ACustomer.CustomerFullname = Convert.ToString(DB.DataTable.Rows[Index]["CustomerFullname"]);
                ACustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                ACustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                ACustomer.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                ACustomer.BonusEligibility = Convert.ToBoolean(DB.DataTable.Rows[Index]["BonusEligibility"]);
                ACustomer.CreatedOn = Convert.ToDateTime(DB.DataTable.Rows[Index]["CreatedOn"]);

                //add the record to the private data member
                mCustomerList.Add(ACustomer);

                //point to next record
                Index++;
            }

            //create the items to test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerId = 1;
            TestItem.CustomerFullname = "Tim David";
            TestItem.Email = "timdavid@gmail.com";
            TestItem.Password = "timdavid123";
            TestItem.Address = "92 Some Street, LE1 4AD, Leicester";
            TestItem.BonusEligibility = true;
            TestItem.CreatedOn = DateTime.Now;

            //add the test item to the test list
            mCustomerList.Add(TestItem);

            //re initialise the object
            TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerId = 2;
            TestItem.CustomerFullname = "Josh Inglis";
            TestItem.Email = "josh@gmail.com";
            TestItem.Password = "joshinglis123";
            TestItem.Address = "7 Another Street, LE1 2AD, Leicester";
            TestItem.BonusEligibility = true;
            TestItem.CreatedOn = DateTime.Now;

            //add the test item to the test list
            mCustomerList.Add(TestItem);
        }

        //private data member for the list
        private List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //public property for the customer list
        public List<clsCustomer> CustomerList
        { 
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                return CustomerList.Count;
            }
            set
            {
                //LATER
            }
        }

        //private data member for the ThisCustomer
        clsCustomer mThisCustomer = new clsCustomer();
        public clsCustomer ThisCustomer
        {
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisCustomer
            //creating the db connection
            clsDataConnection DB = new clsDataConnection();

            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerFullname", mThisCustomer.CustomerFullname);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@Password", mThisCustomer.Password);
            DB.AddParameter("@BonusEligibility", mThisCustomer.BonusEligibility);
            DB.AddParameter("@CreatedOn", mThisCustomer.CreatedOn);

            //executer the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");
        }
    }
}