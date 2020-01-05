using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TangTinhCac.Models.EntityModels.Idols;
using TangTinhCac.Models.ViewModels.Idols;

namespace TangTinhCac.Services.Idols
{
    public interface IBoobStatusService
    {
        IEnumerable<BoobStatus> GetAllBoobStatus();
        BoobStatus GetBoobStatusByID(int BoobStatusID);
        bool CreateBoobStatus(BoobStatusViewModel model, string userId);
        bool UpdateBooStatus(BoobStatusViewModel mode, string userId);
        bool DeleteBoobStatus(int BoobStatusID); 
    }
}