using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TangTinhCac.Models.EntityModels.Idols
{
    [Table("IdolForumPostType")]
    public class IdolForumPostType
    {
        //[Key, Column(Order = 0)]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int PostTypeID { get; set; }
        [Key]
        [StringLength(3)]
        public string PostTypeCD { get; set; }
        [Required]
        public string PostTypeDesc { get; set; }
        [MaxLength(128)]
        public string CreatedByID { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        [MaxLength(128)]
        public string LastModifiedByID { get; set; }
        public DateTime? LastModifiedDateTime { get; set; }

        public virtual ICollection<IdolForumPost> IdolForumPosts { get; set; }
    }
}