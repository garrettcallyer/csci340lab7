using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NBATeams.Data;
using NBATeams.Models;

namespace NBATeams.Pages.Teams
{
    public class IndexModel : PageModel
    {
        private readonly NBATeams.Data.NBATeamsContext _context;

        public IndexModel(NBATeams.Data.NBATeamsContext context)
        {
            _context = context;
        }

        public IList<Team> Team { get;set; }

        public async Task OnGetAsync()
        {
            Team = await _context.Team.ToListAsync();
        }
    }
}
