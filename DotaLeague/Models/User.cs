﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotaLeague.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
    }
}