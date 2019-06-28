namespace Padaria_Rick.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _as : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categoria", "Descricao", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Categoria", "Descricao", c => c.Int(nullable: false));
        }
    }
}
