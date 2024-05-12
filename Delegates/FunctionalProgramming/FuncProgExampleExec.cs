namespace Delegates.FunctionalProgramming;

delegate bool TeamDelegate(Team team); // == Predicate<Team>

internal class FuncProgExampleExec
{
    public static void Execute()
    {
        List<Team> teams = DataFactory.CreateTeams();
        List<Player> players = DataFactory.CreatePlayers(teams);
        players.ForEach(p => p.Team.Players.Add(p));

        Console.WriteLine($"{teams[1].Name} players over 205cm");
        teams[1].PrintPlayers(p => p.HeightInCm > 205);
        Console.WriteLine();
        Console.WriteLine($"{teams[1].Name} players under 203cm");
        teams[1].PrintPlayers(p => p.HeightInCm < 203);
        Console.WriteLine();
        Console.WriteLine($"Players playing for Olympiakos");
        PrintPlayersByTeamCriterion(t => t.Name == "Olympiakos");


        void PrintPlayersByTeamCriterion(TeamDelegate criterion)
        {
            foreach (Player player in players)
                if (criterion(player.Team)) Console.WriteLine(player);
        }
    }
}
