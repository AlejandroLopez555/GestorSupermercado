namespace SistemaControlProductos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixTableNames : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Productoes", newName: "Productos");
            RenameTable(name: "dbo.Proveedors", newName: "Proveedores");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Proveedores", newName: "Proveedors");
            RenameTable(name: "dbo.Productos", newName: "Productoes");
        }
    }
}
