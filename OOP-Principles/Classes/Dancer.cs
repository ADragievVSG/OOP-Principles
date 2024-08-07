namespace Inheritance.Classes
{
    public class Dancer : Person
    {
        private string groupName;

        public Dancer(string name, int age, string groupName) : base(name, age)
        {
            this.groupName = groupName;
        }

        public string GroupName => groupName;

        public string Dance()
        {
            return $"{base.Name} is dancing.";
        }

        public override string Walk()
        {
            return $"{base.Name} is moon walking.";
        }
    }
}
