namespace GroupT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNotificationsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Notifications",
                c => new
                    {
                        Notification_Id = c.Guid(nullable: false),
                        Admin_Id = c.Guid(nullable: false),
                        Learner_Id = c.Guid(nullable: false),
                        Instructor_Id = c.Guid(nullable: false),
                        Application_Status = c.String(nullable: false),
                        Reasons = c.String(nullable: false),
                        Booking_Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Notification_Id)
                .ForeignKey("dbo.Administrators", t => t.Admin_Id, cascadeDelete: true)
                .ForeignKey("dbo.Instructors", t => t.Instructor_Id, cascadeDelete: true)
                .ForeignKey("dbo.Learners", t => t.Learner_Id, cascadeDelete: true)
                .Index(t => t.Admin_Id)
                .Index(t => t.Learner_Id)
                .Index(t => t.Instructor_Id);
            
            CreateTable(
                "dbo.Administrators",
                c => new
                    {
                        Admin_Id = c.Guid(nullable: false),
                        User_Id = c.Guid(nullable: false),
                        Booking_Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Admin_Id);
            
            AddColumn("dbo.Reviews", "Booking_Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Notifications", "Learner_Id", "dbo.Learners");
            DropForeignKey("dbo.Notifications", "Instructor_Id", "dbo.Instructors");
            DropForeignKey("dbo.Notifications", "Admin_Id", "dbo.Administrators");
            DropIndex("dbo.Notifications", new[] { "Instructor_Id" });
            DropIndex("dbo.Notifications", new[] { "Learner_Id" });
            DropIndex("dbo.Notifications", new[] { "Admin_Id" });
            DropColumn("dbo.Reviews", "Booking_Date");
            DropTable("dbo.Administrators");
            DropTable("dbo.Notifications");
        }
    }
}
