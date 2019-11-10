using Ex1_SchoolClasses.Interfaces;
using System;

namespace Ex1_SchoolClasses.Models
{
    public sealed class Discipline : IComments
    {
        public Discipline(string name, int nrOfLect, int nrOfEx)
        {
            this.NrOfLectures = nrOfLect;
            this.NrOfExercises = nrOfEx;
            this.Name = name;
        }

        public string Name { get; set; }
        public int NrOfLectures { get; set; }
        public int NrOfExercises { get; set; }

        public void Print()
        {
            Console.WriteLine($"For discipline {Name}, number of lectures {NrOfLectures}, number of exercises {NrOfExercises}");
        }

        public string Comments()
        {
            throw new NotImplementedException();
        }
    }
}