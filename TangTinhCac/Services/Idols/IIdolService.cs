using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TangTinhCac.Models.EntityModels.Idols;
using TangTinhCac.Models.ViewModels.Idols;

namespace TangTinhCac.Services.Idols
{
    public interface IIdolService
    {
        IEnumerable<Idol> GetAllIdols();
        Idol GetIdolByIdolID(Guid idolID);
        bool CreateNewIdol(IdolViewModel model, string userId);
        bool UpdateIdol(IdolViewModel model, string userId);
        bool DeleteIdol(Guid idolID);
    }
}
