namespace ETicaretUyg_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameKategoriAdColumnToStringInKategorisTable : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE dbo.Kategorilers ALTER COLUMN KategoriAd NVARCHAR(MAX)");
        }

        public override void Down()
        {
            Sql("ALTER TABLE dbo.Kategorilers ALTER COLUMN KategoriAd INT");
        }
    }
}
