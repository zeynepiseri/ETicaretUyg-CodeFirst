namespace ETicaretUyg_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteKategori_KategoriIdColumnInUrunlersTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Musterilers", "Urunler_UrunId", c => c.Int());
            AddColumn("dbo.Siparislers", "Urunler_UrunId", c => c.Int());
            AlterColumn("dbo.Musterilers", "MusteriTelefon", c => c.String());
            CreateIndex("dbo.Musterilers", "Urunler_UrunId");
            CreateIndex("dbo.Siparislers", "Urunler_UrunId");
            AddForeignKey("dbo.Musterilers", "Urunler_UrunId", "dbo.Urunlers", "UrunId");
            AddForeignKey("dbo.Siparislers", "Urunler_UrunId", "dbo.Urunlers", "UrunId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Siparislers", "Urunler_UrunId", "dbo.Urunlers");
            DropForeignKey("dbo.Musterilers", "Urunler_UrunId", "dbo.Urunlers");
            DropIndex("dbo.Siparislers", new[] { "Urunler_UrunId" });
            DropIndex("dbo.Musterilers", new[] { "Urunler_UrunId" });
            AlterColumn("dbo.Musterilers", "MusteriTelefon", c => c.Int(nullable: false));
            DropColumn("dbo.Siparislers", "Urunler_UrunId");
            DropColumn("dbo.Musterilers", "Urunler_UrunId");
        }
    }
}
