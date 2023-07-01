namespace ETicaretUyg_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createMusteriSehirColumnInMusterisTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Musterilers", "MusretiSehir", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Musterilers", "MusretiSehir");
        }
    }
}
