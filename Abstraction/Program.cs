using Abstraction.Classes;

Mechanic mechanic = new Mechanic();
Driver driver = new Driver();

Car car = new Car();
mechanic.Service(car);
driver.Drive(car);

Console.WriteLine();

Truck truck = new Truck();
mechanic.Service(truck);
driver.Drive(truck);

