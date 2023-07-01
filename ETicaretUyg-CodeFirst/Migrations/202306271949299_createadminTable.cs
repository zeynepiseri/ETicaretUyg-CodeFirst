namespace ETicaretUyg_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createadminTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminAd = c.String(nullable: false, maxLength: 128),
                        AdminSifre = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AdminAd);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Admins");
        }
    }
}
