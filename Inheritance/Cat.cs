namespace Inheritance;

internal class Cat : Animal
{
    public string Name { get; }
    public Cat(string name) : base(Family.Felidae)
    {
        Name = name;
    }
    public override void MakeSound() => Console.WriteLine("Meow meow!");
}

