using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TangTinhCac.Models.ViewModels.Idols;
using TangTinhCac.Services.Idols;

namespace TangTinhCac.Controllers.WebApi
{
    public class IdolForumPostImageController : ApiController
    {
        private readonly IIdolForumPostImageService _idolForumPostImageService;
        public IdolForumPostImageController(IIdolForumPostImageService idolForumPostImageService)
        {
            _idolForumPostImageService = idolForumPostImageService;
        }
        [HttpPost]
        public HttpResponseMessage CreateNewIdolForumPostImage(IdolForumPostImageViewModel model)
        {
            var success = _idolForumPostImageService.CreateNewIdolForumPostImage(model, "efc5e3d2 - af64 - 4c36 - 993e-0fd6731807ff");
            return Request.CreateResponse(HttpStatusCode.OK, success);
        }
        [HttpPut]
        public HttpResponseMessage UpdateIdolForumPostImage(IdolForumPostImageViewModel model)
        {
            var success = _idolForumPostImageService.UpdateIdolForumPostImage(model, "efc5e3d2 - af64 - 4c36 - 993e-0fd6731807ff");
            return Request.CreateResponse(HttpStatusCode.OK, success);
        }
        [HttpGet]
        public HttpResponseMessage GetAllIdolForumPostImage()
        {
            var listBra = _idolForumPostImageService.GetAllIdolForumPostImage();
            return Request.CreateResponse(HttpStatusCode.OK, listBra);
        }
        [HttpGet]
        public HttpResponseMessage GetIdolForumPostImageByImageID(int id)
        {
            var bra = _idolForumPostImageService.GetIdolForumPostImageByImageID(id);
            return Request.CreateResponse(HttpStatusCode.OK, bra);
        }
        [HttpDelete]
        public HttpResponseMessage DeleteIdolForumPostImage(int id)
        {
            var success = _idolForumPostImageService.DeleteIdolForumPostImage(id);
            return Request.CreateResponse(HttpStatusCode.OK, success);
        }
    }
}
