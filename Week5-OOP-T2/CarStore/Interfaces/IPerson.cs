using System;

namespace CarStore.Interfaces
{
    public interface IPerson
    {
        Guid Id { get; }
        string Name { get; }
        void Print();
    }
}