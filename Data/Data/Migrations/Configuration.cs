namespace ReadLater.Data.Migrations
{
    using ReadLater.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ReadLater.Data.ReadLaterDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ReadLater.Data.ReadLaterDataContext context)
        {
            //This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.E.g.

            context.Categories.AddOrUpdate(
              p => p.Name,
              new Category { Name = "Igor" },
              new Category { Name = "Dejan" },
              new Category { Name = "Joce" }
            );

            context.SaveChanges();

            base.Seed(context);
        }
    }
}
