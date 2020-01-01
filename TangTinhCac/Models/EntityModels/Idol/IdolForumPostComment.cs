using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TangTinhCac.Models.EntityModels.Idol
{
    [Table("IdolForumPostComment")]
    public class IdolForumPostComment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CommentID { get; set; }
        [Required]
        public string CommentContent { get; set; }
        //[Required]
        //public string UserId { get; set; }
        [Required]
        public Guid CreatedByID { get; set; }
        [Required]
        public DateTime CreatedDateTime { get; set; }
        [Required]
        public Guid LastModifiedByID { get; set; }
        [Required]
        public DateTime LastModifiedDateTime { get; set; }

        //[ForeignKey("UserId")]
        //public virtual ApplicationUser User { get; set; } 
        public virtual ICollection<IdolForumPostCommentReaction> IdolForumPostCommentReactions { get; set; }
        public virtual ICollection<IdolForumPostCommentReply> IdolForumPostCommentReplies { get; set; }

    }
}