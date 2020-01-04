using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TangTinhCac.Models.ViewModels.Idols
{
    public class IdolViewModel
    {
        public Guid IdolID { get; set; }
        [Required]
        [StringLength(50)]
        public string IdolName { get; set; }
        [StringLength(50)]
        public string IdolOtherName { get; set; }
        public DateTime IdolBirthday { get; set; }
        [StringLength(3)]
        public string IdolCountryCD { get; set; }
        [Range(0, 3)]
        public int? IdolHeight { get; set; }//cm
        [Range(0, 3)]
        public int? IdolWeight { get; set; }//kg
        public int? BodyID { get; set; }
        [StringLength(20)]
        public string IdolMeasurements { get; set; }
        public int? BraSizeID { get; set; }
        public int? BoobStatusID { get; set; }
        [MinLength(128), MaxLength(128)]
        public string CreatedByID { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        [MinLength(128), MaxLength(128)]
        public string LastModifiedByID { get; set; }
        public DateTime? LastModifiedDateTime { get; set; }


    }
}