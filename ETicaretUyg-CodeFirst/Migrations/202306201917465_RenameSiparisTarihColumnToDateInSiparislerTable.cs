namespace ETicaretUyg_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameSiparisTarihColumnToDateInSiparislerTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Siparislers", "SiparisTarih", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Siparislers", "SiparisTarih", c => c.Int(nullable: false));
        }
    }
}
