using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        // private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();

        // public property for the staff list
        public List<clsStaff> StaffList
        {
            get
            {
                // return the private data
                return mStaffList;
            }
            set
            {
                // set the private data
                mStaffList = value;
            }
        }

        public int Count
        {
            get
            {
                // return the count of the list
                return mStaffList.Count;
            }
            set
            {
                // we shall worry about this later
            }
        }
        public clsStaff ThisStaff { get; set; }
    }
}