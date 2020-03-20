namespace Accounts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Picture1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Picture", c => c.String());
            AddColumn("dbo.AspNetUsers", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Name");
            DropColumn("dbo.AspNetUsers", "Picture");
        }
    }
}
