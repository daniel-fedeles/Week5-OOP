using System;

namespace cursoop2
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director { Id = 1, Name = "KKK", BirthDay = new DateTime(1986, 5, 5), BaseSalary = 2653.2M };
            var developer = new Developer { Id = 1, Name = "sss", BirthDay = new DateTime(1926, 5, 5), BaseSalary = 253699M };

            Console.WriteLine($"{director.GetType()}, {director.Name}, {director.CalculateSalary()}, {director.CalculateAge()}");
            Console.WriteLine($"{developer.GetType()}, {developer.Name}, {developer.CalculateSalary()}, {developer.CalculateAge()}");
        }
    }
}
