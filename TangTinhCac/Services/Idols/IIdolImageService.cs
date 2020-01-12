using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TangTinhCac.Models.EntityModels.Idols;
using TangTinhCac.Models.ViewModels.Idols;

namespace TangTinhCac.Services.Idols
{
    public interface IIdolImageService
    {
        IEnumerable<IdolImage> GetAllIdolImages();
        IdolImage GetIdolImageByImageID(int imageID);
        bool CreateNewIdolImage(IdolImageViewModel model, string userId);
        bool UpdateIdolImage(IdolImageViewModel model, string userId);
        bool DeleteIdolImage(int imageID);
    }
}
