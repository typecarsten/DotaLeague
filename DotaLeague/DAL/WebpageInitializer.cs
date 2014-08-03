using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotaLeague.Models;

namespace DotaLeague.DAL
{
    public class WebpageInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<WebpageContext>
    {
        protected override void Seed(WebpageContext context)
        {
            var users = new List<User>();
            var user1 = new User {FirstName = "Carsten", LastName = "Jacobsen", NickName = "LugteBOB<3", UserID = 1};
            var user2 = new User { FirstName = "John", LastName = "Hansen", NickName = "Gert", UserID = 2 };
            var user3 = new User { FirstName = "Michael", LastName = "Westergaard", NickName = "Postgame", UserID = 3 };
            var user4 = new User {FirstName = "Hans", LastName = "Hansen", NickName = "HanZen", UserID = 4};
            var user5 = new User {FirstName = "Kurt", LastName = "Jensen", NickName = "Jenzen", UserID = 5};
            var user6 = new User {FirstName = "Marco", LastName = "Heigren", NickName = "Zenzey", UserID = 6};
            var user7 = new User {FirstName = "Benjamin", LastName = "Frantzen", NickName = "zxio", UserID = 7};
            var user8 = new User {FirstName = "Sabrina", LastName = "Berg", NickName = "Futte", UserID = 8};
            var user9 = new User {FirstName = "Søren", LastName = "Westergaard", NickName = "Dørmand", UserID = 9};
            var user10 = new User {FirstName = "Bo", LastName = "Fjold", NickName = "Dotted", UserID = 10};
            var user11 = new User {FirstName = "Hans", LastName = "Jensen", NickName = "HamSelv", UserID = 11};

            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
            users.Add(user4);
            users.Add(user5);
            users.Add(user6);
            users.Add(user7);
            users.Add(user8);
            users.Add(user9);
            users.Add(user10);
            users.Add(user11);

            users.ForEach(s => context.User.Add(s));
            context.SaveChanges();

            var teams = new List<Team>();
            var team1 = new Team
            {
                TeamID = 1,
                TeamName = "BredebroLAN - Crew",
                TeamTag = "BLAN",
                RegistrationDateTime = new DateTime(2014, 4, 22),
                Approved = true,
                UserList = new List<User> { user1, user2, user3, user4, user5, user6}
            };
            var team2 = new Team
            {
                TeamID = 2,
                TeamName = "Team træls pis",
                TeamTag = "TTP",
                RegistrationDateTime = new DateTime(2013, 3, 30),
                Approved = false,
                UserList = new List<User> { user7, user8, user9, user10, user11 }
            };

            teams.Add(team1);
            teams.Add(team2);

            teams.ForEach(x => context.Team.Add(x));
            context.SaveChanges();

            var leagues = new List<League>
            {
                new League{LeagueID = 1, LeagueName = "DotA League", Description = "League with up to 16 teams", NumberOfTeams = 16, Teams = new List<Team>{ team1, team2}},
            };
            leagues.ForEach(x => context.League.Add(x));
            context.SaveChanges();
        }
    }
}