namespace ETicaretUyg_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameMusretiSifreToMusteriSifreInMusterisTable1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Musterilers", "MusteriSifre", c => c.Int(nullable: false));
            DropColumn("dbo.Musterilers", "MusretiSifre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Musterilers", "MusretiSifre", c => c.Int(nullable: false));
            DropColumn("dbo.Musterilers", "MusteriSifre");
        }
    }
}
