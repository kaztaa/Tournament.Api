﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament.Core.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime Time { get; set; }

        // Foreign key
        public int TournamentId { get; set; }

        // Navigation property for the relationship
        public TournamentDetails Tournament { get; set; } = null!;
    }
}
