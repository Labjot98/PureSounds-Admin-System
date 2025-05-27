using System;

namespace ClassLibrary
{
    public class clsStockUser
    {
        //PRIVATE DATA MEMBERS

        private Int32 mUserID;
        private String mUserName;
        private String mPassword;
        private String mDepartment;







        public int UserID
        {
            get
            {
                return mUserID;
            }
            set
            {
                mUserID = value;
            }
        }

        public string UserName
        {
            get
            {
                return mUserName;
            }
            set
            {
                mUserName = value;
            }
        }

        public string Password
        {
            get
            {
                return mPassword;
            }
            set
            {
                mPassword = value;
            }
        }

        public string Department
        {
            get
            {
                return mDepartment;
            }
            set
            {
                mDepartment = value;
            }
        }

        public bool FindUser(string userName, string password)
        {
            //create database connection
            clsDataConnection DB = new clsDataConnection();
            //add parameters for for username and pw to search for
            DB.AddParameter("@UserName", userName);
            DB.AddParameter("@Password", password);

            //execute sored procedure
            DB.Execute("sproc_tblUsers_FindUserNamePW");
            //if one record is found (should either be one or none)
            if (DB.Count == 1)
            {
                //copy data from db onto private data members
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);

                //return true to confirm everything worked ok
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}