using EntityFrameworkCore.Data;

// First we need an instance of the context
var context = new FootballLeageDbContext();

// Select all teams

getAllTeams();

void getAllTeams()
{
    // Select * FROM Teams
    var teams = context.Teams.ToList();

    foreach (var team in teams)
    {
        Console.WriteLine(team.Name);
    }
}
