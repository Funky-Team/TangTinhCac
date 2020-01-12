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
    public class IdolForumPostCommentReplyController : ApiController
    {
        private readonly IIdolForumPostCommentReplyService _idolForumPostCommentReplyService;
        public IdolForumPostCommentReplyController(IIdolForumPostCommentReplyService idolForumPostCommentReplyService)
        {
            _idolForumPostCommentReplyService = idolForumPostCommentReplyService;
        }
        [HttpPost]
        public HttpResponseMessage CreateNewIdolForumPostCommentReply(IdolForumPostCommentReplyViewModel model)
        {
            var success = _idolForumPostCommentReplyService.CreateNewIdolForumPostCommentReply(model, "efc5e3d2 - af64 - 4c36 - 993e-0fd6731807ff");
            return Request.CreateResponse(HttpStatusCode.OK, success);
        }
        [HttpPut]
        public HttpResponseMessage UpdateIdolForumPostCommentReply(IdolForumPostCommentReplyViewModel model)
        {
            var success = _idolForumPostCommentReplyService.UpdateIdolForumPostCommentReply(model, "efc5e3d2 - af64 - 4c36 - 993e-0fd6731807ff");
            return Request.CreateResponse(HttpStatusCode.OK, success);
        }
        [HttpGet]
        public HttpResponseMessage GetAllIdolForumPostCommentReply()
        {
            var listBra = _idolForumPostCommentReplyService.GetAllIdolForumPostCommentReply();
            return Request.CreateResponse(HttpStatusCode.OK, listBra);
        }
        [HttpGet]
        public HttpResponseMessage GetIdolForumPostCommentReplyByReplyID(int id)
        {
            var bra = _idolForumPostCommentReplyService.GetIdolForumPostCommentReplyByReplyID(id);
            return Request.CreateResponse(HttpStatusCode.OK, bra);
        }
        [HttpDelete]
        public HttpResponseMessage DeleteIdolForumCommentPostReply(int id)
        {
            var success = _idolForumPostCommentReplyService.DeleteIdolForumPostCommentReply(id);
            return Request.CreateResponse(HttpStatusCode.OK, success);
        }
    }
}
