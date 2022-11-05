namespace school.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class somechanges : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Courses", "active", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Courses", "active", c => c.Boolean(nullable: false));
        }
    }
}
