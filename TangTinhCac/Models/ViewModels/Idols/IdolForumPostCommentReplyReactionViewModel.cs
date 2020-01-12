﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TangTinhCac.Models.ViewModels.Idols
{
    public class IdolForumPostCommentReplyReactionViewModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReactionID { get; set; }
        [Required]
        [ForeignKey("ReactionType")]
        public int ReactionTypeID { get; set; }
        //[Required]
        //public string UserId { get; set; }
        [Required]
        public int ReplyID { get; set; }
        [MaxLength(128)]
        public string CreatedByID { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        [MaxLength(128)]
        public string LastModifiedByID { get; set; }
        public DateTime? LastModifiedDateTime { get; set; }
    }
}