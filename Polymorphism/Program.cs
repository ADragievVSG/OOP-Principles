using Polymorphism.Classes;

Animal animal = null!;

var cmd = Console.ReadLine();
if (cmd == "dog")
{
    animal = new Dog();
}
else if (cmd == "cat")
{
    animal = new Cat();
}
else if(cmd == "duck")
{
    animal = new Duck();
}

if(animal != null)
{
    animal.Speak();
}
else
{
    Console.WriteLine("Unknown animal!");
}