using EntityFrameworkCore.Data;
using Microsoft.EntityFrameworkCore;

// First we need an instance of the context
using var context = new FootballLeageDbContext();

// Select all teams
//getAllTeams();

// Selecting a single record
//var teamOne = await context.Coaches.FirstAsync();
//var teamOne = await context.Coaches.FirstOrDefaultAsync();

// Selecting a single record - First one un the list that meets a condition
//var teamTwo = await context.Teams.FirstAsync(team => team.TeamId == 1);
//var teamTwo = await context.Teams.FirstOrDefaultAsync(team => team.TeamId == 1);

//var teamThree = await context.Teams.SingleAsync();
//var teamThree = await context.Teams.SingleAsync(team => team.TeamId == 2);
//var teamFour = await context.Teams.SingleOrDefaultAsync(team => team.TeamId == 2);

// Select based on Id

//var teamBasedOnId = await context.Teams.FindAsync(3);
//if(teamBasedOnId != null)
//{
//    Console.WriteLine(teamBasedOnId.Name);
//}



void getAllTeams()
{
    // Select * FROM Teams
    var teams = context.Teams.ToList();

    foreach (var t in teams)
    {
        Console.WriteLine(t.Name);
    }
}


