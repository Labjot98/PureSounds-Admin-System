using System;
using System.Management.Instrumentation;
using ClassLibrary;

namespace ClassLibrary
{
    public class clsSupplier
    {
        //private data member for SupplierId property
        private Int32 mSupplierId;
        private DateTime mDateAdded;
        private String mSupplierName;
        private String mSupplierLocation;
        private String mSupplierQuality;
        private Decimal mSupplierCost;
        private Boolean mSupplierStockAvailable;


        public bool Active { get; set; }
        public DateTime DateAdded 
        {
            get
            {
                //sends data out of the property
                return mDateAdded;
            }
            set
            {
                //allows data in the property
                mDateAdded = value;
            }
           }

        //SupplierId public Property
        public Int32 SupplierId
        {
            get
            {
                //this line of code sends data out of the property
                return mSupplierId;
            }
            set
            {
                //this line of code allows data into the property
                mSupplierId = value;    
            }
        }

        public string SupplierName 
        {
            get
            {
                //sends data out the property
                return mSupplierName;
            }
            set
            {
                //allows data into the property
                mSupplierName = value;
            }
        }
        public string SupplierLocation 
        {
            get
            {
                //allows data out the property
                return mSupplierLocation;
            }
            set
            {
                //allows data into the property
                mSupplierLocation = value;
            }
            }
        public string SupplierQuality 
        {
            get
            {
                return mSupplierQuality;
            }
            set
            {
                mSupplierQuality = value;
            }

        }
        public decimal SupplierCost 
        {
            get
            {
                return mSupplierCost;
            }
            set
            {
                mSupplierCost = value;

            }
        }
        public bool SupplierStockAvailable 
        {
            get
            {
                return mSupplierStockAvailable;
            }
            set
            {
                mSupplierStockAvailable = value;
            }
        }

        public bool Find(int SupplierId)
        {
            //set the private datas value to the test data value
            mSupplierId = 21;
            mDateAdded = Convert.ToDateTime("23/06/22");
            mSupplierName = "SupplyRUS";
            mSupplierLocation = "Newcastle";
            mSupplierQuality = "Great";
            mSupplierCost = Convert.ToDecimal("1000");
            mSupplierStockAvailable = Convert.ToBoolean("true");
            //always return true
            return true;
        }
    }
}