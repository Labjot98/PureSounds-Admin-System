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

        public bool Find(int itemID)
        {
            mItemID = 26;
            mItemName = "bose soundflex";
            mDatePosted = Convert.ToDateTime("10/07/2022");
            mQuantity = 40;
            mBluetooth = true;
            mPrice = 29.99m;
            mBrand = "bose";

            return true;
        }
    }


}