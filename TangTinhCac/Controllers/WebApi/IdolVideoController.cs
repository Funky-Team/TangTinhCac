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
    public class IdolVideoController : ApiController
    {
        private readonly IIdolVideoService _idolVideoService;

        public IdolVideoController(IIdolVideoService idolVideoService)
        {
            _idolVideoService = idolVideoService;
        }

        [HttpGet]
        public HttpResponseMessage GetAllIdolVideos()
        {
            var listIdols = _idolVideoService.GetAllIdolVideos();
            return Request.CreateResponse(HttpStatusCode.OK, listIdols);
        }

        [HttpGet]
        public HttpResponseMessage GetIdolVideoByVideoID(int id)
        {
            var idol = _idolVideoService.GetIdolVideoByVideoID(id);
            return Request.CreateResponse(HttpStatusCode.OK, idol);
        }

        [HttpPut]
        public HttpResponseMessage UpdateIdolVideo(IdolVideoViewModel model)
        {
            var success = _idolVideoService.UpdateIdolVideo(model, "efc5e3d2-af64-4c36-993e-0fd6731807ff");
            return Request.CreateResponse(HttpStatusCode.OK, success);
        }

        [HttpPost]
        public HttpResponseMessage CreateNewIdolVideo(IdolVideoViewModel model)
        {
            var success = _idolVideoService.CreateNewIdolVideo(model, "efc5e3d2-af64-4c36-993e-0fd6731807ff");
            return Request.CreateResponse(HttpStatusCode.OK, success);
        }

        [HttpDelete]
        public HttpResponseMessage DeleteIdolVideo(int id) 
        {
            var success = _idolVideoService.DeleteIdolVideo(id);
            return Request.CreateResponse(HttpStatusCode.OK, success);
        }
    }
}
