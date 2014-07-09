using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotaLeague.Models
{
    public class League
    {
        public int LeagueID { get; set; }
        public string LeagueName { get; set; }
        public string Description { get; set; }
        public int NumberOfTeams { get; set; }
        
        //En til mange relation mellem league og teams
        public virtual ICollection<Team> Teams { get; set; } 
    }
}