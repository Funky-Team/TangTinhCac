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
    public class IdolForumPostTypeService : IIdolForumPostTypeService
    {
        private readonly ApplicationDbContext _db;
        public IdolForumPostTypeService(IDBFactory dBFactoryService)
        {
            _db = dBFactoryService.Init();
        }

        public bool CreateNewIdolForumPostType(IdolForumPostTypeViewModel model, string userId)
        {
            try
            {
                _db.IdolForumPostTypes.Add(new IdolForumPostType
                {
                    PostTypeDesc = model.PostTypeDesc,
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

        public bool DeleteIdolForumPostType(int PostTypeID)
        {
            try
            {
                _db.IdolForumPostTypes.Remove(GetIdolForumPostTypeByPostTypeID(PostTypeID));
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<IdolForumPostType> GetAllIdolForumPostType()
        {
            try
            {
                return _db.IdolForumPostTypes.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IdolForumPostType GetIdolForumPostTypeByPostTypeID(int PostTypeID)
        {
            try
            {
                return _db.IdolForumPostTypes.Find(PostTypeID) ?? new IdolForumPostType();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool UpdateIdolForumPostType(IdolForumPostTypeViewModel model, string userId)
        {
            try
            {
                var postType = GetIdolForumPostTypeByPostTypeID(model.PostTypeID);
                postType.PostTypeDesc = model.PostTypeDesc;
                postType.LastModifiedByID = userId;
                postType.LastModifiedDateTime = DateTime.Now;
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