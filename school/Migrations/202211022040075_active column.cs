namespace school.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class activecolumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "active", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "active");
        }
    }
}
