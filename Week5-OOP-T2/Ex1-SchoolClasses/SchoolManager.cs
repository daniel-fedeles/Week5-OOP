using Ex1_SchoolClasses.Models;
using System;
using System.Collections.Generic;

namespace Ex1_SchoolClasses
{
    public class SchoolManager
    {
        public SchoolManager()
        {
            Classes = new List<Class>();
        }

        private List<Class> Classes { get; }

        public void AddClass(Class cClass)
        {
            if (cClass == null) throw new ArgumentNullException(nameof(cClass));

            Classes.Add(cClass);

        }

        public void PrintClasses()
        {
            foreach (var cClass in Classes)
            {
                cClass.PrintStudentsAndTeachers();
            }
        }


    }
}