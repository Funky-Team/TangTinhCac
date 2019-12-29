using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TangTinhCac.Models.EntityModels.Idol
{
    public class Idol
    {
        public Guid IdolID { get; set; }
        public string IdolName { get; set; }
        public string IdolOtherName { get; set; }
        public DateTime IdolBirthday { get; set; }
        public string IdolCountryCD { get; set; }
        public int IdolHeight { get; set; }
        public int IdolWeight { get; set; }
        public int BodyID { get; set; }
        public string IdolMeasurements { get; set; }
        public int BraSizeID { get; set; }
        public int BoobStatusID { get; set; }
        public Guid CreatedByID { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public Guid LastModifiedByID { get; set; }
        public DateTime LastModifiedDateTime { get; set; } 
    }
}