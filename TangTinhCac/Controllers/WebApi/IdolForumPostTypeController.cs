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
    public class IdolForumPostTypeController : ApiController
    {
        private readonly IIdolForumPostTypeService _idolForumPostTypeService;
        public IdolForumPostTypeController(IIdolForumPostTypeService idolForumPostTypeService)
        {
            _idolForumPostTypeService = idolForumPostTypeService;
        }

        [HttpPost]
        public HttpResponseMessage CreateNewIdolForumPostType(IdolForumPostTypeViewModel model)
        {
            var success = _idolForumPostTypeService.CreateNewIdolForumPostType(model, "efc5e3d2 - af64 - 4c36 - 993e-0fd6731807ff");
            return Request.CreateResponse(HttpStatusCode.OK, success);
        }
        [HttpPut]
        public HttpResponseMessage UpdateIdolForumPostType(IdolForumPostTypeViewModel model)
        {
            var success = _idolForumPostTypeService.UpdateIdolForumPostType(model, "efc5e3d2 - af64 - 4c36 - 993e-0fd6731807ff");
            return Request.CreateResponse(HttpStatusCode.OK, success);
        }
        [HttpGet]
        public HttpResponseMessage GetAllIdolForumPostType()
        {
            var listBra = _idolForumPostTypeService.GetAllIdolForumPostType();
            return Request.CreateResponse(HttpStatusCode.OK, listBra);
        }
        [HttpGet]
        public HttpResponseMessage GetIdolForumPostTypeByPostTypeID(int id)
        {
            var bra = _idolForumPostTypeService.GetIdolForumPostTypeByPostTypeID(id);
            return Request.CreateResponse(HttpStatusCode.OK, bra);
        }
        [HttpDelete]
        public HttpResponseMessage DeleteIdolForumPostType(int id)
        {
            var success = _idolForumPostTypeService.DeleteIdolForumPostType(id);
            return Request.CreateResponse(HttpStatusCode.OK, success);
        }
    }
}
