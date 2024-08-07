using Encapsulation.Classes;

Car tesla = new Car("TESLA", 150);

Console.WriteLine(tesla.GetCarInformation());
try
{
    tesla.Drive(10);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine(tesla.GetCarInformation());
tesla.Stop();
Console.WriteLine(tesla.GetCarInformation());

