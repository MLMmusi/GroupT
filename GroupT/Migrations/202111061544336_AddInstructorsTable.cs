namespace GroupT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddInstructorsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Instructors",
                c => new
                    {
                        Instructor_Id = c.Guid(nullable: false),
                        User_Id = c.Guid(nullable: false),
                        License_Num = c.String(nullable: false),
                        Alt_ContactNum = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Instructor_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Instructors");
        }
    }
}
