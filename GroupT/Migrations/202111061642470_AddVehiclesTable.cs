namespace GroupT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddVehiclesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        Vehicle_Id = c.Guid(nullable: false),
                        Vehicle_Name = c.String(nullable: false),
                        Vehicle_Model = c.String(nullable: false),
                        Vehicle_Color = c.String(nullable: false),
                        Vehicle_Type = c.String(nullable: false),
                        Vehicle_Picture = c.Byte(nullable: false),
                        Vehicle_Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Vehicle_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vehicles");
        }
    }
}
