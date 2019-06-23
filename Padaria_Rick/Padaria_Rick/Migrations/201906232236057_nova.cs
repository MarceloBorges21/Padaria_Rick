namespace Padaria_Rick.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nova : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Venda", new[] { "Pessoa_Id" });
            RenameColumn(table: "dbo.Venda", name: "Pessoa_Id", newName: "PessoaId");
            AlterColumn("dbo.Venda", "PessoaId", c => c.Int(nullable: false));
            CreateIndex("dbo.Venda", "PessoaId");
            DropColumn("dbo.Venda", "PessoaId_Func");
            DropColumn("dbo.Venda", "PessoaId_Clien");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Venda", "PessoaId_Clien", c => c.Int(nullable: false));
            AddColumn("dbo.Venda", "PessoaId_Func", c => c.Int(nullable: false));
            DropIndex("dbo.Venda", new[] { "PessoaId" });
            AlterColumn("dbo.Venda", "PessoaId", c => c.Int());
            RenameColumn(table: "dbo.Venda", name: "PessoaId", newName: "Pessoa_Id");
            CreateIndex("dbo.Venda", "Pessoa_Id");
        }
    }
}
