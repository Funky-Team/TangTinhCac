using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TangTinhCac.Models.EntityModels.Idols
{
    [Table("Idol")]
    public class Idol
    {
        [Key]
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
        [ForeignKey("Body")]
        public int? BodyID { get; set; }
        [StringLength(20)]
        public string IdolMeasurements { get; set; }
        [ForeignKey("Bra")]
        public int? BraSizeID { get; set; }
        [ForeignKey("BoobStatus")]
        public int? BoobStatusID { get; set; }
        [MaxLength(128)]
        public string CreatedByID { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        [MaxLength(128)]
        public string LastModifiedByID { get; set; }
        public DateTime? LastModifiedDateTime { get; set; }


        public virtual Body Body { get; set; }
        public virtual Bra Bra { get; set; }
        public virtual BoobStatus BoobStatus { get; set; }
        public virtual ICollection<IdolImage> IdolImages { get; set; }
        public virtual ICollection<IdolStory> IdolStories { get; set; }
        public virtual ICollection<IdolVideo> IdolVideos { get; set; }
        public virtual ICollection<IdolForumPost> IdolForumPosts { get; set; }

    }
}