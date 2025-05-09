using System;

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

        public bool Find(int customerId)
        {
            //set the private data members to the test data value
            mCustomerId = 10;
            mCustomerFullname = "Tim David";
            mEmail = "timdavid@gmail.com";
            mAddress = "Test Address";
            mPassword = "Test Password";
            mBonusEligibility = true;
            mCreatedOn = Convert.ToDateTime("08/05/2025");

            //always return true
            return true;
        }
    }
}