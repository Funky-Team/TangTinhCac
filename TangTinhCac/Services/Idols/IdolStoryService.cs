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
    public class IdolStoryService : IIdolStoryService
    {
        private readonly ApplicationDbContext _db;

        public IdolStoryService(IDBFactory dbFactoryService)
        {
            _db = dbFactoryService.Init();
        }

        public bool CreateNewIdolStory(IdolStoryViewModel model, string userId)
        {
            try
            {
                _db.IdolStories.Add(new IdolStory
                {
                    StoryTimeline = model.StoryTimeline,
                    StoryContent = model.StoryContent,
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

        public bool DeleteIdolStory(int storyID)
        {
            try
            {
                _db.IdolStories.Remove(GetIdolStoryByStoryID(storyID));
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<IdolStory> GetAllIdolStories()
        {
            try
            {
                return _db.IdolStories.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IdolStory GetIdolStoryByStoryID(int storyID)
        {
            try
            {
                return _db.IdolStories.Find(storyID) ?? new IdolStory();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool UpdateIdolStory(IdolStoryViewModel model, string userId)
        {
            try
            {
                var idolStory = GetIdolStoryByStoryID(model.StoryID);
                idolStory.StoryTimeline = model.StoryTimeline;
                idolStory.StoryContent = model.StoryContent;
                idolStory.IdolID = model.IdolID;
                idolStory.LastModifiedDateTime = DateTime.Now;
                idolStory.LastModifiedByID = userId;
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<IdolStory> GetIdolStoryByIdolID(Guid id)
        {
            try
            {
                return _db.IdolStories.Where(x => x.IdolID == id).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}