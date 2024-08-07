namespace Inheritance.Classes
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name => name;
        public int Age => age;

        public string Eat()
        {
            return $"{Name} is eating.";
        }

        public virtual string Walk()
        {
            return $"{Name} is walking.";
        }
    }
}
