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
    public class DetailsModel : PageModel
    {
        private readonly NBATeams.Data.NBATeamsContext _context;

        public DetailsModel(NBATeams.Data.NBATeamsContext context)
        {
            _context = context;
        }

        public Team Team { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Team = await _context.Team.FirstOrDefaultAsync(m => m.ID == id);

            if (Team == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
