namespace ETicaretUyg_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ETicaretUyg_CodeFirst.Entity.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "ETicaretUyg_CodeFirst.Entity.Context";
        }

        protected override void Seed(ETicaretUyg_CodeFirst.Entity.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
