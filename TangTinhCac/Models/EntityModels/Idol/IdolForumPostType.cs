using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TangTinhCac.Models.EntityModels.Idol
{
    public class IdolForumPostType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PostTypeID { get; set; }
        [Required]
        public string PostTypeDesc { get; set; }
        [Required]
        public Guid CreatedByID { get; set; }
        [Required]
        public DateTime CreatedDateTime { get; set; }
        [Required]
        public Guid LastModifiedByID { get; set; }
        [Required]
        public DateTime LastModifiedDateTime { get; set; }

        public virtual ICollection<IdolForumPost> IdolForumPosts { get; set; }
    }
}