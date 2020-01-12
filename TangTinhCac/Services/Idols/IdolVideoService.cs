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
    public class IdolVideoService : IIdolVideoService
    {
        private readonly ApplicationDbContext _db;

        public IdolVideoService(IDBFactory dbFactoryService)
        {
            _db = dbFactoryService.Init();
        }
        public bool CreateNewIdolVideo(IdolVideoViewModel model, string userId)
        {
            try
            {
                _db.IdolVideos.Add(new IdolVideo
                {
                    VideoTitle = model.VideoTitle,
                    VideoDesc = model.VideoDesc,
                    VideoLink = model.VideoLink,
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

        public bool DeleteIdolVideo(int videoID)
        {
            try
            {
                _db.IdolVideos.Remove(GetIdolVideoByVideoID(videoID));
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<IdolVideo> GetAllIdolVideos()
        {
            try
            {
                return _db.IdolVideos.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IdolVideo GetIdolVideoByVideoID(int videoID)
        {
            try
            {
                return _db.IdolVideos.Find(videoID);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool UpdateIdolVideo(IdolVideoViewModel model, string userId)
        {
            try
            {
                var idolVideo = GetIdolVideoByVideoID(model.VideoID);
                idolVideo.VideoTitle = model.VideoTitle;
                idolVideo.VideoDesc = model.VideoDesc;
                idolVideo.VideoLink = model.VideoLink;
                idolVideo.IdolID = model.IdolID;
                idolVideo.LastModifiedDateTime = DateTime.Now;
                idolVideo.LastModifiedByID = userId;
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