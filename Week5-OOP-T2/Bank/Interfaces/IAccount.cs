using System;

namespace Bank.Interfaces
{
    public interface IAccount
    {
        Guid id { get; set; }
        string AccountType { get; set; }
        ICustomer Customer { get; set; }

    }
}