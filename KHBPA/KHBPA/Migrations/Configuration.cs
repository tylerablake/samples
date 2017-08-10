using KHBPA.Models;

namespace KHBPA.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<KHBPA.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "KHBPA.Models.ApplicationDbContext";
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(KHBPA.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            var membershipsList = new List<Membership>();
            membershipsList.Add(new Membership() { Type = "Basic" });
            membershipsList.Add(new Membership() { Type = "Super" });

            context.Memberships.AddRange(membershipsList);

            context.Members.AddOrUpdate(
              p => p.FullName,
              new Member { FirstName = "Peter", LastName = "Parker", FullName = "Peter Parker", Address = "20 Ingram Steet", City = "New York City", State = "New York", ZipCode = 11111, Membership = membershipsList.FirstOrDefault() },
              new Member { FirstName = "Bruce", LastName =  "Wayne", FullName = "Bruce Wayne", Address = "20 Ingram Steet", City = "Gotham City", State = "New Jersey", ZipCode = 22222, Membership = membershipsList.FirstOrDefault() },
              new Member { FirstName = "Clark", LastName = "Kent", FullName = "Clark Kent", Address = "20 Ingram Steet", City = "Metropolis", State = "Delaware", ZipCode = 33333, Membership = membershipsList.FirstOrDefault(ms => ms.Type == "Super") }
            );

            context.SaveChanges();
        }
    }
}
