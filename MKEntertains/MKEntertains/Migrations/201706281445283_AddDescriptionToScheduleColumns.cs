namespace MKEntertains.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDescriptionToScheduleColumns : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Schedules", "Description", c => c.String());
            AlterColumn("dbo.Schedules", "MKEntertainDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Schedules", "FoodDrinkChoice", c => c.String(nullable: false));
            AlterColumn("dbo.Schedules", "EntertainmentChoice", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Schedules", "EntertainmentChoice", c => c.String());
            AlterColumn("dbo.Schedules", "FoodDrinkChoice", c => c.String());
            AlterColumn("dbo.Schedules", "MKEntertainDate", c => c.DateTime());
            DropColumn("dbo.Schedules", "Description");
        }
    }
}
