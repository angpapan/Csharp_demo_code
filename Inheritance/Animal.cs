namespace Inheritance;

internal abstract class Animal
{
    private int _age = 0;
    public int Age => _age;
    public int Lifespan {get; }
    public Family Family { get; }
    protected Animal(Family family, int lifespan) 
    { 
        Family = family; Lifespan = lifespan;
    }
    public void IncreaseAge() => _age++;
    public abstract void MakeSound();
    public bool IsAlive() => Age <= Lifespan;
}
