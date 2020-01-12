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
    public class IdolImageService : IIdolImageService
    {
        private readonly ApplicationDbContext _db;

        public IdolImageService(IDBFactory dbFactoryService)
        {
            _db = dbFactoryService.Init();
        }

        public bool CreateNewIdolImage(IdolImageViewModel model, string userId)
        {
            try
            {
                _db.IdolImages.Add(new IdolImage
                {
                    ImageLink = model.ImageLink,
                    IdolID = model.IdolID,
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

        public bool DeleteIdolImage(int imageID)
        {
            try
            {
                _db.IdolImages.Remove(GetIdolImageByImageID(imageID));
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<IdolImage> GetAllIdolImages()
        {
            try
            {
                return _db.IdolImages.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IdolImage GetIdolImageByImageID(int imageID)
        {
            try
            {
                return _db.IdolImages.Find(imageID) ?? new IdolImage();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool UpdateIdolImage(IdolImageViewModel model, string userId)
        {
            try
            {
                var idolImage = GetIdolImageByImageID(model.ImageID);
                idolImage.ImageLink = model.ImageLink;
                idolImage.IdolID = model.IdolID;
                idolImage.LastModifiedDateTime = DateTime.Now;
                idolImage.LastModifiedByID = userId;
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