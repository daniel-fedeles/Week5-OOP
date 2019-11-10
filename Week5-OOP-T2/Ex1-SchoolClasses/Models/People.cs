using Ex1_SchoolClasses.Interfaces;
using System;

namespace Ex1_SchoolClasses.Models
{
    public abstract class People : IComments
    {
        public string Name { get; set; }
        public string Comment { get; set; }

        protected People(string name)
        {
            this.Name = name;
        }

        public void Print(string type)
        {
            Console.WriteLine($"{type} name: {Name}, Comments: {Comment}");
        }

        public abstract string Comments();
    }
}