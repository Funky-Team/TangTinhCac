using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TangTinhCac.Models.EntityModels.Idol
{
    [Table("IdolForumPost")]
    public class IdolForumPost
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PostID { get; set; }
        [Required]
        [StringLength(100)]
        public string PostContent { get; set; }
        [Required]
        public int PostTypeID { get; set; }
        [Required]
        [ForeignKey("Idol")]
        public Guid IdolID { get; set; }
        [Required]
        public Guid CreatedByID { get; set; }
        [Required]
        public DateTime CreatedDateTime { get; set; }
        [Required]
        public Guid LastModifiedByID { get; set; }
        [Required]
        public DateTime LastModifiedDateTime { get; set; }

        public virtual Idol Idol { get; set; }
        public virtual ICollection<IdolForumPostReaction> IdolForumPostReactions { get; set; }
        public virtual ICollection<IdolForumPostImage> IdolForumPostImages { get; set; }
        public virtual IdolForumPostType IdolForumPostType { get; set; }
    }
}