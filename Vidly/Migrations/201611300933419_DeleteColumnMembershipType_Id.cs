namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteColumnMembershipType_Id : DbMigration
    {
        public override void Up()
        {
            Sql("SELECT * FROM Customers");
        }
        
        public override void Down()
        {
        }
    }
}
