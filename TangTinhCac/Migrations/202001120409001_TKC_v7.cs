namespace TangTinhCac.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TKC_v7 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.IdolForumPostImage", "PostID", "dbo.IdolForumPost");
            DropForeignKey("dbo.IdolForumPostReaction", "PostID", "dbo.IdolForumPost");
            DropIndex("dbo.IdolForumPostImage", new[] { "PostID" });
            DropIndex("dbo.IdolForumPostReaction", new[] { "PostID" });
            DropPrimaryKey("dbo.IdolForumPost");
            AddColumn("dbo.IdolForumPost", "PostCD", c => c.String(nullable: false, maxLength: 3));
            AddColumn("dbo.IdolForumPostImage", "IdolForumPost_PostID", c => c.Int());
            AddColumn("dbo.IdolForumPostImage", "IdolForumPost_PostCD", c => c.String(maxLength: 3));
            AddColumn("dbo.IdolForumPostReaction", "IdolForumPost_PostID", c => c.Int());
            AddColumn("dbo.IdolForumPostReaction", "IdolForumPost_PostCD", c => c.String(maxLength: 3));
            AddPrimaryKey("dbo.IdolForumPost", new[] { "PostID", "PostCD" });
            CreateIndex("dbo.IdolForumPostImage", new[] { "IdolForumPost_PostID", "IdolForumPost_PostCD" });
            CreateIndex("dbo.IdolForumPostReaction", new[] { "IdolForumPost_PostID", "IdolForumPost_PostCD" });
            AddForeignKey("dbo.IdolForumPostImage", new[] { "IdolForumPost_PostID", "IdolForumPost_PostCD" }, "dbo.IdolForumPost", new[] { "PostID", "PostCD" });
            AddForeignKey("dbo.IdolForumPostReaction", new[] { "IdolForumPost_PostID", "IdolForumPost_PostCD" }, "dbo.IdolForumPost", new[] { "PostID", "PostCD" });
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IdolForumPostReaction", new[] { "IdolForumPost_PostID", "IdolForumPost_PostCD" }, "dbo.IdolForumPost");
            DropForeignKey("dbo.IdolForumPostImage", new[] { "IdolForumPost_PostID", "IdolForumPost_PostCD" }, "dbo.IdolForumPost");
            DropIndex("dbo.IdolForumPostReaction", new[] { "IdolForumPost_PostID", "IdolForumPost_PostCD" });
            DropIndex("dbo.IdolForumPostImage", new[] { "IdolForumPost_PostID", "IdolForumPost_PostCD" });
            DropPrimaryKey("dbo.IdolForumPost");
            DropColumn("dbo.IdolForumPostReaction", "IdolForumPost_PostCD");
            DropColumn("dbo.IdolForumPostReaction", "IdolForumPost_PostID");
            DropColumn("dbo.IdolForumPostImage", "IdolForumPost_PostCD");
            DropColumn("dbo.IdolForumPostImage", "IdolForumPost_PostID");
            DropColumn("dbo.IdolForumPost", "PostCD");
            AddPrimaryKey("dbo.IdolForumPost", "PostID");
            CreateIndex("dbo.IdolForumPostReaction", "PostID");
            CreateIndex("dbo.IdolForumPostImage", "PostID");
            AddForeignKey("dbo.IdolForumPostReaction", "PostID", "dbo.IdolForumPost", "PostID", cascadeDelete: true);
            AddForeignKey("dbo.IdolForumPostImage", "PostID", "dbo.IdolForumPost", "PostID", cascadeDelete: true);
        }
    }
}
