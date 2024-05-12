using Delegates;


List<Team> teams = DataFactory.CreateTeams();
List<Player> players = DataFactory.CreatePlayers(teams);
players.ForEach(p => p.Team.Players.Add(p));

PrintPlayers(p => p.HeightInCm > 205);
Console.WriteLine();
PrintPlayersByTeamCriterion(t => t.Name == "Olympiakos");

void PrintPlayers(PlayerDelegate criterion)
{
    foreach (Player player in players)
        if (criterion(player)) Console.WriteLine(player);
}

void PrintPlayersByTeamCriterion(Predicate<Team> criterion)
{
    foreach(Player player in players)
        if(criterion(player.Team)) Console.WriteLine(player);
}

delegate bool PlayerDelegate(Player player);
delegate bool TeamDelegate(Team team); // == Predicate<Team>


  