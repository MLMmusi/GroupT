namespace GroupT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReviewsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Instructors", "Created_On", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Instructors", "Created_On");
        }
    }
}
