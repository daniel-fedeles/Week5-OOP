using CarStore.Models;
using System;

namespace CarStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var storeManager = new StoreManager();

            var alex = new Client("Alex");
            var Focus = new Car("Focus", 15000);
            var ford = new Producer("Ford", Focus);
            var order = new Order(alex, ford, DateTime.Parse("12/10/2019"));
            var fordStore = new Store("FordStore", "Bucuresti", alex, order);

            fordStore.Print();
            storeManager.AddStore(fordStore);

            var octavia = new Car("Octavia", 14000);
            var skoda = new Producer("Skoda", octavia);
            var skodaOrder = new Order(alex, skoda, DateTime.Parse("12/03/2019"));
            var skodaStore = new Store("SkodaStore", "Bucuresti", alex, skodaOrder);
            skodaStore.Print();

            storeManager.AddStore(skodaStore);


            storeManager.CancelOrder(fordStore);

            storeManager.ReceivedModel(skodaStore);





        }
    }
}
