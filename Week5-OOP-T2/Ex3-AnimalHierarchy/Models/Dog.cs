using Ex3_AnimalHierarchy.Enums;
using System;

namespace Ex3_AnimalHierarchy.Models
{
    public class Dog : Animal
    {
        public Dog(int age, string name, Gender gender) : base(age, name, gender)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Ham Ham!");
        }
    }
}