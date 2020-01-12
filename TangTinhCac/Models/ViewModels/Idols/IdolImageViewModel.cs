using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TangTinhCac.Models.ViewModels.Idols
{
    public class IdolImageViewModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ImageID { get; set; }
        [Required]
        public string ImageLink { get; set; }
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