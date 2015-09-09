﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;

namespace JourneyChurch.Groups.Web.Models
{
    public class DB : IdentityDbContext<JourneyUser>
    {
        public DbSet<TodoItem> Todos { get; set; }
    }
}
