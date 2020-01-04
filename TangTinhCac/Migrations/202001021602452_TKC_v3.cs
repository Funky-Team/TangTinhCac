namespace TangTinhCac.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TKC_v3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Body", "CreatedDateTime", c => c.DateTime());
            AlterColumn("dbo.Body", "LastModifiedDateTime", c => c.DateTime());
            AlterColumn("dbo.Idol", "CreatedDateTime", c => c.DateTime());
            AlterColumn("dbo.Idol", "LastModifiedDateTime", c => c.DateTime());
            AlterColumn("dbo.BoobStatus", "CreatedDateTime", c => c.DateTime());
            AlterColumn("dbo.BoobStatus", "LastModifiedDateTime", c => c.DateTime());
            AlterColumn("dbo.Bra", "CreatedDateTime", c => c.DateTime());
            AlterColumn("dbo.Bra", "LastModifiedDateTime", c => c.DateTime());
            AlterColumn("dbo.IdolForumPost", "CreatedDateTime", c => c.DateTime());
            AlterColumn("dbo.IdolForumPost", "LastModifiedDateTime", c => c.DateTime());
            AlterColumn("dbo.IdolForumPostImage", "CreatedDateTime", c => c.DateTime());
            AlterColumn("dbo.IdolForumPostImage", "LastModifiedDateTime", c => c.DateTime());
            AlterColumn("dbo.IdolForumPostReaction", "CreatedDateTime", c => c.DateTime());
            AlterColumn("dbo.IdolForumPostReaction", "LastModifiedDateTime", c => c.DateTime());
            AlterColumn("dbo.ReactionType", "CreatedDateTime", c => c.DateTime());
            AlterColumn("dbo.ReactionType", "LastModifiedDateTime", c => c.DateTime());
            AlterColumn("dbo.IdolForumPostCommentReplyReaction", "CreatedDateTime", c => c.DateTime());
            AlterColumn("dbo.IdolForumPostCommentReplyReaction", "LastModifiedDateTime", c => c.DateTime());
            AlterColumn("dbo.IdolForumPostCommentReply", "CreatedDateTime", c => c.DateTime());
            AlterColumn("dbo.IdolForumPostCommentReply", "LastModifiedDateTime", c => c.DateTime());
            AlterColumn("dbo.IdolForumPostComment", "CreatedDateTime", c => c.DateTime());
            AlterColumn("dbo.IdolForumPostComment", "LastModifiedDateTime", c => c.DateTime());
            AlterColumn("dbo.IdolForumPostCommentReaction", "CreatedDateTime", c => c.DateTime());
            AlterColumn("dbo.IdolForumPostCommentReaction", "LastModifiedDateTime", c => c.DateTime());
            AlterColumn("dbo.IdolForumPostType", "CreatedDateTime", c => c.DateTime());
            AlterColumn("dbo.IdolForumPostType", "LastModifiedDateTime", c => c.DateTime());
            AlterColumn("dbo.IdolImage", "CreatedDateTime", c => c.DateTime());
            AlterColumn("dbo.IdolImage", "LastModifiedDateTime", c => c.DateTime());
            AlterColumn("dbo.IdolStory", "CreatedDateTime", c => c.DateTime());
            AlterColumn("dbo.IdolStory", "LastModifiedDateTime", c => c.DateTime());
            AlterColumn("dbo.IdolVideo", "CreatedDateTime", c => c.DateTime());
            AlterColumn("dbo.IdolVideo", "LastModifiedDateTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.IdolVideo", "LastModifiedDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.IdolVideo", "CreatedDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.IdolStory", "LastModifiedDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.IdolStory", "CreatedDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.IdolImage", "LastModifiedDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.IdolImage", "CreatedDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.IdolForumPostType", "LastModifiedDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.IdolForumPostType", "CreatedDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.IdolForumPostCommentReaction", "LastModifiedDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.IdolForumPostCommentReaction", "CreatedDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.IdolForumPostComment", "LastModifiedDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.IdolForumPostComment", "CreatedDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.IdolForumPostCommentReply", "LastModifiedDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.IdolForumPostCommentReply", "CreatedDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.IdolForumPostCommentReplyReaction", "LastModifiedDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.IdolForumPostCommentReplyReaction", "CreatedDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ReactionType", "LastModifiedDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ReactionType", "CreatedDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.IdolForumPostReaction", "LastModifiedDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.IdolForumPostReaction", "CreatedDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.IdolForumPostImage", "LastModifiedDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.IdolForumPostImage", "CreatedDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.IdolForumPost", "LastModifiedDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.IdolForumPost", "CreatedDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Bra", "LastModifiedDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Bra", "CreatedDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.BoobStatus", "LastModifiedDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.BoobStatus", "CreatedDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Idol", "LastModifiedDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Idol", "CreatedDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Body", "LastModifiedDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Body", "CreatedDateTime", c => c.DateTime(nullable: false));
        }
    }
}
