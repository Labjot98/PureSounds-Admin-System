using System;
using System.Collections.Generic;

namespace ClassLibrary
{

// constructor for the class
    public class clsStaffCollection
    {
        // constructor for the class
        public clsStaffCollection()
        {
            // variable for the index
            Int32 Index = 0;
            // variable to store the record count
            Int32 RecordCount = 0;
            // object for the data connect
            clsDataConnection DB= new clsDataConnection();
            // execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            // get the count of records
            RecordCount = DB.Count;
            // while there are records to process
            while (Index <  RecordCount)
            {
                // create a blank Staff
                clsStaff AStaff = new clsStaff();
                // read in the fields for the current record
                AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AStaff.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AStaff.DateJoined = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateJoined"]);
                AStaff.DateLeft = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateLeft"]);
                AStaff.Rank = Convert.ToString(DB.DataTable.Rows[Index]["Rank"]);
                AStaff.NINumber = Convert.ToString(DB.DataTable.Rows[Index]["NINumber"]);
                AStaff.IsFemale = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsFemale"]);
                // add the record to the private data member
                mStaffList.Add(AStaff);
                // point at the next record
                Index++;
            }
        }

        // create the items of test data
        clsStaff TestItem = new clsStaff();
        // set its properties

        
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