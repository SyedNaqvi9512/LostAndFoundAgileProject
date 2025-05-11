using System;

namespace ClassLibrary
{
    public class clsLostItems
    {
        public clsLostItems()
        {

        }

        private Int32 mId;
        public int Id {
            get {
                return mId;
            }
            set {
                mId = value;
            } 
        }
        private DateTime mDate;
        public DateTime DateLost {
            get {
                return mDate;   
            }
            set {
                mDate = value;
            }
        }
        private string mTitle;
        public string Title {
            get {
              return mTitle;
            }
            set { 
            mTitle = value;
            }
        }
        private string mDescription;
        public string Description {
            get {
                return mDescription;
            }
            set { 
            mDescription = value;
            }
        }

        private string mLocation;
        public string Location {
            get {
                return mLocation;
            }
            set{
                mLocation = value;
            }
        }
        private string mIsClaimed;
        public string IsClaimed { get {
                return mIsClaimed;
                    } set {
                mIsClaimed = value;
                    } }

        public bool Find(int Id)
        {
            try
            {
                clsDataConnection DB = new clsDataConnection();
                DB.AddParameter("@Id", Id);
                DB.Execute("sproc_LostItems_FilterById");

                if (DB.Count == 1)
                {
                    mId = Convert.ToInt32(DB.DataTable.Rows[0]["Id"]);
                    mTitle = Convert.ToString(DB.DataTable.Rows[0]["Title"]);
                    mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                    mLocation = Convert.ToString(DB.DataTable.Rows[0]["Location"]);
                    mDate = Convert.ToDateTime(DB.DataTable.Rows[0]["DateLost"]);
                    mIsClaimed = Convert.ToString(DB.DataTable.Rows[0]["IsClaimed"]);
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