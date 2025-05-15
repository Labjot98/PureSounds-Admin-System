using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //public property for the customer list
        public List<clsCustomer> CustomerList
        { 
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }
        public int Count { get; set; }
        public clsCustomer ThisCustomer { get; set; }
    }
}