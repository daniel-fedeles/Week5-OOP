using Ex3_AnimalHierarchy.Enums;

namespace Ex3_AnimalHierarchy.Models
{
    public class Kitten : Cat
    {
        public Kitten(int age, string name) : base(age, name, Gender.Male)
        {
        }
    }
}
