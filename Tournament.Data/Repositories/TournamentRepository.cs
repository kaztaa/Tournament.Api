﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tournament.Data.Data;
using Tournament.Core.Repositories;
using Tournament.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Tournament.Data.Repositories
{
    public class TournamentRepository : ITournamentRepository
    {

        private readonly TournamentApiContext _context;
        
        public TournamentRepository(TournamentApiContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TournamentDetails>> GetAllAsync()
        {
            return await _context.TournamentDetails.ToListAsync();
        }

        public async Task<TournamentDetails?> GetAsync(int id)
        {
            return await _context.TournamentDetails.FindAsync(id);

        }

        public async Task<bool> AnyAsync(int id)
        {
            return await _context.TournamentDetails.AnyAsync(t => t.Id == id);
        }

        public void Add(TournamentDetails tournament)
        {
            _context.TournamentDetails.Add(tournament);
        }

        public void Update(TournamentDetails tournament)
        {
            _context.TournamentDetails.Update(tournament);
        }

        public void Remove(TournamentDetails tournament)
        {
            _context.TournamentDetails.Remove(tournament);

        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
