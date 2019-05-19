
namespace SimpleWeb.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return "My name is '" + Name + "' and I am " + Age + " years old.";
        }
    }
}