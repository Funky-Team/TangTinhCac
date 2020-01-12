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
    public class IdolForumPostCommentReplyService : IIdolForumPostCommentReplyService
    {
        private readonly ApplicationDbContext _db;
        public IdolForumPostCommentReplyService(IDBFactory dBFactoryService)
        {
            _db = dBFactoryService.Init();
        }
        public bool CreateNewIdolForumPostCommentReply(IdolForumPostCommentReplyViewModel model, string userId)
        {
            try
            {
                _db.IdolForumPostCommentReplies.Add(new IdolForumPostCommentReply
                {
                    ReplyContent = model.ReplyContent,
                    CommentID = model.CommentID,
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

        public bool DeleteIdolForumPostCommentReply(int ReplyID)
        {
            try
            {
                _db.IdolForumPostCommentReplies.Remove(GetIdolForumPostCommentReplyByReplyID(ReplyID));
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<IdolForumPostCommentReply> GetAllIdolForumPostCommentReply()
        {
            try
            {
                return _db.IdolForumPostCommentReplies.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IdolForumPostCommentReply GetIdolForumPostCommentReplyByReplyID(int ReplyID)
        {
            try
            {
                return _db.IdolForumPostCommentReplies.Find(ReplyID) ?? new IdolForumPostCommentReply();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool UpdateIdolForumPostCommentReply(IdolForumPostCommentReplyViewModel model, string userId)
        {
            try
            {
                var reply = GetIdolForumPostCommentReplyByReplyID(model.ReplyID);
                reply.ReplyContent = model.ReplyContent;
                reply.CommentID = model.CommentID;
                reply.LastModifiedByID = userId;
                reply.LastModifiedDateTime = DateTime.Now;
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