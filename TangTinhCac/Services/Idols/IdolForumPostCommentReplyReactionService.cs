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
    public class IdolForumPostCommentReplyReactionService : IIdolForumPostCommentReplyReactionService
    {
        private readonly ApplicationDbContext _db;
        public IdolForumPostCommentReplyReactionService(IDBFactory dBFactoryService)
        {
            _db = dBFactoryService.Init(); 
        }
        public bool CreateNewIdolForumPostCommentReplyReaction(IdolForumPostCommentReplyReactionViewModel model, string userId)
        {
            try
            {
                _db.IdolForumPostCommentReplyReactions.Add(new IdolForumPostCommentReplyReaction
                {
                    ReactionTypeID = model.ReactionTypeID,
                    ReplyID = model.ReplyID,
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

        public bool DeleteIdolForumPostCommentReplyReaction(int ReactionID)
        {
            try
            {
                _db.IdolForumPostCommentReplyReactions.Remove(GetIdolForumPostCommentReplyReactionByReactionID(ReactionID));
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<IdolForumPostCommentReplyReaction> GetAllIdolForumPostCommentReplyReaction()
        {
            try
            {
                return _db.IdolForumPostCommentReplyReactions.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IdolForumPostCommentReplyReaction GetIdolForumPostCommentReplyReactionByReactionID(int ReactionID)
        {
            try
            {
                return _db.IdolForumPostCommentReplyReactions.Find(ReactionID) ?? new IdolForumPostCommentReplyReaction();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool UpdateIdolForumPostCommentReplyReaction(IdolForumPostCommentReplyReactionViewModel model, string userId)
        {
            try
            {
                var reaction = GetIdolForumPostCommentReplyReactionByReactionID(model.ReactionID);
                reaction.ReactionTypeID = model.ReactionTypeID;
                reaction.ReplyID = model.ReplyID;
                reaction.LastModifiedByID = userId;
                reaction.LastModifiedDateTime = DateTime.Now;
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