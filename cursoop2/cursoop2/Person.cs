using System;

namespace cursoop2
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public decimal BaseSalary { get; set; }

        public int CalculateAge()
        {
            return DateTime.Now.Year - BirthDay.Year;
        }

        public virtual decimal CalculateSalary()
        {
            return BaseSalary - 250;
        }
    }

    public class Developer : Employee
    {

    }

    public class Director : Employee
    {
        public override decimal CalculateSalary()
        {
            return BaseSalary * 0.90m;
        }
    }
}