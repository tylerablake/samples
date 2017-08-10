using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace KHBPARedux.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(): base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //This is where you can tell EF explicitly how to map your entities in the database.

            //1 directional relationship between Members and Memberships
            //Member has a reference to Membership but Membership does NOT have a reference to Members
            modelBuilder.Entity<Member>()
                .HasRequired(member => member.Membership)
                .WithRequiredPrincipal();                    

            //Then call the base.
            base.OnModelCreating(modelBuilder);
        }

        //Adding a DbSet for your entites will cause them to be added to the context 
        //and thus saved to the database.
        public DbSet<Member> Members { get; set; }
        public DbSet<Membership> Memberships { get; set; }


        //Then run Update-Database in the Package Manager Console, run Enable-Migrations if you haven't already.
    }
}