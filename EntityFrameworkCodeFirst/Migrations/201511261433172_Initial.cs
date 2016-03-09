namespace EntityFrameworkCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Friends",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        RoomId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Family_Id = c.Int(),
                    })
                .PrimaryKey(t => t.RoomId)
                .ForeignKey("dbo.Friends", t => t.Family_Id)
                .Index(t => t.Family_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rooms", "Family_Id", "dbo.Friends");
            DropIndex("dbo.Rooms", new[] { "Family_Id" });
            DropTable("dbo.Rooms");
            DropTable("dbo.Friends");
        }
    }
}
