using System;

namespace ClassLibrary
{
    public class clsLostItemsUsers
    {
        private Int32 mUserID;
        private string mDepartment;
        private string mPassword;
        private string mUserName;


        public int UserID { get { 
                return mUserID; 
            

            } set { 
                mUserID = value;

            } }
        public string Department
        {
            get { return mDepartment; }
            set
            {
                mDepartment = value;
            }
        }
        public string Password {
            get { return mPassword; }
            set { 
                mPassword = value;
            }
        }
        public string UserName {
            get { return mUserName; }
            set { 
                mUserName = value;
            }
        }

        
            public bool FindUser(string UserName, string Password)
        {
            // create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            // add the parameters for the user username and password to search for
            DB.AddParameter("@UserName", UserName);
            DB.AddParameter("@Password", Password);

            // execute the stored procedure for the new table
            DB.Execute("sproc_tblUser_FindUserNamePW");

            // if one record is found (there should be either one or none)
            if (DB.Count == 1)
            {
                // copy the data from the database to the private data members
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);

                // return true to confirm everything worked ok
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
