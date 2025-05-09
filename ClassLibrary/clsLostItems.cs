using System;

namespace ClassLibrary
{
    public class clsLostItems
    {
        public clsLostItems()
        {
        }

        public int Id { get; set; }
        public DateTime DateLost { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public bool IsClaimed { get; set; }
    }
}