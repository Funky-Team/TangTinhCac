using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TangTinhCac.Models;
using TangTinhCac.Models.EntityModels.Idols;
using TangTinhCac.Models.ViewModels.Idols;
using TangTinhCac.Services.DBFactory;

namespace TangTinhCac.Services.Idols
{
    public class BoobStatusService : IBoobStatusService
    {
        private readonly ApplicationDbContext _db;
        public BoobStatusService(IDBFactory dbFactoryService)
        {
            _db = dbFactoryService.Init();
        }

        public bool CreateBoobStatus(BoobStatusViewModel model, string userId)
        {
            try
            {
                _db.BoobStatuses.Add(new BoobStatus
                {
                    BoobStatusDesc = model.BoobStatusDesc,
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

        public bool DeleteBoobStatus(int BoobStatusID)
        {
            try
            {
                _db.BoobStatuses.Remove(GetBoobStatusByID(BoobStatusID));
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<BoobStatus> GetAllBoobStatus()
        {
            try
            {
                return _db.BoobStatuses.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public BoobStatus GetBoobStatusByID(int BoobStatusID)
        {
            try
            {
                return _db.BoobStatuses.Find(BoobStatusID) ?? new BoobStatus();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool UpdateBooStatus(BoobStatusViewModel mode, string userId)
        {
            try
            { 
                var boobStatus = GetBoobStatusByID(mode.BoobStatusID);
                boobStatus.BoobStatusDesc = mode.BoobStatusDesc;
                boobStatus.LastModifiedByID = userId;
                boobStatus.LastModifiedDateTime = DateTime.Now;
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