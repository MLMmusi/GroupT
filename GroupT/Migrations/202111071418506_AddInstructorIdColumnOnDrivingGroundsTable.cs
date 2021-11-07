namespace GroupT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddInstructorIdColumnOnDrivingGroundsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vehicles", "Created_On", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vehicles", "Created_On");
        }
    }
}
