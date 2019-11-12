using CarStore.Interfaces;
using System;

namespace CarStore.Models
{
    public class Producer : IProducer
    {
        public Producer(string name, IVehicle car)
        {
            Id = Guid.NewGuid();
            Name = name;
            Car = car;
        }
        public Guid Id { get; }
        public string Name { get; }

        public IVehicle Car { get; }

        public void Print()
        {
            Console.WriteLine($"Producer: {Name}");
            Car.Print();
        }
    }
}