namespace Migrations.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InitialDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Login = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);

            Sql("INSERT INTO dbo.USERS(NAME, LOGIN, PASSWORD) VALUES('Geovane Godoi','geovane.godoi','geovane123')");
            Sql("INSERT INTO dbo.USERS(NAME, LOGIN, PASSWORD) VALUES('Vanessa Godoi','vanessa.godoi','vanessa123')");
            Sql("INSERT INTO dbo.USERS(NAME, LOGIN, PASSWORD) VALUES('Alice Godoi','alice.godoi','alice123')");
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
