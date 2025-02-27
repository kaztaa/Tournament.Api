﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tournament.Data.Data;
using Tournament.Core.Entities;
using Tournament.Core.Repositories;
using Microsoft.EntityFrameworkCore;



namespace Tournament.Data.Repositories
{
    public class GameRepository: IGameRepository
    {
        private readonly TournamentApiContext _context;

        public GameRepository(TournamentApiContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Game>> GetAllAsync()
        {
            return await _context.Game.ToListAsync();
        }

        public async Task<Game?> GetAsync(int id)
        {
            return await _context.Game.FindAsync(id);
        }

        public async Task<bool> AnyAsync(int id)
        {
            return await _context.Game.AnyAsync(t => t.Id == id);

        }

        public void Add(Game game)
        {
            _context.Game.Add(game);
        }

        public void Update(Game game)
        {
            _context.Game.Update(game);
        }

        public void Remove(Game game)
        {
            _context.Game.Remove(game);
        }
        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

    }
}
