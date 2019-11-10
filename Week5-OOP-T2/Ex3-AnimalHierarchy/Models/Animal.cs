using Ex3_AnimalHierarchy.Enums;
using Ex3_AnimalHierarchy.Interfaces;
using System;

namespace Ex3_AnimalHierarchy.Models
{
    public abstract class Animal : ISound
    {
        protected internal Animal(int age, string name, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public int Age { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }


        public abstract void Sound();

        public void Print()
        {
            Console.WriteLine($"Name: {Name}, age: {Age}, Gender: {Gender}");
        }
    }
}