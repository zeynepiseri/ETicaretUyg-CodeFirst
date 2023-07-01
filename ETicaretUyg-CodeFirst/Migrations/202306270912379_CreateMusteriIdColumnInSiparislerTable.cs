namespace ETicaretUyg_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMusteriIdColumnInSiparislerTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Siparislers", "MusteriId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Siparislers", "MusteriId");
        }
    }
}
