using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public int StaffID { get; set; }
        public string Name { get; set; }
        public DateTime DateJoined { get; set; }
        public DateTime DateLeft { get; set; }
        public string Rank { get; set; }
        public string NINumber { get; set; }
        public bool IsFemale { get; set; }
    }
}