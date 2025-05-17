using System;
using System.Net.NetworkInformation;
using System.Linq.Expressions;
using System.Runtime.Remoting;

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

        public string Valid(string customerId, string orderDate, string totalAmount, string status, string paymentMethod)
        {
            //create a variable to store the error
            string Error = "";
            //create a temporary date variable
            DateTime DateTemp;
            //if CustomerId is blank
            if (customerId.Length == 0)
            {
                Error = Error + "Customer ID cannot be blank: ";
            }
            //if CustomerId length is greater than 12
            if (customerId.Length > 12)
            {
                Error = Error + "Customer ID must be less than 12 characters: ";
            }

            //if OrderDate is blank
            if (orderDate.Length == 0)
            {
                Error = Error + "Order Date cannot be blank: ";
            }
            //validate the date
            try
            {
                DateTime TempDate = Convert.ToDateTime(orderDate);
                if (TempDate < DateTime.Now.Date)
                {
                    Error = Error + "Order Date cannot be in the past: ";
                }
                if (TempDate > DateTime.Now.Date)
                {
                    Error = Error + "Order Date cannot be in the future: ";
                }
            }
            catch
            {
                Error = Error + "Order Date is not a valid date: ";
            }

            //if TotalAmount is blank
            if (totalAmount.Length == 0)
            {
                Error = Error + "Total Amount cannot be blank: ";
            }
            //if TotalAmount length is greater than 80
            if (totalAmount.Length > 80)
            {
                Error = Error + "Total Amount must be less than 80 characters: ";
            }

            //if Status is blank
            if (status.Length == 0)
            {
                Error = Error + "Status cannot be blank: ";
            }
            //if Status length is greater than 50
            if (status.Length > 50)
            {
                Error = Error + "Status must be less than 50 characters: ";
            }

            //if PaymentMethod is blank
            if (paymentMethod.Length == 0)
            {
                Error = Error + "Payment Method cannot be blank: ";
            }
            //if PaymentMethod length is greater than 30
            if (paymentMethod.Length > 30)
            {
                Error = Error + "Payment Method must be less than 30 characters: ";
            }

            //return any error message
            return Error;
        }
    }
}