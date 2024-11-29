using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Tournament.Core.Entities;
using System.Threading.Tasks;

namespace Tournament.Data.Data
{
    public static class SeedData
    {
        public static async Task Initialize(TournamentApiContext context)
        {
            context.Database.EnsureCreated();

            if (context.TournamentDetails.Any())
            {
                return;
            }

            var tournaments = new TournamentDetails[]
            {
                new TournamentDetails { Title = "Tournament 1", StartDate = DateTime.Now },
                new TournamentDetails { Title = "Tournament 2", StartDate = DateTime.Now }
            };

            foreach (var t in tournaments)
            {
                context.TournamentDetails.Add(t);
            }
            await context.SaveChangesAsync();

            var games = new Game[]
            {
                new Game { Title = "Game 1", Time = DateTime.Now, TournamentId = tournaments[0].Id },
                new Game { Title = "Game 2", Time = DateTime.Now, TournamentId = tournaments[1].Id }
            };

            foreach (var g in games)
            {
                context.Game.Add(g);
            }
            await context.SaveChangesAsync();
        }
    }
}