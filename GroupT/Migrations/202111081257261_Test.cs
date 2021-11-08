namespace GroupT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Administrators", "Id", c => c.Guid(nullable: false));
            AddColumn("dbo.Instructors", "Id", c => c.Guid(nullable: false));
            AddColumn("dbo.Learners", "Id", c => c.Guid(nullable: false));
            DropColumn("dbo.Administrators", "User_Id");
            DropColumn("dbo.Instructors", "User_Id");
            DropColumn("dbo.Learners", "User_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Learners", "User_Id", c => c.Guid(nullable: false));
            AddColumn("dbo.Instructors", "User_Id", c => c.Guid(nullable: false));
            AddColumn("dbo.Administrators", "User_Id", c => c.Guid(nullable: false));
            DropColumn("dbo.Learners", "Id");
            DropColumn("dbo.Instructors", "Id");
            DropColumn("dbo.Administrators", "Id");
        }
    }
}
