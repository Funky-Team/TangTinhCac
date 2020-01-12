using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TangTinhCac.Models.EntityModels.Idols;
using TangTinhCac.Models.ViewModels.Idols;

namespace TangTinhCac.Services.Idols
{
    public interface IIdolForumPostCommentReactionService
    {
        IEnumerable<IdolForumPostCommentReaction> GetAllIdolForumPostCommentReaction();
        IdolForumPostCommentReaction GetIdolForumPostCommentReactionByReactionID(int ReactionID);
        bool CreateNewIdolForumPostCommentReaction(IdolForumPostCommentReactionViewModel model, string userId);
        bool UpdateIdolForumPostCommentReaction(IdolForumPostCommentReactionViewModel model, string userId);
        bool DeleteIdolForumPostCommentReaction(int ReactionID); 
    }
}
