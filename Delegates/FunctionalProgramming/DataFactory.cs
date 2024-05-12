namespace Delegates.FunctionalProgramming;

internal static class DataFactory
{
    public static List<Team> CreateTeams()
    {
        List<Team> teams = new();
        teams.Add(new Team("Olympiakos"));
        teams.Add(new Team("Panathinaikos"));
        return teams;
    }

    public static List<Player> CreatePlayers(List<Team> teams)
    {
        List<Player> players = new();

        players.Add(new Player("Player 00", 193, teams[0]));
        players.Add(new Player("Player 01", 211, teams[0]));
        players.Add(new Player("Player 02", 201, teams[0]));

        players.Add(new Player("Player 10", 189, teams[1]));
        players.Add(new Player("Player 11", 209, teams[1]));
        players.Add(new Player("Player 12", 202, teams[1]));

        return players;
    }
}
