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
    public class IdolForumPostCommentReactionService : IIdolForumPostCommentReactionService
    {
        private readonly ApplicationDbContext _db;
        public IdolForumPostCommentReactionService(IDBFactory dBFactoryService)
        {
            _db = dBFactoryService.Init();
        }
        public bool CreateNewIdolForumPostCommentReaction(IdolForumPostCommentReactionViewModel model, string userId)
        {
            try
            {
                _db.IdolForumPostCommentReactions.Add(new IdolForumPostCommentReaction
                {
                    ReactionTypeID = model.ReactionTypeID,
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

        public bool DeleteIdolForumPostCommentReaction(int ReactionID)
        {
            try
            {
                _db.IdolForumPostCommentReactions.Remove(GetIdolForumPostCommentReactionByReactionID(ReactionID));
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<IdolForumPostCommentReaction> GetAllIdolForumPostCommentReaction()
        {
            try
            {
                return _db.IdolForumPostCommentReactions.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IdolForumPostCommentReaction GetIdolForumPostCommentReactionByReactionID(int ReactionID)
        {
            try
            {
                return _db.IdolForumPostCommentReactions.Find(ReactionID) ?? new IdolForumPostCommentReaction();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool UpdateIdolForumPostCommentReaction(IdolForumPostCommentReactionViewModel model, string userId)
        {
            try
            {
                var comment = GetIdolForumPostCommentReactionByReactionID(model.ReactionID);
                comment.ReactionTypeID = model.ReactionTypeID;
                comment.CommentID = model.CommentID;
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