using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TangTinhCac.Models.EntityModels.Idol
{
    public class IdolVideo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VideoID { get; set; }
        [Required]
        [StringLength(100)]
        public string VideoTitle { get; set; }
        [Required]
        [StringLength(50)]
        public string VideoDesc { get; set; }
        [Required]
        public string VideoLink { get; set; }
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
    }
}