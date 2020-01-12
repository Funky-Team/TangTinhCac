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
    public class IdolForumPostController : ApiController
    {
        private readonly IIdolForumPostService _idolForumPostService;
        public IdolForumPostController(IIdolForumPostService idolForumPostService)
        {
            _idolForumPostService = idolForumPostService;
        }
        [HttpPost]
        public HttpResponseMessage CreateNewIdolForumPost(IdolForumPostViewModel model)
        {
            var success = _idolForumPostService.CreateNewIdolForumPost(model, "efc5e3d2 - af64 - 4c36 - 993e-0fd6731807ff");
            return Request.CreateResponse(HttpStatusCode.OK, success);
        }
        [HttpPut]
        public HttpResponseMessage UpdateIdolForumPost(IdolForumPostViewModel model) 
        {
            var success = _idolForumPostService.UpdateIdolForumPost(model, "efc5e3d2 - af64 - 4c36 - 993e-0fd6731807ff");
            return Request.CreateResponse(HttpStatusCode.OK, success);
        }
        [HttpGet]
        public HttpResponseMessage GetAllIdolForumPost()
        {
            var listBra = _idolForumPostService.GetAllIdolForumPost();
            return Request.CreateResponse(HttpStatusCode.OK, listBra);
        }
        [HttpGet]
        public HttpResponseMessage GetIdolForumPostByPostID(int id)
        {
            var bra = _idolForumPostService.GetIdolForumPostByPostID(id);
            return Request.CreateResponse(HttpStatusCode.OK, bra);
        }
        [HttpDelete]
        public HttpResponseMessage DeleteIdolForumPost(int id)
        {
            var success = _idolForumPostService.DeleteIdolForumPost(id);
            return Request.CreateResponse(HttpStatusCode.OK, success);
        }
    }
}
