﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TangTinhCac.Models.EntityModels.Idol
{
    [Table("ReactionType")]
    public class ReactionType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReactionTypeID { get; set; }
        [Required]
        public string ReactionTypeDesc { get; set; }
        [Required]
        public Guid CreatedByID { get; set; }
        [Required]
        public DateTime CreatedDateTime { get; set; }
        [Required]
        public Guid LastModifiedByID { get; set; }
        [Required]
        public DateTime LastModifiedDateTime { get; set; }

        public virtual ICollection<IdolForumPostReaction> IdolForumPostReactions { get; set; }
        public virtual ICollection<IdolForumPostCommentReplyReaction> IdolForumPostCommentReplyReactions { get; set; }

    }
}