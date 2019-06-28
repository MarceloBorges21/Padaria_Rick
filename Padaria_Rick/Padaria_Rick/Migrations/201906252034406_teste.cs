namespace Padaria_Rick.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teste : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Categoria", new[] { "PessoaId" });
            DropIndex("dbo.Produto", new[] { "CategoriaId" });
            DropIndex("dbo.Produto", new[] { "PessoaId" });
            DropIndex("dbo.Venda", new[] { "PessoaId" });
            AlterColumn("dbo.Categoria", "PessoaId", c => c.Int());
            AlterColumn("dbo.Produto", "CategoriaId", c => c.Int());
            AlterColumn("dbo.Produto", "PessoaId", c => c.Int());
            AlterColumn("dbo.Venda", "PessoaId", c => c.Int());
            CreateIndex("dbo.Categoria", "PessoaId");
            CreateIndex("dbo.Produto", "CategoriaId");
            CreateIndex("dbo.Produto", "PessoaId");
            CreateIndex("dbo.Venda", "PessoaId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Venda", new[] { "PessoaId" });
            DropIndex("dbo.Produto", new[] { "PessoaId" });
            DropIndex("dbo.Produto", new[] { "CategoriaId" });
            DropIndex("dbo.Categoria", new[] { "PessoaId" });
            AlterColumn("dbo.Venda", "PessoaId", c => c.Int(nullable: false));
            AlterColumn("dbo.Produto", "PessoaId", c => c.Int(nullable: false));
            AlterColumn("dbo.Produto", "CategoriaId", c => c.Int(nullable: false));
            AlterColumn("dbo.Categoria", "PessoaId", c => c.Int(nullable: false));
            CreateIndex("dbo.Venda", "PessoaId");
            CreateIndex("dbo.Produto", "PessoaId");
            CreateIndex("dbo.Produto", "CategoriaId");
            CreateIndex("dbo.Categoria", "PessoaId");
        }
    }
}
