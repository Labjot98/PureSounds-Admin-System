using System;
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
            // set the private data member to the test data value
            mStaffID = 21;
            mName = "Orson Welles";
            mDateJoined = Convert.ToDateTime("08/05/2025");
            mDateLeft = Convert.ToDateTime("08/05/2026");
            mRank = "Salesperson";
            mNINumber = "NH123456B";
            mIsFemale = true;
            // return always true
            return true;
        }
    }
}