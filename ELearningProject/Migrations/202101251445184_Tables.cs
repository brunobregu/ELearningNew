namespace ELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(nullable: false),
                        CreatedOn = c.DateTime(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Replies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(nullable: false),
                        CreatedOn = c.DateTime(),
                        UserId = c.Int(nullable: false),
                        CommentId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Comments", t => t.CommentId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: false)
                .Index(t => t.UserId)
                .Index(t => t.CommentId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Emri = c.String(nullable: false, maxLength: 8000, unicode: false),
                        Mbiemri = c.String(nullable: false, maxLength: 8000, unicode: false),
                        Username = c.String(nullable: false, maxLength: 8000, unicode: false),
                        Password = c.String(nullable: false),
                        Email = c.String(nullable: false, maxLength: 8000, unicode: false),
                        ImageUrl = c.String(),
                        CreatedOn = c.DateTime(),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.Emri, unique: true)
                .Index(t => t.Mbiemri, unique: true)
                .Index(t => t.Username, unique: true)
                .Index(t => t.Email, unique: true)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Roli = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserToKursis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        KursId = c.Int(nullable: false),
                        FavouriteCourse = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kursis", t => t.KursId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.KursId);
            
            CreateTable(
                "dbo.Kursis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmriKursit = c.String(nullable: false, maxLength: 8000, unicode: false),
                        Pershkrimi = c.String(nullable: false, maxLength: 8000, unicode: false),
                        ImagePath = c.String(nullable: false),
                        CreatedOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Materials",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmriTemes = c.String(),
                        MaterialsPath = c.String(),
                        PostedOn = c.DateTime(nullable: false),
                        PostedBy = c.String(),
                        KursId = c.Int(nullable: false),
                        TipId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kursis", t => t.KursId, cascadeDelete: true)
                .ForeignKey("dbo.MaterialsTypes", t => t.TipId, cascadeDelete: true)
                .Index(t => t.KursId)
                .Index(t => t.TipId);
            
            CreateTable(
                "dbo.MaterialsTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tipi = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserToKursis", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserToKursis", "KursId", "dbo.Kursis");
            DropForeignKey("dbo.Materials", "TipId", "dbo.MaterialsTypes");
            DropForeignKey("dbo.Materials", "KursId", "dbo.Kursis");
            DropForeignKey("dbo.Users", "RoleId", "dbo.UserRoles");
            DropForeignKey("dbo.Replies", "UserId", "dbo.Users");
            DropForeignKey("dbo.Comments", "UserId", "dbo.Users");
            DropForeignKey("dbo.Replies", "CommentId", "dbo.Comments");
            DropIndex("dbo.Materials", new[] { "TipId" });
            DropIndex("dbo.Materials", new[] { "KursId" });
            DropIndex("dbo.UserToKursis", new[] { "KursId" });
            DropIndex("dbo.UserToKursis", new[] { "UserId" });
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropIndex("dbo.Users", new[] { "Email" });
            DropIndex("dbo.Users", new[] { "Username" });
            DropIndex("dbo.Users", new[] { "Mbiemri" });
            DropIndex("dbo.Users", new[] { "Emri" });
            DropIndex("dbo.Replies", new[] { "CommentId" });
            DropIndex("dbo.Replies", new[] { "UserId" });
            DropIndex("dbo.Comments", new[] { "UserId" });
            DropTable("dbo.MaterialsTypes");
            DropTable("dbo.Materials");
            DropTable("dbo.Kursis");
            DropTable("dbo.UserToKursis");
            DropTable("dbo.UserRoles");
            DropTable("dbo.Users");
            DropTable("dbo.Replies");
            DropTable("dbo.Comments");
        }
    }
}
