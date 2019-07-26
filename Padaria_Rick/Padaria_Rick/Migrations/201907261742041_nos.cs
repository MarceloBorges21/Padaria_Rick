namespace Padaria_Rick.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nos : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pessoas", "Nome", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pessoas", "Nome", c => c.String(nullable: false));
        }
    }
}
