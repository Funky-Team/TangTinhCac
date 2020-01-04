using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TangTinhCac.Models.EntityModels.Idols
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
        [MaxLength(128)]
        public string CreatedByID { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        [MaxLength(128)]
        public string LastModifiedByID { get; set; }
        public DateTime? LastModifiedDateTime { get; set; }

        public virtual Idol Idol { get; set; }
        public virtual ICollection<IdolForumPostReaction> IdolForumPostReactions { get; set; }
        public virtual ICollection<IdolForumPostImage> IdolForumPostImages { get; set; }
        public virtual IdolForumPostType IdolForumPostType { get; set; }
    }
}