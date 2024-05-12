namespace Delegates;

internal class Player
{
    public string Name { get; init; }
    public int HeightInCm { get; init; }
    public Team Team { get; set; }
    public Player(string name, int heightInCm, Team team)
    {
        Name = name;
        HeightInCm = heightInCm;
        Team = team;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Height: {HeightInCm}";
    }
}
