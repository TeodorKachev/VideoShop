namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoviesTable : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Movies DROP COLUMN Genre");

        }
        
        public override void Down()
        {
        }
    }
}
