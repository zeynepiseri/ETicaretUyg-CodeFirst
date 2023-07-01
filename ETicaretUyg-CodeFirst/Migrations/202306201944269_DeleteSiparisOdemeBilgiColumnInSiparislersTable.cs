namespace ETicaretUyg_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteSiparisOdemeBilgiColumnInSiparislersTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("Siparislers", "SiparisOdemeBilgi");
        }

        public override void Down()
        {
            AddColumn("Siparislers", "SiparisOdemeBilgi", c => c.Int(nullable: false));
        }
    }
}
