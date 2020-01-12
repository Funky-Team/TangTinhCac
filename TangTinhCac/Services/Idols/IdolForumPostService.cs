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
    public class IdolForumPostService : IIdolForumPostService
    {
        private readonly ApplicationDbContext _db;
        public IdolForumPostService(IDBFactory dBFactoryService)
        {
            _db = dBFactoryService.Init();
        }
        public bool CreateNewIdolForumPost(IdolForumPostViewModel model, string userId)
        {
            try
            {
                _db.IdolForumPosts.Add(new IdolForumPost
                {
                    PostContent = model.PostContent,
                    PostTypeID = model.PostTypeID,
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

        public bool DeleteIdolForumPost(int PostID)
        {
            try
            {
                _db.IdolForumPosts.Remove(GetIdolForumPostByPostID(PostID));
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<IdolForumPost> GetAllIdolForumPost()
        {
            try
            {
                return _db.IdolForumPosts.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IdolForumPost GetIdolForumPostByPostID(int PostID)
        {
            try
            {
                return _db.IdolForumPosts.Find(PostID) ?? new IdolForumPost();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool UpdateIdolForumPost(IdolForumPostViewModel model, string userId)
        {
            try
            {
                var post = GetIdolForumPostByPostID(model.PostID);
                post.PostContent = model.PostContent;
                post.PostTypeID = model.PostTypeID;
                post.IdolID = model.IdolID;
                post.LastModifiedByID = userId;
                post.LastModifiedDateTime = DateTime.Now;
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