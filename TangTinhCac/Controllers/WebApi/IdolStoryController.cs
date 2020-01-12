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
    public class IdolStoryController : ApiController
    {
        private readonly IIdolStoryService _idolStoryService;

        public IdolStoryController(IIdolStoryService idolStoryService)
        {
            _idolStoryService = idolStoryService;
        }

        [HttpGet]
        public HttpResponseMessage GetAllIdolStories()
        {
            var listIdols = _idolStoryService.GetAllIdolStories();
            return Request.CreateResponse(HttpStatusCode.OK, listIdols);
        }

        [HttpGet]
        public HttpResponseMessage GetIdolStoryByStoryID(int id)
        {
            var idol = _idolStoryService.GetIdolStoryByStoryID(id);
            return Request.CreateResponse(HttpStatusCode.OK, idol);
        }

        [HttpPut]
        public HttpResponseMessage UpdateIdolStory(IdolStoryViewModel model)
        {
            var success = _idolStoryService.UpdateIdolStory(model, "efc5e3d2-af64-4c36-993e-0fd6731807ff");
            return Request.CreateResponse(HttpStatusCode.OK, success);
        }

        [HttpPost]
        public HttpResponseMessage CreateNewIdolStory(IdolStoryViewModel model) 
        {
            var success = _idolStoryService.CreateNewIdolStory(model, "efc5e3d2-af64-4c36-993e-0fd6731807ff");
            return Request.CreateResponse(HttpStatusCode.OK, success);
        }

        [HttpDelete]
        public HttpResponseMessage DeleteIdolStory(int id)
        {
            var success = _idolStoryService.DeleteIdolStory(id);
            return Request.CreateResponse(HttpStatusCode.OK, success);
        }

        [HttpGet]
        public HttpResponseMessage GetIdolStoryByIdolID(Guid id)
        {
            var listIdols = _idolStoryService.GetIdolStoryByIdolID(id);
            return Request.CreateResponse(HttpStatusCode.OK, listIdols);
        }
    }
}
