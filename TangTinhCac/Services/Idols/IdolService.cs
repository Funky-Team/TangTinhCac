using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TangTinhCac.Models;
using TangTinhCac.Models.EntityModels.Idols;
using TangTinhCac.Models.ViewModels.Idols;
using TangTinhCac.Services.DBFactory;
using TangTinhCac.Services.Idols;

namespace TangTinhCac.Services.Idols
{
    public class IdolService : IIdolService
    {
        private readonly ApplicationDbContext _db;

        public IdolService(IDBFactory dbFactoryService)
        {
            _db = dbFactoryService.Init();
        }

        public bool CreateNewIdol(IdolViewModel model, string userId)
        {
            try
            {
                _db.Idols.Add(new Idol
                {
                    IdolID = Guid.NewGuid(),
                    IdolName = model.IdolName,
                    IdolOtherName = model.IdolOtherName,
                    IdolBirthday = model.IdolBirthday,
                    IdolCountryCD = model.IdolCountryCD,
                    IdolHeight = model.IdolHeight,
                    IdolWeight = model.IdolWeight,
                    BodyID = model.BodyID,
                    IdolMeasurements = model.IdolMeasurements,
                    BraSizeID = model.BraSizeID,
                    BoobStatusID = model.BoobStatusID,
                    CreatedByID = userId,
                    CreatedDateTime = DateTime.Now
                });
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteIdol(Guid idolID)
        {
            try
            {
                _db.Idols.Remove(GetIdolByIdolID(idolID));
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Idol> GetAllIdols()
        {
            try
            {
                return _db.Idols.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Idol GetIdolByIdolID(Guid idolID)
        {
            try
            {
                return _db.Idols.Find(idolID);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool UpdateIdol(IdolViewModel model, string userId)
        {
            try
            {
                var idol = GetIdolByIdolID(model.IdolID);
                idol.IdolName = model.IdolName;
                idol.IdolOtherName = model.IdolOtherName;
                idol.IdolBirthday = model.IdolBirthday;
                idol.IdolCountryCD = model.IdolCountryCD;
                idol.IdolHeight = model.IdolHeight;
                idol.IdolWeight = model.IdolWeight;
                idol.BodyID = model.BodyID;
                idol.IdolMeasurements = model.IdolMeasurements;
                idol.BraSizeID = model.BraSizeID;
                idol.BoobStatusID = model.BoobStatusID;
                idol.LastModifiedByID = userId;
                idol.LastModifiedDateTime = DateTime.Now;
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}