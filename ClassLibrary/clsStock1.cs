using System;
using System.IO;

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

        public string Valid(string itemName, string brand, string datePosted, string price, string quantity)
        {
            String Error = "";

            //temp var to store date
            DateTime DateTemp;

            //temp var to store price
            Decimal PriceTemp;

            //temp var to store quantity
            int QuantityTemp;

            //if ItemName is blank
            if (itemName.Length == 0)
            {
                Error = Error + "the ItemName may not be empty : ";
            }
            //if item name is over 50 chars
            if (itemName.Length > 50)
            {
                Error = Error + "The ItemName may not be above 50 characters : ";
            }


            //if brand is blank
            if (brand.Length == 0)
            {
                Error = Error + "the Brand may not be empty : ";
            }
            
            if (brand.Length > 55)
            {
                Error = Error + " the Brand may not be over 55 characters : ";
            }

            //create instance of DateTime to compare with DateTemp
            DateTime DateComp = DateTime.Now.Date;

            try
            {
                //copy datePosted variable to DateTemp
                DateTemp = Convert.ToDateTime(datePosted);

                if(DateTemp < DateComp)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
                if (DateTemp > DateComp) 
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "the date was not in valid date format : ";
            }


            //trycatch for price
            try
            {
                PriceTemp = Convert.ToDecimal(price);

                if (PriceTemp < 5.00m)
                {
                    Error = Error + "the price cannot be less than 5.00 : ";
                }

                if(PriceTemp > 1000.00m)
                {
                    Error = Error + "the price cannot be greater than 1000.00 : ";
                }
              
            }
            catch
            {
                Error = Error + "the price was not in valid decimal format : ";
            }

            //trycatch for quantity
            try
            {
                QuantityTemp = Convert.ToInt32(quantity);

                if (QuantityTemp < 0)
                {
                    Error = Error + "the Quantity cannot be less than 0 : ";
                }

                if (QuantityTemp > 1000)
                {
                    Error = Error + "the Quantity cannot be less than 1000 : ";
                }

            }
            catch
            {
                Error = Error + "the quantity was not in valid decimal format : ";
            }




            return Error;
        }
    }


}