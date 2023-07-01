namespace ETicaretUyg_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameMusretiSoyadToMusteriSoyadInMusterisTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Musterilers", "MusteriSoyad", c => c.String());
            DropColumn("dbo.Musterilers", "MusretiSoyad");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Musterilers", "MusretiSoyad", c => c.String());
            DropColumn("dbo.Musterilers", "MusteriSoyad");
        }
    }
}
