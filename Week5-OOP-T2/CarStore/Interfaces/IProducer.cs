using System;

namespace CarStore.Interfaces
{
    public interface IProducer
    {
        Guid Id { get; }
        string Name { get; }
        IVehicle Car { get; }
        void Print();
    }
}