using Abstraction.Contracts;

namespace Abstraction.Classes
{
    public class Driver
    {
        public void Drive(IDriveable drivable)
        {
            var drivingComponents = drivable.GetDrivingComponents();
            Console.WriteLine($"Drive will drive car using: {string.Join(", ", drivingComponents)}");
        }
    }
}
