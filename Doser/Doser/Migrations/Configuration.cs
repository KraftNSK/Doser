using Doser.Models;

namespace Doser.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Doser.Models.DBModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Doser.Models.DBModel";
        }

        protected override void Seed(Doser.Models.DBModel context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Users.AddOrUpdate(
                u=>u.Name,
                new User {Id = 1,Description = "",isDeleted = false, Name = "admin",Password = "1",Role = 1,TimeCreate = DateTime.Now, TimeDeleted = null},
                new User { Id = 2, Description = "", isDeleted = false, Name = "Operator", Password = "1", Role = 2, TimeCreate = DateTime.Now, TimeDeleted = null },
                new User { Id = 3, Description = "", isDeleted = false, Name = "Laba", Password = "1", Role = 3, TimeCreate = DateTime.Now, TimeDeleted = null }
                );

            context.Products.AddOrUpdate(
                p=>p.Name,
                new Product {Id = 1, Code = "100-1", Code1c = "000234", Description = "",isDeleted = false,Name = "Бетон 200-1", TimeCreate = DateTime.Now, TimeDeleted = null, UserCreate = context.Users.FirstOrDefault(i=>i.Name == "admin"), UserDeleted = null},
                new Product { Id = 2, Code = "350-1", Code1c = "000025", Description = "", isDeleted = false, Name = "Бетон 250-1", TimeCreate = DateTime.Now, TimeDeleted = null, UserCreate = context.Users.FirstOrDefault(i => i.Name == "Laba"), UserDeleted = null });
        }
    }
}
