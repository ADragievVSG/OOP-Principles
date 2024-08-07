using Abstraction.Contracts;

namespace Abstraction.Classes
{
    public class Car : IDriveable, IServicable
    {
        public List<string> GetDrivingComponents()
        {
            return ["Car Brakes", "Car Gearbox", "Car Steering wheel", "Car Coupler", "Car Accelerator"];
        }

        public List<string> GetServiceCheckList()
        {
            return ["Car Oil", "Car Air Filter", "Car Spark plugs", "Car Coolants"];
        }
    }
}
