using Ex3_AnimalHierarchy.Enums;
using System;

namespace Ex3_AnimalHierarchy.Models
{
    public class Frog : Animal
    {
        public Frog(int age, string name, Gender gender) : base(age, name, gender)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Oac Oac!");
        }
    }
}