using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TangTinhCac.Models.EntityModels.Idol
{
    public class Body
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BodyID { get; set; }
        [Required]
        [StringLength(50)]
        public string BodyDesc { get; set; }
        [Required]
        public Guid CreatedByID { get; set; }
        [Required]
        public DateTime CreatedDateTime { get; set; }
        [Required]
        public Guid LastModifiedByID { get; set; }
        [Required]
        public DateTime LastModifiedDateTime { get; set; }

        public virtual ICollection<Idol> Idols { get; set; }
    }
}