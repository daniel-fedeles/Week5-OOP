using CarStore.Interfaces;
using System;

namespace CarStore.Models
{
    public class Client : IPerson
    {
        public Client(string name)
        {
            Id = Guid.NewGuid();
            Name = name;

        }
        public Guid Id { get; }
        public string Name { get; }

        public void Print()
        {
            Console.WriteLine($"Client name: {Name}");
        }
    }
}