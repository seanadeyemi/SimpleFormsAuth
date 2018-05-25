namespace SimpleFormsAuth.Migrations
{
    using SimpleFormsAuth.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SimpleFormsAuth.MyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SimpleFormsAuth.MyDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            //var user = new User { UserId = "chuks", Password = "1000" };
            //context.Set<User>().Add(user);
            //context.SaveChanges();
        }
    }
}
