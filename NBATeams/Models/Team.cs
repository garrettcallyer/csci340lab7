using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NBATeams.Models
{
    public class Team
    {
        public int ID { get; set; }
        public string TeamName { get; set; }
        public string Location { get; set; }
        public string Mascot { get; set; }
        public string Abbreviation { get; set; }
        public decimal TicketPrice { get; set; }
    }
}
