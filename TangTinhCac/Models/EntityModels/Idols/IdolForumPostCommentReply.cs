using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TangTinhCac.Models.EntityModels.Idols
{
    [Table("IdolForumPostCommentReply")]
    public class IdolForumPostCommentReply
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReplyID { get; set; }
        [Required]
        public string ReplyContent { get; set; }
        //[Required]
        //public string UserId { get; set; }
        [Required]
        [ForeignKey("IdolForumPostComment")]
        public int CommentID { get; set; }
        [MaxLength(128)]
        public string CreatedByID { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        [MaxLength(128)]
        public string LastModifiedByID { get; set; }
        public DateTime? LastModifiedDateTime { get; set; }
        //[ForeignKey("UserId")]
        //public virtual ApplicationUser User { get; set; }
        public virtual IdolForumPostComment IdolForumPostComment { get; set; }
        public virtual ICollection<IdolForumPostCommentReplyReaction> IdolForumPostCommentReplyReactions { get; set; }

    } 
}