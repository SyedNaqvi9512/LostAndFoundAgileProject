using System;

namespace ClassLibrary
{
    public class clsFoundItems
    {
        Int32 mId;
        public int Id { 
            get {
                return mId;
            } 
            set {
                mId = value;
            } }

        string mTitle;
        public string Title { 
            get {
                return mTitle;
            } 
            set {
                mTitle = value;
            } }

        string mLocation;
        public string Location { 
            get {
                return mLocation;
            } 
            set {
                mLocation = value;
            } }

        DateTime mDateFound;
        public DateTime DateFound { 
            get {
                return mDateFound;
            } 
            set {
                mDateFound = value;
            } }

        string mIsReturned; 
        public string IsReturned { 
            get {
                return mIsReturned;
            } 
            set { 
                 mIsReturned = value; 
            } }

        public bool Find(int Id)
        {
            try
            {
                clsDataConnection DB = new clsDataConnection();
                DB.AddParameter("@Id", Id);
                DB.Execute("sproc_FoundItems_FilterById");

                if (DB.Count == 1)
                {
                    mId = Convert.ToInt32(DB.DataTable.Rows[0]["Id"]);
                    mTitle = Convert.ToString(DB.DataTable.Rows[0]["ItemName"]);
                    mLocation = Convert.ToString(DB.DataTable.Rows[0]["LocationFound"]);
                    mDateFound = Convert.ToDateTime(DB.DataTable.Rows[0]["DateFound"]);
                    IsReturned = Convert.ToString(DB.DataTable.Rows[0]["IsReturned"]);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Log the exception (optional)
                throw new ApplicationException("An error occurred in the Find method: " + ex.Message);
            }
        }



    }
}