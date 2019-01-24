namespace MobileCan.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MobileCan.Models.AuthenticationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            
        }

        protected override void Seed(MobileCan.Models.AuthenticationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            if (!roleManager.RoleExists("Admin"))
                roleManager.Create(new IdentityRole("Admin"));

            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var roba = new ApplicationUser() { UserName = "roba", Email = "roba@mobilecan.online" };
            if (!context.Users.Any(i => i.UserName == "roba"))
            {
                userManager.Create(roba, password: "changeme");
                userManager.AddToRole(roba.Id, "Admin");
            }
            //
        }
    }
}
