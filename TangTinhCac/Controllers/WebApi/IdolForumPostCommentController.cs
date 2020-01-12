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
    public class IdolForumPostCommentController : ApiController
    {
        private readonly IIdolForumPostCommentService _idolForumPostCommentService;
        public IdolForumPostCommentController(IIdolForumPostCommentService idolForumPostCommentService)
        {
            _idolForumPostCommentService = idolForumPostCommentService;
        }
        [HttpPost]
        public HttpResponseMessage CreateNewIdolForumPostComment(IdolForumPostCommentViewModel model)
        {
            var success = _idolForumPostCommentService.CreateNewIdolForumPostComment(model, "efc5e3d2 - af64 - 4c36 - 993e-0fd6731807ff");
            return Request.CreateResponse(HttpStatusCode.OK, success);
        }
        [HttpPut]
        public HttpResponseMessage UpdateIdolForumPostComment(IdolForumPostCommentViewModel model)
        {
            var success = _idolForumPostCommentService.UpdateIdolForumPostComment(model, "efc5e3d2 - af64 - 4c36 - 993e-0fd6731807ff");
            return Request.CreateResponse(HttpStatusCode.OK, success);
        }
        [HttpGet]
        public HttpResponseMessage GetAllIdolForumPostComment()
        {
            var listBra = _idolForumPostCommentService.GetAllIdolForumPostComment();
            return Request.CreateResponse(HttpStatusCode.OK, listBra);
        }
        [HttpGet]
        public HttpResponseMessage GetIdolForumPostCommentByCommentID(int id)
        {
            var bra = _idolForumPostCommentService.GetIdolForumPostCommentByCommentID(id);
            return Request.CreateResponse(HttpStatusCode.OK, bra);
        }
        [HttpDelete]
        public HttpResponseMessage DeleteIdolForumPostComment(int id) 
        {
            var success = _idolForumPostCommentService.DeleteIdolForumPostComment(id);
            return Request.CreateResponse(HttpStatusCode.OK, success);
        }
    }
}
