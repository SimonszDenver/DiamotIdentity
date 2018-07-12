namespace IdentityTestProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migrations : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.MyUsers", "DateLastUpdated");
            DropColumn("dbo.MyUsers", "DateCreated");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MyUsers", "DateCreated", c => c.DateTime());
            AddColumn("dbo.MyUsers", "DateLastUpdated", c => c.DateTime());
        }
    }
}
