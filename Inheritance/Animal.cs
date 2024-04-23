namespace Inheritance;

internal abstract class Animal
{
    private int _age = 0;
    public int Age => _age;
    public Family Family { get; }
    protected Animal(Family family) { Family = family; }
    public void IncreaseAge() => _age++;
    public abstract void MakeSound();
}