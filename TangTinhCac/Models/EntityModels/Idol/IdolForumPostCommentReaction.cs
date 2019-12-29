﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TangTinhCac.Models.EntityModels.Idol
{
    public class IdolForumPostCommentReaction
    {
        public int ReactionID { get; set; }
        public int ReactionTypeID { get; set; }
        public Guid UserID { get; set; }
        public int CommentID { get; set; } 
        public Guid CreatedByID { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public Guid LastModifiedByID { get; set; }
        public DateTime LastModifiedDateTime { get; set; }
    }
}