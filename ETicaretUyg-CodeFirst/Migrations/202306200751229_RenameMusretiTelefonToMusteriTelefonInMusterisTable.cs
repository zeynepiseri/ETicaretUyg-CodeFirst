namespace ETicaretUyg_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    
    public partial class RenameMusretiTelefonToMusteriTelefonInMusterisTable : DbMigration
    {
        //public override void Up()
        //{
        //    AddColumn("dbo.Musterilers", "MusteriTelefon", c => c.String(maxLength: 20));
        //    Sql("ALTER TABLE dbo.Musteris ALTER COLUMN MusteriTelefon NVARCHAR(MAX)");
        //    DropColumn("dbo.Musterilers", "MusretiTelefon");
        //}

        //public override void Down()
        //{
        //    AddColumn("dbo.Musterilers", "MusretiTelefon", c => c.Int(nullable: false));
        //    Sql("ALTER TABLE dbo.Musteris ALTER COLUMN MusteriTelefon INT");
        //    DropColumn("dbo.Musterilers", "MusteriTelefon");
        //}


        public override void Up()
        {
            AddColumn("dbo.Musterilers", "MusteriTelefon_New", c => c.String(maxLength: 20));

            // MusteriTelefon_New sütununu MusretiTelefon sütunundan kopyala
            Sql("UPDATE dbo.Musterilers SET MusteriTelefon_New = CAST(MusteriTelefon AS NVARCHAR(20))");

            DropColumn("dbo.Musterilers", "MusretiTelefon");

            // MusteriTelefon_New sütununu MusteriTelefon olarak yeniden adlandır
            RenameColumn("dbo.Musterilers", "MusteriTelefon_New", "MusteriTelefon");
        }

        public override void Down()
        {
            AddColumn("dbo.Musterilers", "MusretiTelefon_New", c => c.Int(nullable: false));

            // MusretiTelefon_New sütununu MusteriTelefon sütunundan kopyala
            Sql("UPDATE dbo.Musterilers SET MusretiTelefon_New = CAST(MusteriTelefon AS INT)");

            DropColumn("dbo.Musterilers", "MusteriTelefon");

            // MusretiTelefon_New sütununu MusretiTelefon olarak yeniden adlandır
            RenameColumn("dbo.Musterilers", "MusretiTelefon_New", "MusretiTelefon");
        }








    }
}
