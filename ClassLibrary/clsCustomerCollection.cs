using System;
using System.Collections.Generic;
using System.Net;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        public clsCustomerCollection()
        {
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");

            //populate the array list with the data table
            PopulateArray(DB);
        }

        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();

        //private data member for the ThisCustomer
        clsCustomer mThisCustomer = new clsCustomer();

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
                return mCustomerList.Count;
            }
            set
            {
                //LATER
            }
        }

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

        void PopulateArray(clsDataConnection DB)
        {
            //populate the array list based on the data table in the parameter DB
            //variable for the index
            Int32 Index = 0;

            //variable to store the record count
            Int32 RecordCount = 0;

            //get the count of records
            RecordCount = DB.Count;

            //clear the private array list
            mCustomerList = new List<clsCustomer>();

            //while there are records to process
            while (Index < RecordCount)
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

        public void Update()
        {
            //update an existing record based on the values of mThisCustomer
            //creating the db connection
            clsDataConnection DB = new clsDataConnection();

            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            DB.AddParameter("@CustomerFullname", mThisCustomer.CustomerFullname);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@Password", mThisCustomer.Password);
            DB.AddParameter("@BonusEligibility", mThisCustomer.BonusEligibility);
            DB.AddParameter("@CreatedOn", mThisCustomer.CreatedOn);

            //executer the stored procedure
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            //delete the record pointed to by thisCustomer
            //creating the db connection
            clsDataConnection DB = new clsDataConnection();

            //set the parameter for the stored procedure
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);

            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByFullname(string Fullname)
        {
            //filters the records based on a full or partial name
            //creating the db connection
            clsDataConnection DB = new clsDataConnection();

            //set the parameter for the stored procedure
            DB.AddParameter("@Fullname", Fullname);

            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByFullname");

            //populate the array list with the data table
            PopulateArray(DB);
        }
    }
}