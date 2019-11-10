using Ex1_SchoolClasses.Models;
using System;

namespace Ex1_SchoolClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            //clasa
            var cclass = new Class(Guid.NewGuid());

            //profesori
            var gigiTeacher = new Teacher("Gigi");
            var kentTeacher = new Teacher("Kent");
            var hagiTeacher = new Teacher("Hagy");

            //discipline
            var rom = new Discipline("Rom", 2, 4);
            var math = new Discipline("Math", 1, 5);
            var fiz = new Discipline("Fiz", 3, 19);

            //profesori cu discipline
            gigiTeacher.AddDiscipline(rom);
            kentTeacher.AddDiscipline(math);
            hagiTeacher.AddDiscipline(fiz);

            //studeni
            var ionescuStudent = new Student("Ionescu", cclass);
            var popescuStudent = new Student("Popescu", cclass);
            var giorgescuStudent = new Student("Giorgescu", cclass);
            var lupescuStudent = new Student("Lupescu", cclass);

            //studenti in clasa
            cclass.AddStudents(ionescuStudent);
            cclass.AddStudents(popescuStudent);
            cclass.AddStudents(giorgescuStudent);
            cclass.AddStudents(lupescuStudent);

            //profesori la clasa
            cclass.AddTeacher(gigiTeacher);
            cclass.AddTeacher(kentTeacher);
            cclass.AddTeacher(hagiTeacher);


            var schoolManager = new SchoolManager();

            schoolManager.AddClass(cclass);

            schoolManager.PrintClasses();
        }

    }
}
