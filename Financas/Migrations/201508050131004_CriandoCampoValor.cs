namespace Financas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriandoCampoValor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movimentacaos", "Valor", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movimentacaos", "Valor");
        }
    }
}
