namespace ETicaretUyg_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Urunlers",
                c => new
                    {
                        UrunId = c.Int(nullable: false, identity: true),
                        UrunAd = c.String(),
                        UrunMarka = c.String(),
                        UrunStok = c.Int(nullable: false),
                        UrunKategori = c.String(),
                        UrunFiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.UrunId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Urunlers");
        }
    }
}
