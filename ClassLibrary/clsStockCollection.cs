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

            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblHeadPhone_selectAll");

            RecordCount = DB.Count;

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