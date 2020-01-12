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
    public class IdolForumPostImageService : IIdolForumPostImageService
    {
        private readonly ApplicationDbContext _db;
        public IdolForumPostImageService(IDBFactory dBFactoryService)
        {
            _db = dBFactoryService.Init();
        }
        public bool CreateNewIdolForumPostImage(IdolForumPostImageViewModel model, string userId)
        {
            try
            {
                _db.IdolForumPostImages.Add(new IdolForumPostImage
                {
                    ImageLink = model.ImageLink,
                    PostID = model.PostID,
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

        public bool DeleteIdolForumPostImage(int ImageID)
        {
            try
            {
                _db.IdolForumPostImages.Remove(GetIdolForumPostImageByImageID(ImageID));
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<IdolForumPostImage> GetAllIdolForumPostImage()
        {
            try
            {
                return _db.IdolForumPostImages.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IdolForumPostImage GetIdolForumPostImageByImageID(int ImageID)
        {
            try
            {
                return _db.IdolForumPostImages.Find(ImageID) ?? new IdolForumPostImage();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool UpdateIdolForumPostImage(IdolForumPostImageViewModel model, string userId)
        {
            try
            {
                var image = GetIdolForumPostImageByImageID(model.ImageID);
                image.ImageLink = model.ImageLink;
                image.PostID = model.PostID;
                image.LastModifiedByID = userId;
                image.LastModifiedDateTime = DateTime.Now;
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