namespace GroupT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddInstructorIdColumnOnVehiclesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vehicles", "Instructors_Id", c => c.Guid(nullable: false));
            AddColumn("dbo.Vehicles", "Instructor_Instructor_Id", c => c.Guid());
            CreateIndex("dbo.Vehicles", "Instructor_Instructor_Id");
            AddForeignKey("dbo.Vehicles", "Instructor_Instructor_Id", "dbo.Instructors", "Instructor_Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehicles", "Instructor_Instructor_Id", "dbo.Instructors");
            DropIndex("dbo.Vehicles", new[] { "Instructor_Instructor_Id" });
            DropColumn("dbo.Vehicles", "Instructor_Instructor_Id");
            DropColumn("dbo.Vehicles", "Instructors_Id");
        }
    }
}
