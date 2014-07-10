using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotaLeague.Models
{
    public class Team
    {

        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public string TeamTag { get; set; }
        public DateTime RegistrationDateTime { get; set; }
        public bool Approved { get; set; }

        //En til mange relation mellem team og brugere
        public virtual ICollection<User> UserList { get; set; }
        public virtual League League { get; set; }
    }
}