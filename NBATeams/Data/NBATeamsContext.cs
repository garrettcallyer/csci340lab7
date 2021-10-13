using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NBATeams.Models;

namespace NBATeams.Data
{
    public class NBATeamsContext : DbContext
    {
        public NBATeamsContext (DbContextOptions<NBATeamsContext> options)
            : base(options)
        {
        }

        public DbSet<NBATeams.Models.Team> Team { get; set; }
    }
}
