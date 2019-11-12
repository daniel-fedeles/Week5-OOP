using System;

namespace Bank.Interfaces
{
    public interface ICustomer
    {
        Guid Id { get; set; }
        string Name { get; set; }
    }
}