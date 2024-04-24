namespace Inheritance;

internal class Dog : Animal
{
    public string Name { get; }
    public Dog(string name) : base(Family.Canidae, 13)
    {
        Name = name;
    }
    public override void MakeSound() => Console.WriteLine("Woof woof!");
}
