namespace Inheritance;

internal class Cat : Animal
{
    public string Name { get; }
    public Cat(string name) : base(Family.Felidae, 18)
    {
        Name = name;
    }
    public override void MakeSound() => Console.WriteLine("Meow meow!");
}

