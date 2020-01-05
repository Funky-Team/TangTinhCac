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
    public class BraService : IBraService
    {
        private readonly ApplicationDbContext _db;
        public BraService(IDBFactory dBFactoryService)
        {
            _db = dBFactoryService.Init();
        }
        public bool CreateNewBra(BraViewModel model, string userId)
        {
            try
            {
                _db.Bras.Add(new Bra
                {
                    BraDesc = model.BraDesc,
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

        public bool DeleteBra(int BraID)
        {
            try
            {
                _db.Bras.Remove(GetBraByBraID(BraID));
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<Bra> GetAllBra()
        {
            return _db.Bras.ToList();
        }

        public Bra GetBraByBraID(int BraID)
        {
            return _db.Bras.Find(BraID);
        }

        public bool UpdateBra(BraViewModel model, string userId)
        {
            try
            {
                var bra = GetBraByBraID(model.BraID);
                bra.BraDesc = model.BraDesc;
                bra.LastModifiedByID = userId;
                bra.LastModifiedDateTime = DateTime.Now;
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