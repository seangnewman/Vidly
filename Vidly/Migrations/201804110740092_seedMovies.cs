namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreID)" +
                " VALUES ('Blade Runner', 01-01-1978,04-10-2018,5,2)," +
                " ('Star Wars', 01-01-1976,04-10-2018,5,2)");
        }
        
        public override void Down()
        {
        }
    }
}
