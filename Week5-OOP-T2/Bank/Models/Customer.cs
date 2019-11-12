using Bank.Interfaces;
using System;

namespace Bank.Models
{
    public class Customer : ICustomer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}