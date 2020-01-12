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
    public class ReactionTypeService : IReactionTypeService
    {
        private readonly ApplicationDbContext _db;
        public ReactionTypeService(IDBFactory dBFactoryService)
        {
            _db = dBFactoryService.Init();
        }
        public bool CreateNewReactionType(ReactionTypeViewModel model, string userId) 
        {
            try
            {
                _db.ReactionTypes.Add(new ReactionType
                {
                    ReactionTypeDesc = model.ReactionTypeDesc,
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

        public bool DeleteReactionTypeID(int reactionTypeID)
        {
            try
            {
                _db.ReactionTypes.Remove(GetReactionTypeByReactionTypeID(reactionTypeID));
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<ReactionType> GetAllReactionTypes()
        {
            try
            {
                return _db.ReactionTypes.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public ReactionType GetReactionTypeByReactionTypeID(int reactionTypeID)
        {
            try
            {
                return _db.ReactionTypes.Find(reactionTypeID);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool UpdateReactionTypeID(ReactionTypeViewModel model, string userId)
        {
            try
            {
                var reactionType = GetReactionTypeByReactionTypeID(model.ReactionTypeID);
                reactionType.ReactionTypeDesc = model.ReactionTypeDesc;
                reactionType.LastModifiedByID = userId;
                reactionType.LastModifiedDateTime = DateTime.Now;
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