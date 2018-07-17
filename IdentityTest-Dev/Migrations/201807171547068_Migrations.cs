namespace IdentityTest_Dev.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migrations : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.UserModels", "Password");
            DropColumn("dbo.UserModels", "Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserModels", "Email", c => c.String());
            AddColumn("dbo.UserModels", "Password", c => c.String());
        }
    }
}
