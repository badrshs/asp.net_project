namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedmovie : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            SET IDENTITY_INSERT [dbo].[Movies] ON
            INSERT INTO [dbo].[Movies] ([Id], [Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock], [Image]) VALUES (3, N'Insurgent', 2, N'2018-07-04 11:04:46', N'2016-07-25 00:00:00', 5, N'https://upload.wikimedia.org/wikipedia/en/a/af/Insurgent_poster.jpg')
            INSERT INTO [dbo].[Movies] ([Id], [Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock], [Image]) VALUES (4, N'Prisoners', 2, N'2018-07-04 09:55:07', N'2013-09-18 00:00:00', 7, N'https://upload.wikimedia.org/wikipedia/en/6/63/Prisoners2013Poster.jpg')
            INSERT INTO [dbo].[Movies] ([Id], [Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock], [Image]) VALUES (5, N'The Hangover', 5, N'2018-07-04 09:56:23', N'2009-06-02 00:00:00', 12, N'https://m.media-amazon.com/images/M/MV5BNDAxMTZmZGItZmM2NC00M2E1LWI1NmEtZjhhODM2MGU0ZmJlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX675_CR0,0,675,999_AL_.jpg')
            INSERT INTO [dbo].[Movies] ([Id], [Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock], [Image]) VALUES (6, N'Titanic', 4, N'2018-07-04 09:58:14', N'1997-11-18 00:00:00', 3, N'https://m.media-amazon.com/images/M/MV5BMDdmZGU3NDQtY2E5My00ZTliLWIzOTUtMTY4ZGI1YjdiNjk3XkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_SY1000_CR0,0,671,1000_AL_.jpg')
            INSERT INTO [dbo].[Movies] ([Id], [Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock], [Image]) VALUES (7, N'It', 3, N'2018-07-04 10:49:41', N'2017-06-03 00:00:00', 20, N'https://m.media-amazon.com/images/M/MV5BZDVkZmI0YzAtNzdjYi00ZjhhLWE1ODEtMWMzMWMzNDA0NmQ4XkEyXkFqcGdeQXVyNzYzODM3Mzg@._V1_SY1000_CR0,0,666,1000_AL_.jpg')
            INSERT INTO [dbo].[Movies] ([Id], [Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock], [Image]) VALUES (8, N'Incredibles 2', 3, N'2018-07-04 10:32:10', N'2018-06-05 00:00:00', 16, N'https://lumiere-a.akamaihd.net/v1/images/mock_theincredibles2_e5c934bb.jpeg?region=0,0,2048,2709')
            INSERT INTO [dbo].[Movies] ([Id], [Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock], [Image]) VALUES (9, N'Atonement', 4, N'2018-07-04 10:32:15', N'2007-09-07 00:00:00', 7, N'https://upload.wikimedia.org/wikipedia/en/e/e4/Atonement_UK_poster.jpg')
            INSERT INTO [dbo].[Movies] ([Id], [Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock], [Image]) VALUES (10, N'Zootopia', 3, N'2018-07-04 10:34:03', N'2016-02-10 00:00:00', 10, N'https://images.justwatch.com/poster/8729516/s592/zootopia')
            INSERT INTO [dbo].[Movies] ([Id], [Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock], [Image]) VALUES (11, N'Hereditary', 3, N'2018-07-04 11:21:12', N'2018-06-07 00:00:00', 2, N'https://upload.wikimedia.org/wikipedia/en/d/d9/Hereditary.png')
            INSERT INTO [dbo].[Movies] ([Id], [Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock], [Image]) VALUES (12, N'Deadpool 2', 7, N'2018-07-04 11:27:53', N'2018-05-15 00:00:00', 14, N'https://www.bleedingcool.com/wp-content/uploads/2018/04/deadpool-2-cinemacon-f.jpg#main')
            INSERT INTO [dbo].[Movies] ([Id], [Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock], [Image]) VALUES (13, N'Blockers', 5, N'2018-07-04 11:29:21', N'2018-04-06 00:00:00', 13, N'https://upload.wikimedia.org/wikipedia/en/4/4a/Blockers_%28film%29.png')
            INSERT INTO [dbo].[Movies] ([Id], [Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock], [Image]) VALUES (14, N'Avatar', 7, N'2018-07-04 11:31:09', N'2009-12-10 00:00:00', 18, N'https://upload.wikimedia.org/wikipedia/en/thumb/b/b0/Avatar-Teaser-Poster.jpg/220px-Avatar-Teaser-Poster.jpg')
            SET IDENTITY_INSERT [dbo].[Movies] OFF
            ");
        }
        
        public override void Down()
        {
        }
    }
}
