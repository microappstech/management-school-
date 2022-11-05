namespace school.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class columnimage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "image");
        }
    }
}
