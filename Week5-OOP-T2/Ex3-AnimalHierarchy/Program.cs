using Ex3_AnimalHierarchy.Enums;
using Ex3_AnimalHierarchy.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex3_AnimalHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog(2, "gigi", Gender.Male));
            animals.Add(new Dog(6, "gigika", Gender.Female));

            animals.Add(new Cat(6, "alabala", Gender.Female));
            animals.Add(new Cat(6, "portocalu", Gender.Male));

            animals.Add(new Frog(6, "Broasca verde", Gender.Other));
            animals.Add(new Frog(6, "Broasca cu par", Gender.Male));

            animals.Add(new Kitten(6, "Broasca cu par"));
            animals.Add(new Kitten(6, "Broasca cu par"));

            animals.Add(new Tomcat(6, "Broasca cu par"));
            animals.Add(new Tomcat(6, "Broasca cu par"));

            Average(animals, typeof(Cat));
            Average(animals, typeof(Frog));
            Average(animals, typeof(Dog));
            Average(animals, typeof(Kitten));
            Average(animals, typeof(Tomcat));

            foreach (var animal in animals)
            {
                animal.Print();
            }
        }

        private static void Average(List<Animal> animals, Type type)
        {

            var average = animals.Where(p => p.GetType() == type).Average(x => x.Age);
            Console.WriteLine($"{type}, {average}");
        }
    }
}
