﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TangTinhCac.Models.EntityModels.Idol
{
    public class Body
    {
        public int BodyID { get; set; }
        public string BodyDesc { get; set; }
        public Guid CreatedByID { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public Guid LastModifiedByID { get; set; }
        public DateTime LastModifiedDateTime { get; set; }
    }
}