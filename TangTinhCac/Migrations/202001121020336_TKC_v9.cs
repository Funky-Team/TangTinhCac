namespace TangTinhCac.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TKC_v9 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.IdolForumPost", new[] { "IdolForumPostType_PostTypeID", "IdolForumPostType_PostTypeCD" }, "dbo.IdolForumPostType");
            DropIndex("dbo.IdolForumPost", new[] { "IdolForumPostType_PostTypeID", "IdolForumPostType_PostTypeCD" });
            DropColumn("dbo.IdolForumPost", "PostTypeCD");
            RenameColumn(table: "dbo.IdolForumPost", name: "IdolForumPostType_PostTypeID", newName: "PostTypeCD");
            DropPrimaryKey("dbo.IdolForumPostType");
            AlterColumn("dbo.IdolForumPost", "PostTypeCD", c => c.String(nullable: false, maxLength: 3));
            AlterColumn("dbo.IdolForumPost", "PostTypeCD", c => c.String(nullable: false, maxLength: 3));
            AddPrimaryKey("dbo.IdolForumPostType", "PostTypeCD");
            CreateIndex("dbo.IdolForumPost", "PostTypeCD");
            AddForeignKey("dbo.IdolForumPost", "PostTypeCD", "dbo.IdolForumPostType", "PostTypeCD", cascadeDelete: true);
            DropColumn("dbo.IdolForumPost", "IdolForumPostType_PostTypeCD");
            DropColumn("dbo.IdolForumPostType", "PostTypeID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.IdolForumPostType", "PostTypeID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.IdolForumPost", "IdolForumPostType_PostTypeCD", c => c.String(maxLength: 3));
            DropForeignKey("dbo.IdolForumPost", "PostTypeCD", "dbo.IdolForumPostType");
            DropIndex("dbo.IdolForumPost", new[] { "PostTypeCD" });
            DropPrimaryKey("dbo.IdolForumPostType");
            AlterColumn("dbo.IdolForumPost", "PostTypeCD", c => c.Int());
            AlterColumn("dbo.IdolForumPost", "PostTypeCD", c => c.String(nullable: false));
            AddPrimaryKey("dbo.IdolForumPostType", new[] { "PostTypeID", "PostTypeCD" });
            RenameColumn(table: "dbo.IdolForumPost", name: "PostTypeCD", newName: "IdolForumPostType_PostTypeID");
            AddColumn("dbo.IdolForumPost", "PostTypeCD", c => c.String(nullable: false));
            CreateIndex("dbo.IdolForumPost", new[] { "IdolForumPostType_PostTypeID", "IdolForumPostType_PostTypeCD" });
            AddForeignKey("dbo.IdolForumPost", new[] { "IdolForumPostType_PostTypeID", "IdolForumPostType_PostTypeCD" }, "dbo.IdolForumPostType", new[] { "PostTypeID", "PostTypeCD" });
        }
    }
}
