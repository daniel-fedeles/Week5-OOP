using CarStore.Interfaces;
using System;

namespace CarStore.Models
{
    public class Car : IVehicle
    {
        public Car(string name, double cost)
        {
            Id = Guid.NewGuid();
            Name = name;
            Cost = cost;
        }
        public Guid Id { get; }
        public string Name { get; }
        public double Cost { get; }

        public void Print()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Cost: {Cost}");
        }
    }
}