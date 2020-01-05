using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TangTinhCac.Models.ViewModels.Idols
{
    public class BodyViewModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BodyID { get; set; }
        [Required]
        [StringLength(50)]
        public string BodyDesc { get; set; }
        [MaxLength(128)]
        public string CreatedByID { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        [MaxLength(128)]
        public string LastModifiedByID { get; set; }
        public DateTime? LastModifiedDateTime { get; set; }
    }
}