namespace ETicaretUyg_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameMusretiAdToMusteriAdInMusterisTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Musterilers", "MusteriAd", c => c.String());
            DropColumn("dbo.Musterilers", "MusretiAd");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Musterilers", "MusretiAd", c => c.String());
            DropColumn("dbo.Musterilers", "MusteriAd");
        }
    }
}
