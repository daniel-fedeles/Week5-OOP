using CarStore.Interfaces;
using System;

namespace CarStore.Models
{
    public class Store : IStore
    {
        public Store(string name, string location, IPerson person, IOrder order)
        {
            Id = Guid.NewGuid();
            Name = name;
            Location = location;
            Person = person;
            Order = order;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public IPerson Person { get; }
        public IOrder Order { get; }

        public void Print()
        {
            Person.Print();
            Console.WriteLine($"Store name: {Name}");
            Console.WriteLine($"Store location: {Location}");
            Order.Print();
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}