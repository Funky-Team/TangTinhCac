using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TangTinhCac.Models.EntityModels.Idols
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
        [MaxLength(128)]
        public string CreatedByID { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        [MaxLength(128)]
        public string LastModifiedByID { get; set; }
        public DateTime? LastModifiedDateTime { get; set; }

        //[ForeignKey("UserId")]
        //public virtual ApplicationUser User { get; set; } 
        public virtual ICollection<IdolForumPostCommentReaction> IdolForumPostCommentReactions { get; set; }
        public virtual ICollection<IdolForumPostCommentReply> IdolForumPostCommentReplies { get; set; }

    }
}