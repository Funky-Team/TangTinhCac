using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TangTinhCac.Models.EntityModels.Idols;
using TangTinhCac.Models.ViewModels.Idols;

namespace TangTinhCac.Services.Idols
{
    public interface IBraService
    {
        IEnumerable<Bra> GetAllBra();
        Bra GetBraByBraID(int BraID);
        bool CreateNewBra(BraViewModel model, string userId);
        bool UpdateBra(BraViewModel model, string userId);
        bool DeleteBra(int BraID);
    }
}