using System;

namespace CarStore.Interfaces
{
    public interface IOrder
    {
        Guid Id { get; }
        IPerson Client { get; }
        IProducer Car { get; }
        DateTime DeliveryTime { get; }
        double Cost { get; }
        double TotalCost();
        int GetDeliveryTime();
        void Print();
    }
}