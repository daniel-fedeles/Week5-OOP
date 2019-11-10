using System;

namespace Ex1_SchoolClasses.Models
{
    public sealed class Student : People
    {
        public Student(string name, Class classNr) : base(name)
        {
            this.ClassNr = classNr.Id;
        }

        public Guid ClassNr { get; }

        public void Print()
        {
            Console.WriteLine("Students");
            base.Print("Student");
            Console.WriteLine($" Class number {ClassNr.ToString()}");
            Console.WriteLine("----------------");
        }

        public override string Comments()
        {
            throw new NotImplementedException();
        }
    }
}