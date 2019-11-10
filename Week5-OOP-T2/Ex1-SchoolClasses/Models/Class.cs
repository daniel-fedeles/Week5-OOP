using Ex1_SchoolClasses.Interfaces;
using System;
using System.Collections.Generic;

namespace Ex1_SchoolClasses.Models
{
    public sealed class Class : IComments
    {
        public Class(Guid id)
        {
            Id = id;
            Teachers = new List<Teacher>();
            Students = new List<Student>();
        }

        public Guid Id { get; }

        private List<Teacher> Teachers { get; }
        private List<Student> Students { get; }


        public string Comments()
        {
            throw new NotImplementedException();
        }

        public void AddStudents(Student student)
        {
            Students.Add(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
        }

        public void PrintStudentsAndTeachers()
        {
            Console.WriteLine($"For class with id:{Id}");
            foreach (var teacher in Teachers)
            {
                teacher.Print();
                foreach (var student in Students)
                {

                    student.Print();
                }
            }
        }
    }
}