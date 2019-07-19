using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TestApp.Models
{
    public class ActorContext:DbContext
    {
        public DbSet<Actor> Actors { get; set; }

        public DbSet<Buying> Buyings { get; set; }
    }
}