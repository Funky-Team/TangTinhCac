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
    public class BodyService : IBodyService
    {
        private readonly ApplicationDbContext _db;
        public BodyService(IDBFactory dbFactoryService)
        {
            _db = dbFactoryService.Init();
        }
        public bool CreateNewBody(BodyViewModel model, string userId)
        {
            try
            {
                _db.Bodies.Add(new Body
                {
                    BodyDesc = model.BodyDesc,
                    CreatedByID = userId,
                    CreatedDateTime = DateTime.Now,
                });
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool DeleteBody(int BodyID)
        {
            try
            {
                _db.Bodies.Remove(GetBodyByBodyID(BodyID));
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<Body> GetAllBody()
        {
            try
            {
                return _db.Bodies.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Body GetBodyByBodyID(int BodyID)
        {
            try
            {
                return _db.Bodies.Find(BodyID) ?? new Body();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool UpdateBody(BodyViewModel model,string userId)
        {
            try
            {
                var body = GetBodyByBodyID(model.BodyID);
                body.BodyDesc = model.BodyDesc;
                body.CreatedByID = userId;
                body.CreatedDateTime = DateTime.Now;
                body.LastModifiedByID = userId;
                body.LastModifiedDateTime = DateTime.Now;
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
