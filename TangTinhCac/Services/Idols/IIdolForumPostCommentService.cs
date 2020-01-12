using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TangTinhCac.Models.EntityModels.Idols;
using TangTinhCac.Models.ViewModels.Idols;

namespace TangTinhCac.Services.Idols
{
    public interface IIdolForumPostCommentService
    {
        IEnumerable<IdolForumPostComment> GetAllIdolForumPostComment();
        IdolForumPostComment GetIdolForumPostCommentByCommentID(int CommentID);
        bool CreateNewIdolForumPostComment(IdolForumPostCommentViewModel model, string userId);
        bool UpdateIdolForumPostComment(IdolForumPostCommentViewModel model, string userId);
        bool DeleteIdolForumPostComment(int CommentID); 
    }
}
