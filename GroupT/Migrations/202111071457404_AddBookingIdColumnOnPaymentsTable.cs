namespace GroupT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBookingIdColumnOnPaymentsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        Booking_Id = c.Guid(nullable: false),
                        Learner_Id = c.Guid(nullable: false),
                        Instructor_Id = c.Guid(nullable: false),
                        Vehicle_Id = c.Guid(nullable: false),
                        Booking_Date = c.DateTime(nullable: false),
                        Address = c.String(nullable: false),
                        Booking_Status = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Booking_Id)
                .ForeignKey("dbo.Instructors", t => t.Instructor_Id, cascadeDelete: true)
                .Index(t => t.Instructor_Id);
            
            AddColumn("dbo.Payments", "Booking_Id", c => c.Guid(nullable: false));
            CreateIndex("dbo.Payments", "Booking_Id");
            AddForeignKey("dbo.Payments", "Booking_Id", "dbo.Bookings", "Booking_Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payments", "Booking_Id", "dbo.Bookings");
            DropForeignKey("dbo.Bookings", "Instructor_Id", "dbo.Instructors");
            DropIndex("dbo.Bookings", new[] { "Instructor_Id" });
            DropIndex("dbo.Payments", new[] { "Booking_Id" });
            DropColumn("dbo.Payments", "Booking_Id");
            DropTable("dbo.Bookings");
        }
    }
}
