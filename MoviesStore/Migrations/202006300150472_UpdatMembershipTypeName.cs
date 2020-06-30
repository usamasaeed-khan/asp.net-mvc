namespace MoviesStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatMembershipTypeName : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'Pay As You Go' WHERE Id = 1 AND Name = NULL");
            Sql("UPDATE MembershipTypes SET Name = 'Monthly' WHERE Id = 2 AND Name = NULL");
            Sql("UPDATE MembershipTypes SET Name = 'Tri-Monthly' WHERE Id = 3 AND Name = NULL");
            Sql("UPDATE MembershipTypes SET Name = 'Yearly' WHERE Id = 4 AND Name = NULL");
        }
        
        public override void Down()
        {
        }
    }
}
