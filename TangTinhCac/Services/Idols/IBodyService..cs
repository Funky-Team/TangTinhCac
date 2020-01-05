using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TangTinhCac.Models.EntityModels.Idols;
using TangTinhCac.Models.ViewModels.Idols;

namespace TangTinhCac.Services.Idols
{
    public interface IBodyService
    {
        IEnumerable<Body> GetAllBody();
        Body GetBodyByBodyID(int BodyID);
        bool CreateNewBody(BodyViewModel model, string userId);
        bool UpdateBody(BodyViewModel model, string userId);
        bool DeleteBody(int BodyID);
    }
}