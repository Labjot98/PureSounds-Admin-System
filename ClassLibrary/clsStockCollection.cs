using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
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



        List<clsStock1> mStockList = new List<clsStock1>();


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
        public clsStock1 ThisStock { get; set; }
    }
}