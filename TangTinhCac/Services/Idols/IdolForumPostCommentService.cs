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
    public class IdolForumPostCommentService : IIdolForumPostCommentService
    {
        private readonly ApplicationDbContext _db;
        public IdolForumPostCommentService(IDBFactory dBFactoryService)
        {
            _db = dBFactoryService.Init();
        }
        public bool CreateNewIdolForumPostComment(IdolForumPostCommentViewModel model, string userId)
        {
            try
            {
                _db.IdolForumPostComments.Add(new IdolForumPostComment
                {
                    CommentContent = model.CommentContent,
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

        public bool DeleteIdolForumPostComment(int CommentID)
        {
            try
            {
                _db.IdolForumPostComments.Remove(GetIdolForumPostCommentByCommentID(CommentID));
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<IdolForumPostComment> GetAllIdolForumPostComment()
        {
            try
            {
                return _db.IdolForumPostComments.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IdolForumPostComment GetIdolForumPostCommentByCommentID(int CommentID)
        {
            try
            {
                return _db.IdolForumPostComments.Find(CommentID) ?? new IdolForumPostComment();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool UpdateIdolForumPostComment(IdolForumPostCommentViewModel model, string userId)
        {
            try
            {
                var comment = GetIdolForumPostCommentByCommentID(model.CommentID);
                comment.CommentContent = model.CommentContent;
                comment.LastModifiedByID = userId;
                comment.LastModifiedDateTime = DateTime.Now;
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