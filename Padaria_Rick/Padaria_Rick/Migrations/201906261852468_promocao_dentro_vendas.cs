namespace Padaria_Rick.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class promocao_dentro_vendas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Venda", "PromocaoId", c => c.Int());
            AlterColumn("dbo.Venda", "Mesa", c => c.Int());
            CreateIndex("dbo.Venda", "PromocaoId");
            AddForeignKey("dbo.Venda", "PromocaoId", "dbo.Promocao", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Venda", "PromocaoId", "dbo.Promocao");
            DropIndex("dbo.Venda", new[] { "PromocaoId" });
            AlterColumn("dbo.Venda", "Mesa", c => c.Int(nullable: false));
            DropColumn("dbo.Venda", "PromocaoId");
        }
    }
}
