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
    public class IdolImageController : ApiController
    {
        private readonly IIdolImageService _idolImageService;

        public IdolImageController(IIdolImageService idolImageService)
        {
            _idolImageService = idolImageService;
        }

        [HttpGet]
        public HttpResponseMessage GetAllIdolImages()
        {
            var listIdols = _idolImageService.GetAllIdolImages();
            return Request.CreateResponse(HttpStatusCode.OK, listIdols);
        }

        [HttpGet]
        public HttpResponseMessage GetIdolImageByImageID(int id)
        {
            var idol = _idolImageService.GetIdolImageByImageID(id);
            return Request.CreateResponse(HttpStatusCode.OK, idol);
        }

        [HttpPut]
        public HttpResponseMessage UpdateIdolImage(IdolImageViewModel model)
        {
            var success = _idolImageService.UpdateIdolImage(model, "efc5e3d2-af64-4c36-993e-0fd6731807ff");
            return Request.CreateResponse(HttpStatusCode.OK, success);
        }

        [HttpPost]
        public HttpResponseMessage CreateNewIdolImage(IdolImageViewModel model)
        {
            var success = _idolImageService.CreateNewIdolImage(model, "efc5e3d2-af64-4c36-993e-0fd6731807ff");
            return Request.CreateResponse(HttpStatusCode.OK, success);
        }

        [HttpDelete]
        public HttpResponseMessage DeleteIdolImage(int id)
        {
            var success = _idolImageService.DeleteIdolImage(id);
            return Request.CreateResponse(HttpStatusCode.OK, success);
        }
    }
}
