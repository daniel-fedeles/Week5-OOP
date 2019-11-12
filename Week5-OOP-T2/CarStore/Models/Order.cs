using CarStore.Interfaces;
using System;

namespace CarStore.Models
{
    public class Order : IOrder
    {
        public Order(IPerson client, IProducer vehicle, DateTime deliveryTime)
        {
            Id = Guid.NewGuid();
            Car = vehicle;
            DeliveryTime = deliveryTime;
            Client = client;
            Cost = vehicle.Car.Cost;
        }
        public Guid Id { get; }
        public IPerson Client { get; }
        public IProducer Car { get; }
        public DateTime DeliveryTime { get; }
        public double Cost { get; }
        public double TotalCost()
        {
            return Cost;
        }
        public int GetDeliveryTime()
        {
            TimeSpan ts = DeliveryTime.Subtract(DateTime.Now);
            int dif = ts.Days / 7;
            return dif;
        }
        public void Print()
        {
            Car.Print();
            Console.WriteLine($"Total cost is: {TotalCost()} and the delivery time is {GetDeliveryTime()} weeks");
        }
    }
}