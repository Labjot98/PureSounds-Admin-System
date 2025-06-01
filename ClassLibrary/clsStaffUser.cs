using System;
using System.CodeDom;
using System.Security.AccessControl;

namespace ClassLibrary
{
    public class clsStaffUser
    {
        // private data member for the user id property
        private Int32 mUserID;
        // private data member for the user name property
        private string mUserName;
        // private data member for the password hash
        private string mPasswordHash;
        // private data member for the salt
        private string mSalt;
        // private data mamber for the department property
        private string mDepartment;

        public int UserID
        {
            get
            {
                // return the private data
                return mUserID;
            }
            set
            {
                // set the private data
                mUserID = value;
            }
        }

        public string UserName
        {
            get
            {
                // return the private data
                return mUserName;
            }
            set
            {
                // set the private data
                mUserName = value;
            }
        }
        public string PasswordHash
        {
            get
            {
                // return the private data
                return mPasswordHash;
            }
            set
            {
                // set the private data
                mPasswordHash = value;
            }

        }
        public string Salt
        {
            get
            {
                // return the private data
                return mSalt;
            }
            set
            {
                // set the private data
                mSalt = value;
            }

        }



        public string Department
        {
            get
            {
                // return the private data
                return mDepartment;
            }
            set
            {
                // set the private data
                mDepartment = value;
            }
        }


        public bool FindUser(string UserName, string PasswordHash)
        {

            // create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // add the parameters of the user username and password to search for
            
            DB.AddParameter("@UserName", UserName);
            DB.AddParameter("@PasswordHash", PasswordHash);
            // execute the stored procedure
            DB.Execute("sproc_tblUsers_FindUserNamePWHash");
            // if one record is found (there should be either one or none)
            if (DB.Count == 1)
            {
                // copy the data from the database to the private data members
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPasswordHash = Convert.ToString(DB.DataTable.Rows[0]["PasswordHash"]);
                mSalt = Convert.ToString(DB.DataTable.Rows[0]["Salt"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                // return true to confirm that everything worked okay
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}