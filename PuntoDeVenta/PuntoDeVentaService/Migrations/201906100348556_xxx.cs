namespace PuntoDeVentaService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class xxx : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_CAT_PROVEEDOR",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 256),
                        TelCasa = c.Int(nullable: false),
                        TelMovil = c.Int(nullable: false),
                        RFC = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Nombre, unique: true)
                .Index(t => t.RFC, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.TB_CAT_PROVEEDOR", new[] { "RFC" });
            DropIndex("dbo.TB_CAT_PROVEEDOR", new[] { "Nombre" });
            DropTable("dbo.TB_CAT_PROVEEDOR");
        }
    }
}
