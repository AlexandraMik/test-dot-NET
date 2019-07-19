using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace TestApp.Models
{
    public class DBinitializator : DropCreateDatabaseAlways<ActorContext>
    {
        protected override void Seed(ActorContext context)
        {
            context.Actors.Add(new Actor() { Name = "Benedict Cumberbatch", Age = 43, Price = 14000605 });

            context.Actors.Add(new Actor() { Name = "Andrew Scott", Age = 39, Price = 140605 });

            context.Actors.Add(new Actor() { Name = "Mark Gattis", Age = 48, Price = 140605 });
            base.Seed(context);
        }
    }
}