using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFramwork.Models {
    internal sealed class Configration : DbMigrationsConfiguration<BooksDbContext> {
        public Configration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "SampleEntityFramwork.Models.BooksDbContext";
        }

    }
}
