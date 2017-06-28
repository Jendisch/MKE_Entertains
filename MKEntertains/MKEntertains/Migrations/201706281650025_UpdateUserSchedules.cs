namespace MKEntertains.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateUserSchedules : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Schedules", "Id", "dbo.AspNetUsers");
            DropIndex("dbo.Schedules", new[] { "Id" });
            DropPrimaryKey("dbo.Schedules");
            AddColumn("dbo.Schedules", "UserId", c => c.String(maxLength: 128));
            AlterColumn("dbo.Schedules", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Schedules", "Id");
            CreateIndex("dbo.Schedules", "UserId");
            AddForeignKey("dbo.Schedules", "UserId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Schedules", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Schedules", new[] { "UserId" });
            DropPrimaryKey("dbo.Schedules");
            AlterColumn("dbo.Schedules", "Id", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Schedules", "UserId");
            AddPrimaryKey("dbo.Schedules", "Id");
            CreateIndex("dbo.Schedules", "Id");
            AddForeignKey("dbo.Schedules", "Id", "dbo.AspNetUsers", "Id");
        }
    }
}
