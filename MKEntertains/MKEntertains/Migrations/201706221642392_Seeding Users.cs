namespace MKEntertains.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedingUsers : DbMigration
    {
        public override void Up()
        {

            Sql(@"

INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ac9626cd-8b68-438b-993f-549e5ed80a60', N'admin@gmail.com', 0, N'ACOTQWRZsamw5E2/AThlnPHMuscyecQHDzcJ6xPS8Fav6nNwkHEsv9rBZOibpRChgA==', N'00cb171a-dbea-4521-9af7-9e60a354f7b8', NULL, 0, 0, NULL, 1, 0, N'Admin')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'fdf64075-0e77-4413-8e95-2ba76f214c9a', N'bob@gmail.com', 0, N'AO2MNs3s5sWJfMt/DscYBr3AUFI/1Nzz4fDIOyitFmig1/CyKqkG036tR68/EqNzWQ==', N'0eae9904-501c-4043-9175-bd6ff26254f8', NULL, 0, 0, NULL, 1, 0, N'GuestBob')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a534b68b-caad-4581-8054-facf09d3a8ab', N'Client')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'524466ff-65ea-4c74-b984-10310dbe0ce5', N'Manager')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ac9626cd-8b68-438b-993f-549e5ed80a60', N'524466ff-65ea-4c74-b984-10310dbe0ce5')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'fdf64075-0e77-4413-8e95-2ba76f214c9a', N'a534b68b-caad-4581-8054-facf09d3a8ab')


");

        }
        
        public override void Down()
        {
        }
    }
}
