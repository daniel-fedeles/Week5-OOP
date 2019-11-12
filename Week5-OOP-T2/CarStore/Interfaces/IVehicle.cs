using System;

namespace CarStore.Interfaces
{
    public interface IVehicle
    {
        Guid Id { get; }
        string Name { get; }
        double Cost { get; }
        void Print();
    }
}