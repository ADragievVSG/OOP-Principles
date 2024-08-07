using Inheritance.Classes;

Programmer programmer = new Programmer("Angel", 23, "VSG Bulgaria");
Dancer dancer = new Dancer("Ivan", 28, "VSG Dancing Stars");

Console.WriteLine("Day as a programmer:");
Thread.Sleep(1000);
Console.WriteLine(programmer.Eat());
Thread.Sleep(1000);
Console.WriteLine(programmer.Code());
Thread.Sleep(1000);
Console.WriteLine(programmer.Walk());
Thread.Sleep(2000);

Console.WriteLine();

Console.WriteLine("Day as a dancer:");
Thread.Sleep(1000);
Console.WriteLine(dancer.Eat());
Thread.Sleep(1000);
Console.WriteLine(dancer.Dance());
Thread.Sleep(1000);
Console.WriteLine(dancer.Walk());

