using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TangTinhCac.Models.EntityModels.Idols;
using TangTinhCac.Models.ViewModels.Idols;

namespace TangTinhCac.Services.Idols
{
    public interface IIdolForumPostTypeService
    {
        IEnumerable<IdolForumPostType> GetAllIdolForumPostType();
        IdolForumPostType GetIdolForumPostTypeByPostTypeID(int PostTypeID);
        bool CreateNewIdolForumPostType(IdolForumPostTypeViewModel model, string userId);
        bool UpdateIdolForumPostType(IdolForumPostTypeViewModel model, string userId);
        bool DeleteIdolForumPostType(int PostTypeID);
    }
}
