using System;
using System.Linq.Expressions;
using System.Runtime.Remoting;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for the address id property
        private Int32 mCustomerId;
        //CustomerId public property
        public int CustomerId
        {
            get
            {
                //this line of code sends data  out of the property
                return mCustomerId;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerId = value;
            }
        }

        //private data member for the customer full name property
        private string mCustomerFullname;
        //CustomerFullname public property
        public string CustomerFullname
        {
            get
            {
                //this line of code sends data  out of the property
                return mCustomerFullname;
            }
            set
            {
                //this line of code allows data  into the property
                mCustomerFullname = value;
            }
        }

        //private data member for email property
        private string mEmail;
        //Email public property
        public string Email
        {
            get
            {
                //this line of code sends data  out of the property
                return mEmail;
            }
            set
            {
                //this line of code allows data into the property
                mEmail = value;
            }
        }

        //private data member for address property
        private string mAddress;
        //Address public property
        public string Address
        {
            get
            {
                //this line of code sends data  out of the property
                return mAddress;
            }
            set
            {
                //this line of code allows data into the property
                mAddress = value;
            }
        }

        //private data member for password property
        private string mPassword;
        //Password public property
        public string Password
        {
            get
            {
                //this line of code sends data  out of the property
                return mPassword;
            }
            set
            {
                //this line of code allows data into the property
                mPassword = value;
            }
        }

        //private data member for bonus eligibility property
        private Boolean mBonusEligibility;
        //BonusEligibility public property
        public bool BonusEligibility
        {
            get
            {
                //this line of code sends data  out of the property
                return mBonusEligibility;
            }
            set
            {
                //this line of code allows data into the property
                mBonusEligibility = value;
            }
        }

        //private data member for date time  property
        private DateTime mCreatedOn;
        //CreatedOn public property
        public DateTime CreatedOn
        {
            get
            {
                //this line of code sends data  out of the property
                return mCreatedOn;
            }
            set
            {
                //this line of code allows data into the property
                mCreatedOn = value;
            }
        }

        public bool Find(int CustomerId)
        {

            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //add the parameter for the customer id to search for
            DB.AddParameter("@CustomerId", CustomerId);

            //executer the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerId");

            //if one record is found (there sould be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data member
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mCustomerFullname = Convert.ToString(DB.DataTable.Rows[0]["CustomerFullname"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mBonusEligibility = Convert.ToBoolean(DB.DataTable.Rows[0]["BonusEligibility"]);
                mCreatedOn = Convert.ToDateTime(DB.DataTable.Rows[0]["CreatedOn"]);

                //return that everything worked OK
                return true;
            }

            //if no record was found
            else
            {
                //return false indicating there is a problem
                return false;
            }
        }

        public string Valid(string customerFullname,  string email, string address, string password, string createdOn)
        {
            //create a variable to store the error
            string Error = "";
            //create a temporary date variable
            DateTime DateTemp;

            //if CustomerFullname is blank
            if(customerFullname.Length == 0)
            {
                Error = Error + "Customer Full name cannot be blank: ";
            }
            //if CustomerFullname is greater than 100
            if(customerFullname.Length > 100)
            {
                {
                    Error = Error + "Customer Full name must be less than 100 characters: ";
                }
            }

            //if Email is blank
            if(email.Length == 0)
            {
                Error = Error + "Customer email cannot be blank: ";

            }
            //if Email length is greater than 50
            if (email.Length > 50)
            {
                {
                    Error = Error + "Customer email must be less than 50 characters: ";
                }
            }

            //if Address is blank
            if (address.Length == 0)
            {
                Error = Error + "Customer Address cannot be blank: ";

            }
            //if Address length is greater than 200
            if (address.Length > 200)
            {
                {
                    Error = Error + "Customer Address must be less than 200 characters: ";
                }
            }

            //if Password is blank
            if (password.Length == 0)
            {
                Error = Error + "Password cannot be blank: ";

            }
            //if Address length is greater than 40
            if (password.Length > 40)
            {
                {
                    Error = Error + "Password must be less than 40 characters: ";
                }
            }

          
            try
            {
                //copy the createdOn value to DateTemp
                DateTemp = Convert.ToDateTime(createdOn);
                //check if its less than today's date
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in past";
                }
                //if date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in future";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date";
            }


            //return any error message
            return Error;
        }
    }
}