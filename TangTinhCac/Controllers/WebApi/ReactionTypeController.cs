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
    public class ReactionTypeController : ApiController
    {
        private readonly IReactionTypeService _reactionTypeService;
        public ReactionTypeController(IReactionTypeService reactionTypeService)
        {
            _reactionTypeService = reactionTypeService;
        }
        [HttpGet]
        public HttpResponseMessage GetAllReactionTypes()
        {
            var listReactionType = _reactionTypeService.GetAllReactionTypes();
            return Request.CreateResponse(HttpStatusCode.OK, listReactionType);
        }
        [HttpGet]
        public HttpResponseMessage GetReactionTypeByReactionTypeID(int id)
        {
            var reactionType = _reactionTypeService.GetReactionTypeByReactionTypeID(id);
            return Request.CreateResponse(HttpStatusCode.OK, reactionType);
        }
        [HttpPost]
        public HttpResponseMessage CreateNewReactionType(ReactionTypeViewModel model)
        {
            var success = _reactionTypeService.CreateNewReactionType(model, "");
            return Request.CreateResponse(HttpStatusCode.OK, success);
        }
        [HttpPut]
        public HttpResponseMessage UpdateReactionTypeID(ReactionTypeViewModel model)
        {
            var success = _reactionTypeService.UpdateReactionTypeID(model, "");
            return Request.CreateResponse(HttpStatusCode.OK, success);
        }
        [HttpDelete]
        public HttpResponseMessage DeleteReactionTypeID(int id)
        {
            var success = _reactionTypeService.DeleteReactionTypeID(id);
            return Request.CreateResponse(HttpStatusCode.OK, success);
        }
    }
}
