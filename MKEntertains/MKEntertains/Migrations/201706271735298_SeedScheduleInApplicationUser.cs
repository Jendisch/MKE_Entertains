namespace MKEntertains.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedScheduleInApplicationUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        MKEntertainDate = c.DateTime(),
                        FoodDrinkChoice = c.String(),
                        EntertainmentChoice = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Schedules", "Id", "dbo.AspNetUsers");
            DropIndex("dbo.Schedules", new[] { "Id" });
            DropTable("dbo.Schedules");
        }
    }
}
