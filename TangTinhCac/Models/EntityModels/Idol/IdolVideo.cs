using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TangTinhCac.Models.EntityModels.Idol
{
    public class IdolVideo
    {
        public int VideoID { get; set; }
        public string VideoTitle { get; set; }
        public string VideoDesc { get; set; }
        public string VideoLink { get; set; }
        public Guid IdolID { get; set; }
        public Guid CreatedByID { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public Guid LastModifiedByID { get; set; }
        public DateTime LastModifiedDateTime { get; set; }
    }
}