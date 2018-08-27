namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedgenre : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[Genres] ([Id], [Name]) VALUES (6, N'Horror')
            INSERT INTO [dbo].[Genres] ([Id], [Name]) VALUES (7, N'Science fiction')");
        }
        
        public override void Down()
        {
        }
    }
}
