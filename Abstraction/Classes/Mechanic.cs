using Abstraction.Contracts;

namespace Abstraction.Classes
{
    public class Mechanic
    {
        public void Service(IServicable servicable)
        {
            var serviceCheckList = servicable.GetServiceCheckList();
            Console.WriteLine($"Mechanic will change: {string.Join(", ", serviceCheckList)}");
        }
    }
}
