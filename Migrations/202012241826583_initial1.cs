namespace Final4567.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Photo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "Photo");
        }
    }
}
