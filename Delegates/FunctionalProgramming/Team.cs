namespace Delegates.FunctionalProgramming;

internal class Team
{
    public string Name { get; init; }
    public List<Player> Players { get; set; } = new();
    public Team(string name) { Name = name; }
}
