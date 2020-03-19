using System;
using System.Collections.Generic;
using System.Text;

namespace eventhub_to_cosmos
{

    public class Customer
    {
        public string CustomerID { get; set; }
        public string NameStyle { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public object Suffix { get; set; }
        public string CompanyName { get; set; }
        public string SalesPerson { get; set; }
        public string EmailAddress { get; set; }
        public string Phone { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public string rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }

}
