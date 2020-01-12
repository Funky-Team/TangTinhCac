using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TangTinhCac.Models.EntityModels.Idols;
using TangTinhCac.Models.ViewModels.Idols;

namespace TangTinhCac.Services.Idols
{
    public interface IIdolForumPostImageService
    {
        IEnumerable<IdolForumPostImage> GetAllIdolForumPostImage();
        IdolForumPostImage GetIdolForumPostImageByImageID(int ImageID);
        bool CreateNewIdolForumPostImage(IdolForumPostImageViewModel model, string userId);
        bool UpdateIdolForumPostImage(IdolForumPostImageViewModel model, string userId);
        bool DeleteIdolForumPostImage(int PostID);
    }
}
