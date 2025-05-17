using System;
using System.Net.NetworkInformation;

namespace ClassLibrary
{
    public class clsOrder
    {
        //private data member for the order id property
        private Int32 mOrderId;
        //order id public property
        public int OrderId
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderId;
            }
            set
            {
                //this line of code allows data into the property
                mOrderId = value;
            }
        }

        //private data member for the customer id property
        private Int32 mCustomerId;
        //customer id public property
        public int CustomerId
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerId;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerId = value;
            }
        }

        //private data member for the order date property
        private DateTime mOrderDate;
        //order date public property
        public DateTime OrderDate
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderDate;
            }
            set
            {
                //this line of code allows data into the property
                mOrderDate = value;
            }
        }

        //private data member for the total amount property
        private Decimal mTotalAmount;
        //total amount public property
        public Decimal TotalAmount
        {
            get
            {
                //this line of code sends data out of the property
                return mTotalAmount;
            }
            set
            {
                //this line of code allows data into the property
                mTotalAmount = value;
            }
        }

        //private data member for the status property
        private string mStatus;
        //status public property
        public string Status
        {
            get
            {
                //this line of code sends data out of the property
                return mStatus;
            }
            set
            {
                //this line of code allows data into the property
                mStatus = value;
            }
        }

        //private data member for the discount applied property
        private Boolean mDiscountApplied;
        //discount applied public property
        public bool DiscountApplied
        {
            get
            {
                //this line of code sends data out of the property
                return mDiscountApplied;
            }
            set
            {
                //this line of code allows data into the property
                mDiscountApplied = value;
            }
        }

        //private data member for the payment method property
        private string mPaymentMethod;
        //payment method public property
        public string PaymentMethod
        {
            get
            {
                //this line of code sends data out of the property
                return mPaymentMethod;
            }
            set
            {
                //this line of code allows data into the property
                mPaymentMethod = value;
            }
        }

        public bool Find(int OrderId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the order id to search for
            DB.AddParameter("@OrderId", OrderId);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mTotalAmount = Convert.ToDecimal(DB.DataTable.Rows[0]["TotalAmount"]);
                mStatus = Convert.ToString(DB.DataTable.Rows[0]["Status"]);
                mDiscountApplied = Convert.ToBoolean(DB.DataTable.Rows[0]["DiscountApplied"]);
                mPaymentMethod = Convert.ToString(DB.DataTable.Rows[0]["PaymentMethod"]);
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
    }
}