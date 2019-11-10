using Ex3_AnimalHierarchy.Enums;

namespace Ex3_AnimalHierarchy.Models
{
    public class Tomcat : Cat
    {
        public Tomcat(int age, string name) : base(age, name, Gender.Female)
        {
        }
    }
}