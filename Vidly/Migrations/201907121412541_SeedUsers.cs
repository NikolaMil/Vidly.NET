namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'31f9cb38-28da-4e43-be9f-9746b2090838', N'admin@vidly.com', 0, N'ALKZq8ovdOAM4HdaYl7EBctb3mWjofK2E6fsUBbM42ne7kfEoss+Um98yBuePK4aaQ==', N'754941e1-c3c4-4435-bb5b-0098435547e0', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'fb247850-50ac-4bd9-a009-ce54752d41c4', N'guest@vidly.com', 1, N'AOljOc3TkxI7SPxvp/czeyc2x+NiP0V1h1DqxKHx5Jab1TCLhk7VQDCt/WxT7tRo6A==', N'6474cfa4-18d6-4b9d-af71-7d0d0e318afc', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd9b88094-c4c9-4981-9400-ee956dc01186', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'31f9cb38-28da-4e43-be9f-9746b2090838', N'd9b88094-c4c9-4981-9400-ee956dc01186')

");
        }
        
        public override void Down()
        {
        }
    }
}
