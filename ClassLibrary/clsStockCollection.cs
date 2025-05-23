using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {

        //private data member for the list
        List<clsStock1> mStockList = new List<clsStock1>();
        clsStock1 mThisStock = new clsStock1();

        public clsStockCollection()
        {

          //object for data connection
          clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblHeadphone_SelectAll");
            PopuateArray(DB);


        }
        void PopuateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            RecordCount = DB.Count;
            mStockList = new List<clsStock1>();

            //while there are no records to process
            while (Index < RecordCount)
            {
                clsStock1 AStock = new clsStock1();


                AStock.Bluetooth = Convert.ToBoolean(DB.DataTable.Rows[Index]["Bluetooth"]);
                AStock.ItemID = Convert.ToInt32(DB.DataTable.Rows[Index]["ItemID"]);
                AStock.ItemName = Convert.ToString(DB.DataTable.Rows[Index]["ItemName"]);
                AStock.DatePosted = Convert.ToDateTime(DB.DataTable.Rows[Index]["DatePosted"]);
                AStock.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AStock.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                AStock.Brand = Convert.ToString(DB.DataTable.Rows[Index]["Brand"]);

                mStockList.Add(AStock);
                Index++;
            }
        }



        //List<clsStock1> mStockList = new List<clsStock1>();


        public List<clsStock1> StockList
        {
            get { return mStockList; }
            set { mStockList = value; }
        }
        public int Count
        {
            get { return mStockList.Count; }
            set { }
        }
        public clsStock1 ThisStock
        {
            get
            {
                return mThisStock;
            }
            set
            {
                mThisStock = value;
            }
        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisStock
            //connect to the databse
            clsDataConnection DB = new clsDataConnection();

            //set params for the stored procedure
            DB.AddParameter("ItemName", mThisStock.ItemName);
            DB.AddParameter("DatePosted", mThisStock.DatePosted);
            DB.AddParameter("Quantity", mThisStock.Quantity);
            DB.AddParameter("Bluetooth", mThisStock.Bluetooth);
            DB.AddParameter("Price", mThisStock.Price);
            DB.AddParameter("Brand", mThisStock.Brand);

            return DB.Execute("sproc_tblHeadPhone_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisStock
            //connect to the databse
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ItemID", mThisStock.ItemID);
            //execute stored procedure
            DB.Execute("sproc_tblHeadPhone_Delete");
        }

        public void ReportByItemName(string ItemName)
        {
            //filters record based on a full or partial ItemNme
            //connect to the databse
            clsDataConnection DB = new clsDataConnection();
            //send the postcode parameter to the databse
            DB.AddParameter("@ItemName", ItemName);
            //execute the stored procedure
            DB.Execute("sproc_tblHeadPhone_FilterByItemName");
            //populate the arraylist with the data table
            PopuateArray(DB);

        }

        public void Update()
        {
            //update an existing record based on the values of thisStock
            //Connect to the Database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new stored procedure
            DB.AddParameter("ItemID", mThisStock.ItemID);
            DB.AddParameter("ItemName", mThisStock.ItemName);
            DB.AddParameter("DatePosted", mThisStock.DatePosted);
            DB.AddParameter("Quantity", mThisStock.Quantity);
            DB.AddParameter("Bluetooth", mThisStock.Bluetooth);
            DB.AddParameter("Price", mThisStock.Price);
            DB.AddParameter("Brand", mThisStock.Brand);

            //execute stored procedure,
            DB.Execute("sproc_tblHeadPhone_Update");

        }
    }
}