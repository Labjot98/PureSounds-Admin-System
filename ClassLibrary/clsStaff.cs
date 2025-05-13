using System;
using System.Linq.Expressions;
using System.Management.Instrumentation;

namespace ClassLibrary
{
    public class clsStaff
    {
        // private data member for the StaffID property
        private Int32 mStaffID;

        // StaffID public property
        public int StaffID {
            get
            {
                // this line of code sends data out of the property
                return mStaffID;
            }
            set
            {
                // this line of code receives data into the property
                mStaffID = value;  
            }
        }

        // private data member for the Name property
        private String mName;
        // Name public property
        public string Name {
            get
            {
                // this line of code sends data out of the property
                return mName;
            }
            set
            {
                // this line of code receives data into the property
                mName = value;
            }
        }

        // private data member for the DateJoined property
        private DateTime mDateJoined;
        // DateJoined public property
        public DateTime DateJoined
        {
            get
            {
                // this line of code sends data out of the property
                return mDateJoined;
            }
            set
            {
                // this line of code receives data into the property
                mDateJoined = value;
            }
        }

        // private data member for the DateLeft property
        private DateTime mDateLeft;
        // DateLeft public property
        public DateTime DateLeft
        {
            get
            {
                // this line of code sends data out of the property
                return mDateLeft;
            }
            set
            {
                // this line of code receives data into the property
                mDateLeft = value;
            }
        }

        // private data member for the Rank property
        private String mRank;
        // Rank public property
        public string Rank
        {
            get
            {
                // this line of code sends data out of the property
                return mRank;
            }
            set
            {
                // this line of code receives data into the property
                mRank = value;
            }
        }


        // private data member for the NINumber property
        private String mNINumber;
        // NINumber public property
        public string NINumber
        {
            get
            {
                // this line of code sends data out of the property
                return mNINumber;
            }
            set
            {
                // this line of code receives data into the property
                mNINumber = value; 
            }
        }

        // private data member for IsFemale property
        private bool mIsFemale;
        // IsFemale public property
        public bool IsFemale
        {
            get
            {
                // this line of code sends data out of the property
                return mIsFemale;
            }
            set
            {
                // this line of code receives data into the property
                mIsFemale = value;
            }
        }

        /******************FIND METHOD**********************************/
        public bool Find(int StaffID)
        {
            // create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // add the parameter for the staff id to search for
            DB.AddParameter("@StaffID", StaffID);
            // execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffID");
            // if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                // copy the data from the database to the private data members
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mDateJoined = Convert.ToDateTime(DB.DataTable.Rows[0]["DateJoined"]);
                mDateLeft = Convert.ToDateTime(DB.DataTable.Rows[0]["DateLeft"]);
                mRank = Convert.ToString(DB.DataTable.Rows[0]["Rank"]);
                mNINumber = Convert.ToString(DB.DataTable.Rows[0]["NINumber"]);
                mIsFemale = Convert.ToBoolean(DB.DataTable.Rows[0]["IsFemale"]);
                // return that everything worked OK
                return true;
            }
            // if no record was found
            else
            {

                // return false indicating there is a problem
                return false;
            }
        }

        public string Valid(string name, string dateJoined, string dateLeft, string rank, string nINumber)
        {
            // create a string variable to store the error
            String Error = "";
            // create a temporary variable to store the date values
            DateTime DateTemp;
            // if the Name is blank 
            if (name.Length == 0)
            {
                // record the error
                Error = Error + "The name may not be blank : ";
            }
            // if the name is greater than 50 characters
            if (name.Length > 50)
            {
                // record the error
                Error = Error + "The name may not be less than 51 character : ";
            }

            // create an instance of DateTime to compare with DateTemp
            // in the if statements
            DateTime DateComp = DateTime.Now.Date;

            try
            {
                // copy the DateJoined value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateJoined);
                
                if (DateTemp < DateComp)  // compare dateJoined with Date
                {
                    // record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                // check to see if the date is greater than today's date
                if (DateTemp > DateComp)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                // record the error
                Error = Error + "The date was not a valid date : ";
            }
            // return any error messages
            return Error;
        }
    }
}