namespace SimpleWeb.Entities
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Race Race { get; set; }
        public override string ToString() => $"My name is '{Name}' and I am {Age} years old.";
    }
}
