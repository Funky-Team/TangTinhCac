using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TangTinhCac.Models.EntityModels.Idol
{
    public class IdolForumPostReaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReactionID { get; set; }
        [Required]
        [ForeignKey("ReactionType")]
        public int ReactionTypeID { get; set; }
        [Required]
        public Guid UserID { get; set; }
        [Required]
        public int PostID { get; set; }
        [Required]
        public Guid CreatedByID { get; set; }
        [Required]
        public DateTime CreatedDateTime { get; set; }
        [Required]
        public Guid LastModifiedByID { get; set; }
        [Required]
        public DateTime LastModifiedDateTime { get; set; }

        public virtual ReactionType ReactionType { get; set; }
        [ForeignKey("UserID")]
        public virtual ApplicationUser User { get; set; }
        public virtual IdolForumPost IdolForumPost { get; set; }
    }
}