using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        public clsOrderCollection()
        {
            //variable for the index
            Int32 Index = 0;

            //variable to store the record count
            Int32 RecordCount = 0;

            //creating the db connection
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");

            //get the count of records
            RecordCount = DB.Count;

            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank Order
                clsOrder AnOrder = new clsOrder();

                //read in the fields for the current record
                AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnOrder.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.TotalAmount = Convert.ToDecimal(DB.DataTable.Rows[Index]["TotalAmount"]);
                AnOrder.Status = Convert.ToString(DB.DataTable.Rows[Index]["Status"]);
                AnOrder.DiscountApplied = Convert.ToBoolean(DB.DataTable.Rows[Index]["DiscountApplied"]);
                AnOrder.PaymentMethod = Convert.ToString(DB.DataTable.Rows[Index]["PaymentMethod"]);

                //add the record to the private data member
                mOrderList.Add(AnOrder);

                //point to next record
                Index++;
            }

            //create the items to test data
            clsOrder TestOrder = new clsOrder();
            //set its properties
            TestOrder.OrderId = 1;
            TestOrder.CustomerId = 1;
            TestOrder.OrderDate = DateTime.Now;
            TestOrder.TotalAmount = 100.00M;
            TestOrder.Status = "Pending";
            TestOrder.DiscountApplied = true;
            TestOrder.PaymentMethod = "Credit Card";

            //add the test item to the test list
            mOrderList.Add(TestOrder);

            //re initialise the object
            TestOrder = new clsOrder();
            //set its properties
            TestOrder.OrderId = 2;
            TestOrder.CustomerId = 2;
            TestOrder.OrderDate = DateTime.Now;
            TestOrder.TotalAmount = 200.00M;
            TestOrder.Status = "Shipped";
            TestOrder.DiscountApplied = false;
            TestOrder.PaymentMethod = "PayPal";

            //add the test item to the test list
            mOrderList.Add(TestOrder);
        }




        //private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();

        //private data member for this Order
        clsOrder mThisOrder = new clsOrder();

        //public property for the order list
        public List<clsOrder> OrderList
        {
            get
            {
                //return the private data
                return mOrderList;
            }
            set
            {
                //set the private data
                mOrderList = value;
            }
        }

        //public property for the count of orders
        public int Count
        {
            get
            {
                return OrderList.Count;
            }
            set
            {
                //later
            }
        }

        //public property for the current order being worked with
        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }

        public int Add()
        {
            // Create a new instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            // Set the parameters for the stored procedure using mThisOrder
            DB.AddParameter("@CustomerId", mThisOrder.CustomerId);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@TotalAmount", mThisOrder.TotalAmount);
            DB.AddParameter("@Status", mThisOrder.Status);
            DB.AddParameter("@DiscountApplied", mThisOrder.DiscountApplied);
            DB.AddParameter("@PaymentMethod", mThisOrder.PaymentMethod);

            // Execute the stored procedure and get the primary key (OrderId) returned by the stored procedure
            return Convert.ToInt32(DB.Execute("sproc_tblOrder_Insert"));
        }

        public void Update()
        {
            // Update an existing record based on the values of ThisOrder
            // Connect to the database
            clsDataConnection DB = new clsDataConnection();

            // Set the parameters for the stored procedure
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            DB.AddParameter("@CustomerId", mThisOrder.CustomerId);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@TotalAmount", mThisOrder.TotalAmount);
            DB.AddParameter("@Status", mThisOrder.Status);
            DB.AddParameter("@DiscountApplied", mThisOrder.DiscountApplied);
            DB.AddParameter("@PaymentMethod", mThisOrder.PaymentMethod);

            // Execute the stored procedure
            DB.Execute("sproc_tblOrder_Update");
        }
    }
}