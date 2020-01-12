using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TangTinhCac.Models.EntityModels.Idols;
using TangTinhCac.Models.ViewModels.Idols;

namespace TangTinhCac.Services.Idols
{
    public interface IIdolVideoService
    {
        IEnumerable<IdolVideo> GetAllIdolVideos();
        IdolVideo GetIdolVideoByVideoID(int videoID);
        bool CreateNewIdolVideo(IdolVideoViewModel model, string userId);
        bool UpdateIdolVideo(IdolVideoViewModel model, string userId);
        bool DeleteIdolVideo(int videoID);
    }
}
