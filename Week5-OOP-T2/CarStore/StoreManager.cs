using CarStore.Models;
using System;
using System.Collections.Generic;

namespace CarStore
{
    public class StoreManager
    {
        public StoreManager()
        {
            Stores = new List<Store>();
        }

        public List<Store> Stores { get; }

        public void AddStore(Store store)
        {
            Stores.Add(store);
        }

        public void CancelOrder(Store store)
        {
            Console.WriteLine($"{store.Person.Name} canceled order");
            store.Order.Print();
            Stores.Remove(store);
            Console.WriteLine();
            Console.WriteLine();
        }

        public void ReceivedModel(Store store)
        {
            Console.WriteLine($"After {store.Order.GetDeliveryTime()} weeks, {store.Person.Name} received:");
            store.Order.Car.Print();
        }
    }
}