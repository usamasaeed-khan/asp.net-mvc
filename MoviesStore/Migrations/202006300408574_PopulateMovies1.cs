namespace MoviesStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, Genre_Id) VALUES ('Hangover', '2018-01-01 00:00:00', '2020-01-01 00:00:00', 1, 9)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, Genre_Id) VALUES ('Diehard', '2018-01-01 00:00:00', '2020-01-01 00:00:00', 2, 10)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, Genre_Id) VALUES ('The Terminator','2018-01-01 00:00:00', '2020-01-01 00:00:00', 3, 10)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, Genre_Id) VALUES ('Toy Story','2018-01-01 00:00:00', '2020-01-01 00:00:00', 4, 11)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, Genre_Id) VALUES ('Titanic','2018-01-01 00:00:00', '2020-01-01 00:00:00', 5, 12)");
        }
        
        public override void Down()
        {
        }
    }
}
