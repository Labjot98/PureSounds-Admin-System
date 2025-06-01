using System;
using System.CodeDom;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;

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


        public bool FindUser(string UserName, string Password)
        {

            // create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // add the parameters of the user username and password to search for
            DB.AddParameter("@UserName", UserName);
            // execute the stored procedure that pulls in an entire record just from the username (we now test the password here in the class method)
            DB.Execute("sproc_tblUsersSaltedandHashed_FindRecordFromUserName");

            // Authenticate the password present by user ...
            // Get the hash and salt from the SQL table
            string retrievedPasswordHash = Convert.ToString(DB.DataTable.Rows[0]["PasswordHash"]);
            string retrievedSalt = Convert.ToString(DB.DataTable.Rows[0]["Salt"]);

            // set a flag for whether we the passwords match
            bool authenticated = false;

            // create the hash of the presented_password+salt (with salt gotten from table for this user)
            SHA1 sha1Hash = SHA1.Create();
            byte[] sourceBytes = Encoding.UTF8.GetBytes(string.Concat(Password, retrievedSalt));
            byte[] hashBytes = sha1Hash.ComputeHash(sourceBytes);
            string PasswordHash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);

            // compare the hash of the presented password (plus salt from table) with hash stored in the table
            if (PasswordHash == retrievedPasswordHash)
                {
                authenticated = true;
                }

            if ((DB.Count == 1) && (authenticated == true))
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