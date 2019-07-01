namespace Padaria_Rick.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nomes : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Categoria", newName: "Categorias");
            RenameTable(name: "dbo.Pessoa", newName: "Pessoas");
            RenameTable(name: "dbo.Produto", newName: "Produtoes");
            RenameTable(name: "dbo.Produto_FK_Venda", newName: "Produto_Venda");
            RenameTable(name: "dbo.Venda", newName: "Vendas");
            RenameTable(name: "dbo.Promocao", newName: "Promocaos");
            RenameTable(name: "dbo.Promocao_FK_Produto", newName: "Promocao_Produto");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Promocao_Produto", newName: "Promocao_FK_Produto");
            RenameTable(name: "dbo.Promocaos", newName: "Promocao");
            RenameTable(name: "dbo.Vendas", newName: "Venda");
            RenameTable(name: "dbo.Produto_Venda", newName: "Produto_FK_Venda");
            RenameTable(name: "dbo.Produtoes", newName: "Produto");
            RenameTable(name: "dbo.Pessoas", newName: "Pessoa");
            RenameTable(name: "dbo.Categorias", newName: "Categoria");
        }
    }
}
