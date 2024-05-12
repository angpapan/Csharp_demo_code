namespace Delegates.FunctionalProgramming;

internal class Team
{
    public string Name { get; init; }
    public List<Player> Players { get; set; } = new();
    public Team(string name) { Name = name; }
    public void PrintPlayers(Predicate<Player> criterion)
    {
        foreach(Player p in Players)
            if(criterion(p)) Console.WriteLine(p);
    }
    
}
