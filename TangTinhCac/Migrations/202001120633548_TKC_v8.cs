namespace TangTinhCac.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TKC_v8 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.IdolForumPostImage", new[] { "IdolForumPost_PostID", "IdolForumPost_PostCD" }, "dbo.IdolForumPost");
            DropForeignKey("dbo.IdolForumPostReaction", new[] { "IdolForumPost_PostID", "IdolForumPost_PostCD" }, "dbo.IdolForumPost");
            DropForeignKey("dbo.IdolForumPost", "PostTypeID", "dbo.IdolForumPostType");
            DropIndex("dbo.IdolForumPost", new[] { "PostTypeID" });
            DropIndex("dbo.IdolForumPostImage", new[] { "IdolForumPost_PostID", "IdolForumPost_PostCD" });
            DropIndex("dbo.IdolForumPostReaction", new[] { "IdolForumPost_PostID", "IdolForumPost_PostCD" });
            DropColumn("dbo.IdolForumPostImage", "PostID");
            DropColumn("dbo.IdolForumPostReaction", "PostID");
            RenameColumn(table: "dbo.IdolForumPostImage", name: "IdolForumPost_PostID", newName: "PostID");
            RenameColumn(table: "dbo.IdolForumPostReaction", name: "IdolForumPost_PostID", newName: "PostID");
            RenameColumn(table: "dbo.IdolForumPost", name: "PostTypeID", newName: "IdolForumPostType_PostTypeID");
            DropPrimaryKey("dbo.IdolForumPost");
            DropPrimaryKey("dbo.IdolForumPostType");
            AddColumn("dbo.IdolForumPost", "PostTypeCD", c => c.String(nullable: false));
            AddColumn("dbo.IdolForumPost", "IdolForumPostType_PostTypeCD", c => c.String(maxLength: 3));
            AddColumn("dbo.IdolForumPostType", "PostTypeCD", c => c.String(nullable: false, maxLength: 3));
            AlterColumn("dbo.IdolForumPost", "IdolForumPostType_PostTypeID", c => c.Int());
            AlterColumn("dbo.IdolForumPostImage", "PostID", c => c.Int(nullable: false));
            AlterColumn("dbo.IdolForumPostReaction", "PostID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.IdolForumPost", "PostID");
            AddPrimaryKey("dbo.IdolForumPostType", new[] { "PostTypeID", "PostTypeCD" });
            CreateIndex("dbo.IdolForumPost", new[] { "IdolForumPostType_PostTypeID", "IdolForumPostType_PostTypeCD" });
            CreateIndex("dbo.IdolForumPostImage", "PostID");
            CreateIndex("dbo.IdolForumPostReaction", "PostID");
            AddForeignKey("dbo.IdolForumPostImage", "PostID", "dbo.IdolForumPost", "PostID", cascadeDelete: true);
            AddForeignKey("dbo.IdolForumPostReaction", "PostID", "dbo.IdolForumPost", "PostID", cascadeDelete: true);
            AddForeignKey("dbo.IdolForumPost", new[] { "IdolForumPostType_PostTypeID", "IdolForumPostType_PostTypeCD" }, "dbo.IdolForumPostType", new[] { "PostTypeID", "PostTypeCD" });
            DropColumn("dbo.IdolForumPost", "PostCD");
            DropColumn("dbo.IdolForumPostImage", "IdolForumPost_PostCD");
            DropColumn("dbo.IdolForumPostReaction", "IdolForumPost_PostCD");
        }
        
        public override void Down()
        {
            AddColumn("dbo.IdolForumPostReaction", "IdolForumPost_PostCD", c => c.String(maxLength: 3));
            AddColumn("dbo.IdolForumPostImage", "IdolForumPost_PostCD", c => c.String(maxLength: 3));
            AddColumn("dbo.IdolForumPost", "PostCD", c => c.String(nullable: false, maxLength: 3));
            DropForeignKey("dbo.IdolForumPost", new[] { "IdolForumPostType_PostTypeID", "IdolForumPostType_PostTypeCD" }, "dbo.IdolForumPostType");
            DropForeignKey("dbo.IdolForumPostReaction", "PostID", "dbo.IdolForumPost");
            DropForeignKey("dbo.IdolForumPostImage", "PostID", "dbo.IdolForumPost");
            DropIndex("dbo.IdolForumPostReaction", new[] { "PostID" });
            DropIndex("dbo.IdolForumPostImage", new[] { "PostID" });
            DropIndex("dbo.IdolForumPost", new[] { "IdolForumPostType_PostTypeID", "IdolForumPostType_PostTypeCD" });
            DropPrimaryKey("dbo.IdolForumPostType");
            DropPrimaryKey("dbo.IdolForumPost");
            AlterColumn("dbo.IdolForumPostReaction", "PostID", c => c.Int());
            AlterColumn("dbo.IdolForumPostImage", "PostID", c => c.Int());
            AlterColumn("dbo.IdolForumPost", "IdolForumPostType_PostTypeID", c => c.Int(nullable: false));
            DropColumn("dbo.IdolForumPostType", "PostTypeCD");
            DropColumn("dbo.IdolForumPost", "IdolForumPostType_PostTypeCD");
            DropColumn("dbo.IdolForumPost", "PostTypeCD");
            AddPrimaryKey("dbo.IdolForumPostType", "PostTypeID");
            AddPrimaryKey("dbo.IdolForumPost", new[] { "PostID", "PostCD" });
            RenameColumn(table: "dbo.IdolForumPost", name: "IdolForumPostType_PostTypeID", newName: "PostTypeID");
            RenameColumn(table: "dbo.IdolForumPostReaction", name: "PostID", newName: "IdolForumPost_PostID");
            RenameColumn(table: "dbo.IdolForumPostImage", name: "PostID", newName: "IdolForumPost_PostID");
            AddColumn("dbo.IdolForumPostReaction", "PostID", c => c.Int(nullable: false));
            AddColumn("dbo.IdolForumPostImage", "PostID", c => c.Int(nullable: false));
            CreateIndex("dbo.IdolForumPostReaction", new[] { "IdolForumPost_PostID", "IdolForumPost_PostCD" });
            CreateIndex("dbo.IdolForumPostImage", new[] { "IdolForumPost_PostID", "IdolForumPost_PostCD" });
            CreateIndex("dbo.IdolForumPost", "PostTypeID");
            AddForeignKey("dbo.IdolForumPost", "PostTypeID", "dbo.IdolForumPostType", "PostTypeID", cascadeDelete: true);
            AddForeignKey("dbo.IdolForumPostReaction", new[] { "IdolForumPost_PostID", "IdolForumPost_PostCD" }, "dbo.IdolForumPost", new[] { "PostID", "PostCD" });
            AddForeignKey("dbo.IdolForumPostImage", new[] { "IdolForumPost_PostID", "IdolForumPost_PostCD" }, "dbo.IdolForumPost", new[] { "PostID", "PostCD" });
        }
    }
}
