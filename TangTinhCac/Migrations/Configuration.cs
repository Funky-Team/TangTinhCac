namespace TangTinhCac.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models.EntityModels.Idols;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TangTinhCac.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TangTinhCac.Models.ApplicationDbContext context)
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

            #region Users

            var userExist = context.Users.FirstOrDefault(m => m.UserName == "admin");
            if (userExist == null)
            {
                context.Users.Add(new ApplicationUser
                {
                    UserName = "admin",
                    Email = "tangkinhcac_102@gmail.com",
                    PasswordHash = "123456a@"
                });
                context.SaveChanges();
            }

            #endregion

            #region Idols

            var idol1Exist = context.Idols.FirstOrDefault(m => m.IdolName == "Maria Ozawa");
            if (idol1Exist == null)
            {
                context.Idols.Add(new Idol
                {
                    IdolID = Guid.NewGuid(),
                    IdolBirthday = DateTime.Now,
                    IdolCountryCD = "JAP",
                    IdolName = "Maria Ozawa",
                    //CreatedByID = user.Id,
                    CreatedDateTime = DateTime.Now,
                    LastModifiedDateTime = DateTime.Now
                });
                context.SaveChanges();
            }

            var idol2Exist = context.Idols.FirstOrDefault(m => m.IdolName == "Mr. Min");
            if (idol2Exist == null)
            {
                context.Idols.Add(new Idol
                {
                    IdolID = Guid.NewGuid(),
                    IdolBirthday = DateTime.Now,
                    IdolCountryCD = "VNA",
                    IdolName = "Mr. Min",
                    //CreatedByID = user.Id,
                    CreatedDateTime = DateTime.Now,
                    LastModifiedDateTime = DateTime.Now
                });
                context.SaveChanges();
            }

            #endregion


        }
    }
}
