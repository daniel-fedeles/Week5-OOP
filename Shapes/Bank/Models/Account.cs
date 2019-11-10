using System.Collections.Generic;

namespace Bank.Models
{
    public class Account
    {
        public List<Customer> Customers { get; set; }
        public string InterestRate { get; set; }
    }
}