using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TangTinhCac.Models.EntityModels.Idols;
using TangTinhCac.Models.ViewModels.Idols;

namespace TangTinhCac.Services.Idols
{
    public interface IIdolForumPostService
    {
        IEnumerable<IdolForumPost> GetAllIdolForumPost();
        IdolForumPost GetIdolForumPostByPostID(int PostID); 
        bool CreateNewIdolForumPost(IdolForumPostViewModel model, string userId);
        bool UpdateIdolForumPost(IdolForumPostViewModel model, string userId);
        bool DeleteIdolForumPost(int PostID);
    }
}
