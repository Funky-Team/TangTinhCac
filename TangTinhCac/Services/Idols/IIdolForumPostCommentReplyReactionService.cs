using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TangTinhCac.Models.EntityModels.Idols;
using TangTinhCac.Models.ViewModels.Idols;

namespace TangTinhCac.Services.Idols
{
    public interface IIdolForumPostCommentReplyReactionService
    {
        IEnumerable<IdolForumPostCommentReplyReaction> GetAllIdolForumPostCommentReplyReaction();
        IdolForumPostCommentReplyReaction GetIdolForumPostCommentReplyReactionByReactionID(int ReactionID);
        bool CreateNewIdolForumPostCommentReplyReaction(IdolForumPostCommentReplyReactionViewModel model, string userId);
        bool UpdateIdolForumPostCommentReplyReaction(IdolForumPostCommentReplyReactionViewModel model, string userId);
        bool DeleteIdolForumPostCommentReplyReaction(int ReactionID);
    }
}
