namespace Migrations.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddedAccountTypeTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Enabled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            Sql("INSERT INTO dbo.ACCOUNTTYPES(DESCRIPTION, ENABLED) VALUES('Account Type One', 1)");
            Sql("INSERT INTO dbo.ACCOUNTTYPES(DESCRIPTION, ENABLED) VALUES('Account Type Two', 1)");
            Sql("INSERT INTO dbo.ACCOUNTTYPES(DESCRIPTION, ENABLED) VALUES('Account Type Three', 1)");
            Sql("INSERT INTO dbo.ACCOUNTTYPES(DESCRIPTION, ENABLED) VALUES('Account Type Four', 1)");
        }
        
        public override void Down()
        {
            DropTable("dbo.AccountTypes");
        }
    }
}
