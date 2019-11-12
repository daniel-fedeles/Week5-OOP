using System;

namespace CarStore.Interfaces
{
    public interface IStore
    {
        Guid Id { get; }
        string Name { get; }
        string Location { get; }
        IPerson Person { get; }
        IOrder Order { get; }
        void Print();

    }
}
