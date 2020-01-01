namespace TangTinhCac.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TKC_v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Body",
                c => new
                    {
                        BodyID = c.Int(nullable: false, identity: true),
                        BodyDesc = c.String(nullable: false, maxLength: 50),
                        CreatedByID = c.Guid(nullable: false),
                        CreatedDateTime = c.DateTime(nullable: false),
                        LastModifiedByID = c.Guid(nullable: false),
                        LastModifiedDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BodyID);
            
            CreateTable(
                "dbo.Idol",
                c => new
                    {
                        IdolID = c.Guid(nullable: false),
                        IdolName = c.String(nullable: false, maxLength: 50),
                        IdolOtherName = c.String(maxLength: 50),
                        IdolBirthday = c.DateTime(nullable: false),
                        IdolCountryCD = c.String(maxLength: 3),
                        IdolHeight = c.Int(),
                        IdolWeight = c.Int(),
                        BodyID = c.Int(),
                        IdolMeasurements = c.String(maxLength: 20),
                        BraSizeID = c.Int(),
                        BoobStatusID = c.Int(),
                        CreatedByID = c.Guid(nullable: false),
                        CreatedDateTime = c.DateTime(nullable: false),
                        LastModifiedByID = c.Guid(nullable: false),
                        LastModifiedDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdolID)
                .ForeignKey("dbo.Body", t => t.BodyID)
                .ForeignKey("dbo.BoobStatus", t => t.BoobStatusID)
                .ForeignKey("dbo.Bra", t => t.BraSizeID)
                .Index(t => t.BodyID)
                .Index(t => t.BraSizeID)
                .Index(t => t.BoobStatusID);
            
            CreateTable(
                "dbo.BoobStatus",
                c => new
                    {
                        BoobStatusID = c.Int(nullable: false, identity: true),
                        BoobStatusDesc = c.String(nullable: false, maxLength: 50),
                        CreatedByID = c.Guid(nullable: false),
                        CreatedDateTime = c.DateTime(nullable: false),
                        LastModifiedByID = c.Guid(nullable: false),
                        LastModifiedDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BoobStatusID);
            
            CreateTable(
                "dbo.Bra",
                c => new
                    {
                        BraID = c.Int(nullable: false, identity: true),
                        BraDesc = c.String(nullable: false, maxLength: 10),
                        CreatedByID = c.Guid(nullable: false),
                        CreatedDateTime = c.DateTime(nullable: false),
                        LastModifiedByID = c.Guid(nullable: false),
                        LastModifiedDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BraID);
            
            CreateTable(
                "dbo.IdolForumPost",
                c => new
                    {
                        PostID = c.Int(nullable: false, identity: true),
                        PostContent = c.String(nullable: false, maxLength: 100),
                        PostTypeID = c.Int(nullable: false),
                        IdolID = c.Guid(nullable: false),
                        CreatedByID = c.Guid(nullable: false),
                        CreatedDateTime = c.DateTime(nullable: false),
                        LastModifiedByID = c.Guid(nullable: false),
                        LastModifiedDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PostID)
                .ForeignKey("dbo.Idol", t => t.IdolID, cascadeDelete: true)
                .ForeignKey("dbo.IdolForumPostType", t => t.PostTypeID, cascadeDelete: true)
                .Index(t => t.PostTypeID)
                .Index(t => t.IdolID);
            
            CreateTable(
                "dbo.IdolForumPostImage",
                c => new
                    {
                        ImageID = c.Int(nullable: false, identity: true),
                        ImageLink = c.String(nullable: false),
                        PostID = c.Int(nullable: false),
                        CreatedByID = c.Guid(nullable: false),
                        CreatedDateTime = c.DateTime(nullable: false),
                        LastModifiedByID = c.Guid(nullable: false),
                        LastModifiedDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ImageID)
                .ForeignKey("dbo.IdolForumPost", t => t.PostID, cascadeDelete: true)
                .Index(t => t.PostID);
            
            CreateTable(
                "dbo.IdolForumPostReaction",
                c => new
                    {
                        ReactionID = c.Int(nullable: false, identity: true),
                        ReactionTypeID = c.Int(nullable: false),
                        PostID = c.Int(nullable: false),
                        CreatedByID = c.Guid(nullable: false),
                        CreatedDateTime = c.DateTime(nullable: false),
                        LastModifiedByID = c.Guid(nullable: false),
                        LastModifiedDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ReactionID)
                .ForeignKey("dbo.IdolForumPost", t => t.PostID, cascadeDelete: true)
                .ForeignKey("dbo.ReactionType", t => t.ReactionTypeID, cascadeDelete: true)
                .Index(t => t.ReactionTypeID)
                .Index(t => t.PostID);
            
            CreateTable(
                "dbo.ReactionType",
                c => new
                    {
                        ReactionTypeID = c.Int(nullable: false, identity: true),
                        ReactionTypeDesc = c.String(nullable: false),
                        CreatedByID = c.Guid(nullable: false),
                        CreatedDateTime = c.DateTime(nullable: false),
                        LastModifiedByID = c.Guid(nullable: false),
                        LastModifiedDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ReactionTypeID);
            
            CreateTable(
                "dbo.IdolForumPostCommentReplyReaction",
                c => new
                    {
                        ReactionID = c.Int(nullable: false, identity: true),
                        ReactionTypeID = c.Int(nullable: false),
                        ReplyID = c.Int(nullable: false),
                        CreatedByID = c.Guid(nullable: false),
                        CreatedDateTime = c.DateTime(nullable: false),
                        LastModifiedByID = c.Guid(nullable: false),
                        LastModifiedDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ReactionID)
                .ForeignKey("dbo.IdolForumPostCommentReply", t => t.ReplyID, cascadeDelete: true)
                .ForeignKey("dbo.ReactionType", t => t.ReactionTypeID, cascadeDelete: true)
                .Index(t => t.ReactionTypeID)
                .Index(t => t.ReplyID);
            
            CreateTable(
                "dbo.IdolForumPostCommentReply",
                c => new
                    {
                        ReplyID = c.Int(nullable: false, identity: true),
                        ReplyContent = c.String(nullable: false),
                        CommentID = c.Int(nullable: false),
                        CreatedByID = c.Guid(nullable: false),
                        CreatedDateTime = c.DateTime(nullable: false),
                        LastModifiedByID = c.Guid(nullable: false),
                        LastModifiedDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ReplyID)
                .ForeignKey("dbo.IdolForumPostComment", t => t.CommentID, cascadeDelete: true)
                .Index(t => t.CommentID);
            
            CreateTable(
                "dbo.IdolForumPostComment",
                c => new
                    {
                        CommentID = c.Int(nullable: false, identity: true),
                        CommentContent = c.String(nullable: false),
                        CreatedByID = c.Guid(nullable: false),
                        CreatedDateTime = c.DateTime(nullable: false),
                        LastModifiedByID = c.Guid(nullable: false),
                        LastModifiedDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CommentID);
            
            CreateTable(
                "dbo.IdolForumPostCommentReaction",
                c => new
                    {
                        ReactionID = c.Int(nullable: false, identity: true),
                        ReactionTypeID = c.Int(nullable: false),
                        CommentID = c.Int(nullable: false),
                        CreatedByID = c.Guid(nullable: false),
                        CreatedDateTime = c.DateTime(nullable: false),
                        LastModifiedByID = c.Guid(nullable: false),
                        LastModifiedDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ReactionID)
                .ForeignKey("dbo.IdolForumPostComment", t => t.CommentID, cascadeDelete: true)
                .ForeignKey("dbo.ReactionType", t => t.ReactionTypeID, cascadeDelete: true)
                .Index(t => t.ReactionTypeID)
                .Index(t => t.CommentID);
            
            CreateTable(
                "dbo.IdolForumPostType",
                c => new
                    {
                        PostTypeID = c.Int(nullable: false, identity: true),
                        PostTypeDesc = c.String(nullable: false),
                        CreatedByID = c.Guid(nullable: false),
                        CreatedDateTime = c.DateTime(nullable: false),
                        LastModifiedByID = c.Guid(nullable: false),
                        LastModifiedDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PostTypeID);
            
            CreateTable(
                "dbo.IdolImage",
                c => new
                    {
                        ImageID = c.Int(nullable: false, identity: true),
                        ImageLink = c.String(nullable: false),
                        IdolID = c.Guid(nullable: false),
                        CreatedByID = c.Guid(nullable: false),
                        CreatedDateTime = c.DateTime(nullable: false),
                        LastModifiedByID = c.Guid(nullable: false),
                        LastModifiedDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ImageID)
                .ForeignKey("dbo.Idol", t => t.IdolID, cascadeDelete: true)
                .Index(t => t.IdolID);
            
            CreateTable(
                "dbo.IdolStory",
                c => new
                    {
                        StoryID = c.Int(nullable: false, identity: true),
                        StoryTimeline = c.String(nullable: false, maxLength: 100),
                        StoryContent = c.String(nullable: false),
                        IdolID = c.Guid(nullable: false),
                        CreatedByID = c.Guid(nullable: false),
                        CreatedDateTime = c.DateTime(nullable: false),
                        LastModifiedByID = c.Guid(nullable: false),
                        LastModifiedDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.StoryID)
                .ForeignKey("dbo.Idol", t => t.IdolID, cascadeDelete: true)
                .Index(t => t.IdolID);
            
            CreateTable(
                "dbo.IdolVideo",
                c => new
                    {
                        VideoID = c.Int(nullable: false, identity: true),
                        VideoTitle = c.String(nullable: false, maxLength: 100),
                        VideoDesc = c.String(nullable: false, maxLength: 50),
                        VideoLink = c.String(nullable: false),
                        IdolID = c.Guid(nullable: false),
                        CreatedByID = c.Guid(nullable: false),
                        CreatedDateTime = c.DateTime(nullable: false),
                        LastModifiedByID = c.Guid(nullable: false),
                        LastModifiedDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.VideoID)
                .ForeignKey("dbo.Idol", t => t.IdolID, cascadeDelete: true)
                .Index(t => t.IdolID);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.IdolVideo", "IdolID", "dbo.Idol");
            DropForeignKey("dbo.IdolStory", "IdolID", "dbo.Idol");
            DropForeignKey("dbo.IdolImage", "IdolID", "dbo.Idol");
            DropForeignKey("dbo.IdolForumPost", "PostTypeID", "dbo.IdolForumPostType");
            DropForeignKey("dbo.IdolForumPostReaction", "ReactionTypeID", "dbo.ReactionType");
            DropForeignKey("dbo.IdolForumPostCommentReplyReaction", "ReactionTypeID", "dbo.ReactionType");
            DropForeignKey("dbo.IdolForumPostCommentReplyReaction", "ReplyID", "dbo.IdolForumPostCommentReply");
            DropForeignKey("dbo.IdolForumPostCommentReply", "CommentID", "dbo.IdolForumPostComment");
            DropForeignKey("dbo.IdolForumPostCommentReaction", "ReactionTypeID", "dbo.ReactionType");
            DropForeignKey("dbo.IdolForumPostCommentReaction", "CommentID", "dbo.IdolForumPostComment");
            DropForeignKey("dbo.IdolForumPostReaction", "PostID", "dbo.IdolForumPost");
            DropForeignKey("dbo.IdolForumPostImage", "PostID", "dbo.IdolForumPost");
            DropForeignKey("dbo.IdolForumPost", "IdolID", "dbo.Idol");
            DropForeignKey("dbo.Idol", "BraSizeID", "dbo.Bra");
            DropForeignKey("dbo.Idol", "BoobStatusID", "dbo.BoobStatus");
            DropForeignKey("dbo.Idol", "BodyID", "dbo.Body");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.IdolVideo", new[] { "IdolID" });
            DropIndex("dbo.IdolStory", new[] { "IdolID" });
            DropIndex("dbo.IdolImage", new[] { "IdolID" });
            DropIndex("dbo.IdolForumPostCommentReaction", new[] { "CommentID" });
            DropIndex("dbo.IdolForumPostCommentReaction", new[] { "ReactionTypeID" });
            DropIndex("dbo.IdolForumPostCommentReply", new[] { "CommentID" });
            DropIndex("dbo.IdolForumPostCommentReplyReaction", new[] { "ReplyID" });
            DropIndex("dbo.IdolForumPostCommentReplyReaction", new[] { "ReactionTypeID" });
            DropIndex("dbo.IdolForumPostReaction", new[] { "PostID" });
            DropIndex("dbo.IdolForumPostReaction", new[] { "ReactionTypeID" });
            DropIndex("dbo.IdolForumPostImage", new[] { "PostID" });
            DropIndex("dbo.IdolForumPost", new[] { "IdolID" });
            DropIndex("dbo.IdolForumPost", new[] { "PostTypeID" });
            DropIndex("dbo.Idol", new[] { "BoobStatusID" });
            DropIndex("dbo.Idol", new[] { "BraSizeID" });
            DropIndex("dbo.Idol", new[] { "BodyID" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.IdolVideo");
            DropTable("dbo.IdolStory");
            DropTable("dbo.IdolImage");
            DropTable("dbo.IdolForumPostType");
            DropTable("dbo.IdolForumPostCommentReaction");
            DropTable("dbo.IdolForumPostComment");
            DropTable("dbo.IdolForumPostCommentReply");
            DropTable("dbo.IdolForumPostCommentReplyReaction");
            DropTable("dbo.ReactionType");
            DropTable("dbo.IdolForumPostReaction");
            DropTable("dbo.IdolForumPostImage");
            DropTable("dbo.IdolForumPost");
            DropTable("dbo.Bra");
            DropTable("dbo.BoobStatus");
            DropTable("dbo.Idol");
            DropTable("dbo.Body");
        }
    }
}
