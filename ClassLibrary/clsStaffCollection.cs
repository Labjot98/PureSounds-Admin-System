using System;
using System.Collections.Generic;

namespace ClassLibrary
{

    // constructor for the class
    public class clsStaffCollection
    {
        // private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        // private member data for thisStaff
        clsStaff mThisStaff = new clsStaff();


        // constructor for the class
        public clsStaffCollection()
        {
            // object for the data connection
            clsDataConnection DB = new clsDataConnection();
            // execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            // populate the array list with the table data
            PopulateArray(DB);
        }

        // create the items of test data
        clsStaff TestItem = new clsStaff();
        // set its properties



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
        public clsStaff ThisStaff
        {
            get
            {
                // return the private data
                return mThisStaff;
            }
            set
            {
                mThisStaff = value;

            }
        }

        public int Add()
        {
            // adds a record to the database based on the values of mThisStaff
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            DB.AddParameter("@Name", mThisStaff.Name);
            DB.AddParameter("@DateJoined", mThisStaff.DateJoined);
            DB.AddParameter("@DateLeft", mThisStaff.DateLeft);
            DB.AddParameter("@Rank", mThisStaff.Rank);
            DB.AddParameter("@NINumber", mThisStaff.NINumber);
            DB.AddParameter("@IsFemale", mThisStaff.IsFemale);

            // execute the query return the primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            // update an existing record based on the values of ThisStaff
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.AddParameter("@Name", mThisStaff.Name);
            DB.AddParameter("@DateJoined", mThisStaff.DateJoined);
            DB.AddParameter("@DateLeft", mThisStaff.DateLeft);
            DB.AddParameter("@Rank", mThisStaff.Rank);
            DB.AddParameter("@NINumber", mThisStaff.NINumber);
            DB.AddParameter("@IsFemale", mThisStaff.IsFemale);
            // execute the stored procedure
            DB.Execute("sproc_tblStaff_Update");
        }

        public void Delete()
        {
            // deletes the record pointed to by ThisAddress
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameter for the stored procedure
            DB.AddParameter("@StaffId", mThisStaff.StaffID);
            // execute the stored procedure
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByName(string Name)
        {
            // filters the records based on full or partial Name
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // send the Name parameter to the database
            DB.AddParameter("@Name", Name);
            // execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByName");
            // populate the array list with the table data
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            // populates the array list based on the data table in the parameter DB
            // variable for the index
            Int32 Index = 0;
            // variable to store the record count
            Int32 RecordCount;
            // get the count of records
            RecordCount = DB.Count;
            // clear the private array list
            mStaffList = new List<clsStaff>();
            // while there are records to process
            while (Index < RecordCount)
            {
                // create a blank Staff object
                clsStaff AStaff = new clsStaff();
                // read in the fields from the current record
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
    }
}