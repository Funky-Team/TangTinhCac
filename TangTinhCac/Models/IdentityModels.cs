using System.Collections.Generic;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using TangTinhCac.Models.EntityModels.Idols;

namespace TangTinhCac.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        //public virtual ICollection<IdolForumPostReaction> IdolForumPostReactions { get; set; }
        //public virtual ICollection<IdolForumPostComment> IdolForumPostComments { get; set; }
        //public virtual ICollection<IdolForumPostCommentReaction> IdolForumPostCommentReactions { get; set; }
        //public virtual ICollection<IdolForumPostCommentReply> IdolForumPostCommentReplys { get; set; }
        //public virtual ICollection<IdolForumPostCommentReplyReaction> IdolForumPostCommentReplyReactions { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public virtual DbSet<Body> Bodies { get; set; }
        public virtual DbSet<BoobStatus> BoobStatuses { get; set; }
        public virtual DbSet<Bra> Bras { get; set; }
        public virtual DbSet<Idol> Idols { get; set; }
        public virtual DbSet<IdolForumPost> IdolForumPosts { get; set; }
        public virtual DbSet<IdolForumPostComment> IdolForumPostComments { get; set; }
        public virtual DbSet<IdolForumPostCommentReaction> IdolForumPostCommentReactions { get; set; }
        public virtual DbSet<IdolForumPostCommentReply> IdolForumPostCommentReplies { get; set; }
        public virtual DbSet<IdolForumPostCommentReplyReaction> IdolForumPostCommentReplyReactions { get; set; }
        public virtual DbSet<IdolForumPostImage> IdolForumPostImages { get; set; }
        public virtual DbSet<IdolForumPostReaction> IdolForumPostReactions { get; set; }
        public virtual DbSet<IdolForumPostType> IdolForumPostTypes { get; set; }
        public virtual DbSet<IdolImage> IdolImages { get; set; }
        public virtual DbSet<IdolStory> IdolStories { get; set; }
        public virtual DbSet<IdolVideo> IdolVideos { get; set; }
        public virtual DbSet<ReactionType> ReactionTypes { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //}

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}