namespace ELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Table1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Replies", "UserId", "dbo.Users");
            DropIndex("dbo.Replies", new[] { "UserId" });
            RenameColumn(table: "dbo.Replies", name: "UserId", newName: "User_Id");
            AddColumn("dbo.Replies", "PostedBy", c => c.String());
            AlterColumn("dbo.Replies", "User_Id", c => c.Int());
            CreateIndex("dbo.Replies", "User_Id");
            AddForeignKey("dbo.Replies", "User_Id", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Replies", "User_Id", "dbo.Users");
            DropIndex("dbo.Replies", new[] { "User_Id" });
            AlterColumn("dbo.Replies", "User_Id", c => c.Int(nullable: false));
            DropColumn("dbo.Replies", "PostedBy");
            RenameColumn(table: "dbo.Replies", name: "User_Id", newName: "UserId");
            CreateIndex("dbo.Replies", "UserId");
            AddForeignKey("dbo.Replies", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
    }
}
