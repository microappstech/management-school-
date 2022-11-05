namespace school.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstmigrate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        nameCo = c.String(),
                        nbrH = c.Int(nullable: false),
                        spesialisteCo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        IdRom = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdRom);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        IdSt = c.Int(nullable: false, identity: true),
                        nameSt = c.String(),
                        emailSt = c.String(),
                        phoneSt = c.String(),
                        classeSt = c.String(),
                    })
                .PrimaryKey(t => t.IdSt);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        IdTe = c.Int(nullable: false, identity: true),
                        nameTe = c.String(),
                        emailTe = c.String(),
                        phoneTe = c.String(),
                        spesialisteT = c.String(),
                    })
                .PrimaryKey(t => t.IdTe);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Teachers");
            DropTable("dbo.Students");
            DropTable("dbo.Rooms");
            DropTable("dbo.Courses");
        }
    }
}
