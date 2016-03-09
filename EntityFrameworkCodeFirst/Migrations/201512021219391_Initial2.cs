namespace EntityFrameworkCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Families", newName: "Friends");
            DropForeignKey("dbo.Rooms", "Family_Id", "dbo.Families");
            DropIndex("dbo.Rooms", new[] { "Family_Id" });
            DropTable("dbo.Rooms");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        RoomId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Family_Id = c.Int(),
                    })
                .PrimaryKey(t => t.RoomId);
            
            CreateIndex("dbo.Rooms", "Family_Id");
            AddForeignKey("dbo.Rooms", "Family_Id", "dbo.Families", "Id");
            RenameTable(name: "dbo.Friends", newName: "Families");
        }
    }
}
