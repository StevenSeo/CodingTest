namespace CodingTest.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class MigrationsConfig : DbMigrationsConfiguration<CodingTest.Models.Db>
    {
        public MigrationsConfig()
        {
            AutomaticMigrationsEnabled = true;
        }
    }
}
