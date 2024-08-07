using Abstraction.Contracts;

namespace Abstraction.Classes
{
    public class Truck : IDriveable, IServicable
    {
        public List<string> GetDrivingComponents()
        {
            return ["Truck Brakes", "Truck Gearbox", "Truck Steering wheel", "Truck Coupler", "Truck Accelerator"];
        }

        public List<string> GetServiceCheckList()
        {
            return ["Truck Oil", "Truck Air Filter", "Truck Spark plugs", "Truck Coolants"];
        }
    }
}
