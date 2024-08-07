namespace Inheritance.Classes
{
    public class Programmer : Person
    {
        private string companyName;

        public Programmer(string name, int age, string companyName) : base(name, age)
        {
            this.companyName = companyName;
        }

        public string CompanyName => companyName;
        public string Code()
        {
            return $"{base.Name} is coding";
        }
    }
}
