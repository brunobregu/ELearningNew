namespace ELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Final : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Replies", "User_Id", "dbo.Users");
            DropIndex("dbo.Replies", new[] { "User_Id" });
            RenameColumn(table: "dbo.Replies", name: "User_Id", newName: "UserId");
            AlterColumn("dbo.Replies", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Replies", "UserId");
            AddForeignKey("dbo.Replies", "UserId", "dbo.Users", "Id", cascadeDelete: false);
            DropColumn("dbo.Replies", "PostedBy");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Replies", "PostedBy", c => c.String());
            DropForeignKey("dbo.Replies", "UserId", "dbo.Users");
            DropIndex("dbo.Replies", new[] { "UserId" });
            AlterColumn("dbo.Replies", "UserId", c => c.Int());
            RenameColumn(table: "dbo.Replies", name: "UserId", newName: "User_Id");
            CreateIndex("dbo.Replies", "User_Id");
            AddForeignKey("dbo.Replies", "User_Id", "dbo.Users", "Id");
        }
    }
}
