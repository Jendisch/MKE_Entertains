namespace MKEntertains.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class USERIDREQUIRED : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Schedules", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Schedules", new[] { "UserId" });
            AlterColumn("dbo.Schedules", "UserId", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Schedules", "UserId");
            AddForeignKey("dbo.Schedules", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Schedules", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Schedules", new[] { "UserId" });
            AlterColumn("dbo.Schedules", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Schedules", "UserId");
            AddForeignKey("dbo.Schedules", "UserId", "dbo.AspNetUsers", "Id");
        }
    }
}
