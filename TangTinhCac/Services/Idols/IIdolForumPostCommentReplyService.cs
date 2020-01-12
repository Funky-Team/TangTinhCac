using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TangTinhCac.Models.EntityModels.Idols;
using TangTinhCac.Models.ViewModels.Idols;

namespace TangTinhCac.Services.Idols
{
    public interface IIdolForumPostCommentReplyService 
    {
        IEnumerable<IdolForumPostCommentReply> GetAllIdolForumPostCommentReply();
        IdolForumPostCommentReply GetIdolForumPostCommentReplyByReplyID(int ReplyID);
        bool CreateNewIdolForumPostCommentReply(IdolForumPostCommentReplyViewModel model, string userId);
        bool UpdateIdolForumPostCommentReply(IdolForumPostCommentReplyViewModel model, string userId);
        bool DeleteIdolForumPostCommentReply(int ReplyID);
    }
}
