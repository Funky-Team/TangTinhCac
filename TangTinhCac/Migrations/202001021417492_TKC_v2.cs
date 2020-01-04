namespace TangTinhCac.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TKC_v2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Body", "CreatedByID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Body", "LastModifiedByID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Idol", "CreatedByID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Idol", "LastModifiedByID", c => c.String(maxLength: 128));
            AlterColumn("dbo.BoobStatus", "CreatedByID", c => c.String(maxLength: 128));
            AlterColumn("dbo.BoobStatus", "LastModifiedByID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Bra", "CreatedByID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Bra", "LastModifiedByID", c => c.String(maxLength: 128));
            AlterColumn("dbo.IdolForumPost", "CreatedByID", c => c.String(maxLength: 128));
            AlterColumn("dbo.IdolForumPost", "LastModifiedByID", c => c.String(maxLength: 128));
            AlterColumn("dbo.IdolForumPostImage", "CreatedByID", c => c.String(maxLength: 128));
            AlterColumn("dbo.IdolForumPostImage", "LastModifiedByID", c => c.String(maxLength: 128));
            AlterColumn("dbo.IdolForumPostReaction", "CreatedByID", c => c.String(maxLength: 128));
            AlterColumn("dbo.IdolForumPostReaction", "LastModifiedByID", c => c.String(maxLength: 128));
            AlterColumn("dbo.ReactionType", "CreatedByID", c => c.String(maxLength: 128));
            AlterColumn("dbo.ReactionType", "LastModifiedByID", c => c.String(maxLength: 128));
            AlterColumn("dbo.IdolForumPostCommentReplyReaction", "CreatedByID", c => c.String(maxLength: 128));
            AlterColumn("dbo.IdolForumPostCommentReplyReaction", "LastModifiedByID", c => c.String(maxLength: 128));
            AlterColumn("dbo.IdolForumPostCommentReply", "CreatedByID", c => c.String(maxLength: 128));
            AlterColumn("dbo.IdolForumPostCommentReply", "LastModifiedByID", c => c.String(maxLength: 128));
            AlterColumn("dbo.IdolForumPostComment", "CreatedByID", c => c.String(maxLength: 128));
            AlterColumn("dbo.IdolForumPostComment", "LastModifiedByID", c => c.String(maxLength: 128));
            AlterColumn("dbo.IdolForumPostCommentReaction", "CreatedByID", c => c.String(maxLength: 128));
            AlterColumn("dbo.IdolForumPostCommentReaction", "LastModifiedByID", c => c.String(maxLength: 128));
            AlterColumn("dbo.IdolForumPostType", "CreatedByID", c => c.String(maxLength: 128));
            AlterColumn("dbo.IdolForumPostType", "LastModifiedByID", c => c.String(maxLength: 128));
            AlterColumn("dbo.IdolImage", "CreatedByID", c => c.String(maxLength: 128));
            AlterColumn("dbo.IdolImage", "LastModifiedByID", c => c.String(maxLength: 128));
            AlterColumn("dbo.IdolStory", "CreatedByID", c => c.String(maxLength: 128));
            AlterColumn("dbo.IdolStory", "LastModifiedByID", c => c.String(maxLength: 128));
            AlterColumn("dbo.IdolVideo", "CreatedByID", c => c.String(maxLength: 128));
            AlterColumn("dbo.IdolVideo", "LastModifiedByID", c => c.String(maxLength: 128));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.IdolVideo", "LastModifiedByID", c => c.Guid(nullable: false));
            AlterColumn("dbo.IdolVideo", "CreatedByID", c => c.Guid(nullable: false));
            AlterColumn("dbo.IdolStory", "LastModifiedByID", c => c.Guid(nullable: false));
            AlterColumn("dbo.IdolStory", "CreatedByID", c => c.Guid(nullable: false));
            AlterColumn("dbo.IdolImage", "LastModifiedByID", c => c.Guid(nullable: false));
            AlterColumn("dbo.IdolImage", "CreatedByID", c => c.Guid(nullable: false));
            AlterColumn("dbo.IdolForumPostType", "LastModifiedByID", c => c.Guid(nullable: false));
            AlterColumn("dbo.IdolForumPostType", "CreatedByID", c => c.Guid(nullable: false));
            AlterColumn("dbo.IdolForumPostCommentReaction", "LastModifiedByID", c => c.Guid(nullable: false));
            AlterColumn("dbo.IdolForumPostCommentReaction", "CreatedByID", c => c.Guid(nullable: false));
            AlterColumn("dbo.IdolForumPostComment", "LastModifiedByID", c => c.Guid(nullable: false));
            AlterColumn("dbo.IdolForumPostComment", "CreatedByID", c => c.Guid(nullable: false));
            AlterColumn("dbo.IdolForumPostCommentReply", "LastModifiedByID", c => c.Guid(nullable: false));
            AlterColumn("dbo.IdolForumPostCommentReply", "CreatedByID", c => c.Guid(nullable: false));
            AlterColumn("dbo.IdolForumPostCommentReplyReaction", "LastModifiedByID", c => c.Guid(nullable: false));
            AlterColumn("dbo.IdolForumPostCommentReplyReaction", "CreatedByID", c => c.Guid(nullable: false));
            AlterColumn("dbo.ReactionType", "LastModifiedByID", c => c.Guid(nullable: false));
            AlterColumn("dbo.ReactionType", "CreatedByID", c => c.Guid(nullable: false));
            AlterColumn("dbo.IdolForumPostReaction", "LastModifiedByID", c => c.Guid(nullable: false));
            AlterColumn("dbo.IdolForumPostReaction", "CreatedByID", c => c.Guid(nullable: false));
            AlterColumn("dbo.IdolForumPostImage", "LastModifiedByID", c => c.Guid(nullable: false));
            AlterColumn("dbo.IdolForumPostImage", "CreatedByID", c => c.Guid(nullable: false));
            AlterColumn("dbo.IdolForumPost", "LastModifiedByID", c => c.Guid(nullable: false));
            AlterColumn("dbo.IdolForumPost", "CreatedByID", c => c.Guid(nullable: false));
            AlterColumn("dbo.Bra", "LastModifiedByID", c => c.Guid(nullable: false));
            AlterColumn("dbo.Bra", "CreatedByID", c => c.Guid(nullable: false));
            AlterColumn("dbo.BoobStatus", "LastModifiedByID", c => c.Guid(nullable: false));
            AlterColumn("dbo.BoobStatus", "CreatedByID", c => c.Guid(nullable: false));
            AlterColumn("dbo.Idol", "LastModifiedByID", c => c.Guid(nullable: false));
            AlterColumn("dbo.Idol", "CreatedByID", c => c.Guid(nullable: false));
            AlterColumn("dbo.Body", "LastModifiedByID", c => c.Guid(nullable: false));
            AlterColumn("dbo.Body", "CreatedByID", c => c.Guid(nullable: false));
        }
    }
}
