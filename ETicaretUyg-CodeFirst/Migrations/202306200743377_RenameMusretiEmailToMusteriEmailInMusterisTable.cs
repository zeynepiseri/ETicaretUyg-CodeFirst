namespace ETicaretUyg_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameMusretiEmailToMusteriEmailInMusterisTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Musterilers", "MusteriEmail", c => c.String());
            DropColumn("dbo.Musterilers", "MusretiEmail");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Musterilers", "MusretiEmail", c => c.String());
            DropColumn("dbo.Musterilers", "MusteriEmail");
        }
    }
}
