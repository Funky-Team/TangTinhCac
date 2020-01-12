using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TangTinhCac.Models.ViewModels.Idols
{
    public class IdolVideoViewModel
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
        [MaxLength(128)]
        public string CreatedByID { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        [MaxLength(128)]
        public string LastModifiedByID { get; set; }
        public DateTime? LastModifiedDateTime { get; set; }
    }
}