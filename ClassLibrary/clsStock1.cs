using System;

namespace ClassLibrary
{
    public class clsStock1
    {
        //private data member for ItemID
        private int mItemID;
        //public property for ItemID
        public int ItemID
        {
            get
            {
                //sends data out of the property
                return mItemID;
            }
            set
            {
                //allows data into the property
                mItemID = value;
            }
        }

        //private data member for ItemName
        private string mItemName;
        public string ItemName
        {
            get
            {   
                //send data out
                return mItemName;
            }
            set
            {   
                //allows data intot the property
                mItemName = value;
            }
        }

        private DateTime mDatePosted;
        public DateTime DatePosted
        {
            get
            {
                return mDatePosted;
            }
            set
            {
                mDatePosted = value;
            }
        }

        private int mQuantity;
        public int Quantity
        {
            get
            {
                return mQuantity;
            }
            set
            {
                mQuantity = value;
            }
        }

        private bool mBluetooth;
        public bool Bluetooth
        {
            get
            {
                return mBluetooth;
            }
            set
            {
                mBluetooth = value;
            }
        }

        private decimal mPrice;
        public decimal Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }

        private string mBrand;
        public string Brand
        {
            get
            {
                return mBrand;
            }
            set
            {
                mBrand = value;
            }
        }

        public bool Find(int ItemID)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@ItemID", ItemID);

            DB.Execute("sproc_tblHeadphone_FilterByItemID");

            if (DB.Count == 1)
            {
                mItemID = Convert.ToInt32(DB.DataTable.Rows[0]["ItemID"]);
                mItemName = Convert.ToString(DB.DataTable.Rows[0]["ItemName"]);
                mDatePosted = Convert.ToDateTime(DB.DataTable.Rows[0]["DatePosted"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mBluetooth = Convert.ToBoolean(DB.DataTable.Rows[0]["Bluetooth"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                mBrand = Convert.ToString(DB.DataTable.Rows[0]["Brand"]);

                return true;
            }
          else
            {
                return false;
            }
        }
    }


}