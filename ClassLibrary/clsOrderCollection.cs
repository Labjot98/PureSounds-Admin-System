using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        public clsOrderCollection()
        {
            // object for the data connection
            clsDataConnection DB = new clsDataConnection();
            // execute the stored procedure to fetch all orders
            DB.Execute("sproc_tblOrder_SelectAll");
            // populate the order list with the table data
            PopulateOrderArray(DB);
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

        public void Delete()
        {
            // Deletes the record pointed to by ThisOrder
            // Connect to the database
            clsDataConnection DB = new clsDataConnection();

            // Set the parameter for the stored procedure
            DB.AddParameter("@OrderId", mThisOrder.OrderId);

            // Execute the stored procedure to delete the order
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void ReportByOrderDate(string OrderDate)
        {
            // filters the records based on a specific OrderDate (or partial Date if needed)
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // send the OrderDate parameter to the database
            DB.AddParameter("@OrderDate", OrderDate);  // you could use a DateTime or string depending on your format
                                                       // execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderDate");
            // populate the array list with the filtered table data
            PopulateOrderArray(DB);
        }

        void PopulateOrderArray(clsDataConnection DB)
        {
            // populates the array list based on the data table in the parameter DB
            // variable for the index
            Int32 Index = 0;
            // variable to store the record count
            Int32 RecordCount;
            // get the count of records
            RecordCount = DB.Count;
            // clear the private order list
            mOrderList = new List<clsOrder>();
            // while there are records to process
            while (Index < RecordCount)
            {
                // create a blank Order object
                clsOrder AnOrder = new clsOrder();
                // read in the fields from the current record
                AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnOrder.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.TotalAmount = Convert.ToDecimal(DB.DataTable.Rows[Index]["TotalAmount"]);
                AnOrder.Status = Convert.ToString(DB.DataTable.Rows[Index]["Status"]);
                AnOrder.DiscountApplied = Convert.ToBoolean(DB.DataTable.Rows[Index]["DiscountApplied"]);
                AnOrder.PaymentMethod = Convert.ToString(DB.DataTable.Rows[Index]["PaymentMethod"]);
                // add the record to the private data member
                mOrderList.Add(AnOrder);
                // point at the next record
                Index++;
            }
        }
    }
}