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
    public class IdolForumPostCommentReactionController : ApiController
    {
        private readonly IIdolForumPostCommentReactionService _idolForumPostCommentReactionService;
        public IdolForumPostCommentReactionController(IIdolForumPostCommentReactionService idolForumPostCommentReactionService)
        {
            _idolForumPostCommentReactionService = idolForumPostCommentReactionService;
        }
        [HttpPost]
        public HttpResponseMessage CreateNewIdolForumPostCommentReaction(IdolForumPostCommentReactionViewModel model)
        {
            var success = _idolForumPostCommentReactionService.CreateNewIdolForumPostCommentReaction(model, "efc5e3d2 - af64 - 4c36 - 993e-0fd6731807ff");
            return Request.CreateResponse(HttpStatusCode.OK, success);
        }
        [HttpPut]
        public HttpResponseMessage UpdateIdolForumPostCommentReaction(IdolForumPostCommentReactionViewModel model)
        {
            var success = _idolForumPostCommentReactionService.UpdateIdolForumPostCommentReaction(model, "efc5e3d2 - af64 - 4c36 - 993e-0fd6731807ff");
            return Request.CreateResponse(HttpStatusCode.OK, success);
        }
        [HttpGet]
        public HttpResponseMessage GetAllIdolForumPostCommentReaction()
        {
            var listBra = _idolForumPostCommentReactionService.GetAllIdolForumPostCommentReaction();
            return Request.CreateResponse(HttpStatusCode.OK, listBra);
        }
        [HttpGet]
        public HttpResponseMessage GetIdolForumPostCommentReactionByReactionID(int id)
        {
            var bra = _idolForumPostCommentReactionService.GetIdolForumPostCommentReactionByReactionID(id);
            return Request.CreateResponse(HttpStatusCode.OK, bra);
        }
        [HttpDelete]
        public HttpResponseMessage DeleteIdolForumPostCommentReaction(int id)
        {
            var success = _idolForumPostCommentReactionService.DeleteIdolForumPostCommentReaction(id);
            return Request.CreateResponse(HttpStatusCode.OK, success);
        } 
    }
}
