using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public int CustomerId { get; set; }
        public string CustomerFullname { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public bool BonusEligibility { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}