using System;
using System.Collections.Generic;

namespace Ex1_SchoolClasses.Models
{
    public sealed class Teacher : People
    {
        public Teacher(string name) : base(name)
        {
            Disciplines = new List<Discipline>();
        }

        private List<Discipline> Disciplines { get; }

        public void AddDiscipline(Discipline discipline)
        {
            if (discipline == null) throw new ArgumentNullException(nameof(discipline));
            Disciplines.Add(discipline);
        }

        public void Print()
        {
            base.Print("Teacher");
            Console.WriteLine("Disciplines");
            foreach (var discipline in Disciplines)
            {
                discipline.Print();
            }
            Console.WriteLine("----------------");
        }

        public override string Comments()
        {
            throw new NotImplementedException();
        }
    }
}