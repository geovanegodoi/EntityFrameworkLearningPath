namespace Migrations.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddedAccountsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Subscribe = c.DateTime(nullable: false),
                        ExpireDate = c.DateTime(nullable: false),
                        Type_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AccountTypes", t => t.Type_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Type_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Accounts", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Accounts", "Type_Id", "dbo.AccountTypes");
            DropIndex("dbo.Accounts", new[] { "User_Id" });
            DropIndex("dbo.Accounts", new[] { "Type_Id" });
            DropTable("dbo.Accounts");
        }
    }
}
