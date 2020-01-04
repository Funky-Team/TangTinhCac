using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TangTinhCac.Models.EntityModels.Idols
{
    [Table("IdolStory")]
    public class IdolStory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StoryID { get; set; }
        [Required]
        [StringLength(100)]
        public string StoryTimeline { get; set; }
        [Required]
        public string StoryContent { get; set; }
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
    }
}