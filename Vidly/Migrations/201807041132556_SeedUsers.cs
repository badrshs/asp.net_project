namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8a79e096-052b-4057-9683-7a7443aa305a', N'admin@admin.com', 0, N'AKbUVOkKfcmLbjB03VkQ8oBLWnK1GDFbOif6coJKOM8bs1cfZeO7EKHfBjfNI3basw==', N'467b70f2-2e2d-43b5-aa43-df05fb57d231', NULL, 0, 0, NULL, 1, 0, N'admin@admin.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b38fafbd-3156-440a-88ab-851b2433fefc', N'guest@guest.com', 0, N'AKbUVOkKfcmLbjB03VkQ8oBLWnK1GDFbOif6coJKOM8bs1cfZeO7EKHfBjfNI3basw==', N'bb97d846-7e91-4b40-a1cd-94e996ffa47c', NULL, 0, 0, NULL, 1, 0, N'guest@guest.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'df696c9b-fa26-4f46-b2b1-ad753ea50361', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8a79e096-052b-4057-9683-7a7443aa305a', N'df696c9b-fa26-4f46-b2b1-ad753ea50361')
");

        }

        public override void Down()
        {
        }
    }
}
