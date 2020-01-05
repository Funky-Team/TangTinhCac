using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using TangTinhCac.Models.ViewModels.Idols;
using TangTinhCac.Services.Idols;

namespace TangTinhCac.Controllers.WebApi
{
    public class BodyController : ApiController
    {
        private readonly IBodyService _bodyService;
        public BodyController(IBodyService bodyService)
        {
            _bodyService = bodyService;
        }
        [HttpGet]
        public HttpResponseMessage GetAllBody()
        {
            var listBodies = _bodyService.GetAllBody();
            return Request.CreateResponse(HttpStatusCode.OK, listBodies);
        }
        [HttpGet]
        public HttpResponseMessage GetBodyByBodyID(int id)
        {
            var body = _bodyService.GetBodyByBodyID(id);
            return Request.CreateResponse(HttpStatusCode.OK, body);
        }
        [HttpPost]
        public HttpResponseMessage CreateNewBody(BodyViewModel model)
        {
            var success = _bodyService.CreateNewBody(model, "efc5e3d2-af64-4c36-993e-0fd6731807ff");
            return Request.CreateResponse(HttpStatusCode.OK, success);
        }
        [HttpPut]
        public HttpResponseMessage UpdateBody(BodyViewModel model)
        {
            var success = _bodyService.UpdateBody(model, "efc5e3d2-af64-4c36-993e-0fd6731807ff");
            return Request.CreateResponse(HttpStatusCode.OK, success);
        }
        [HttpDelete]
        public HttpResponseMessage DeleteBody(int id)
        {
            var success = _bodyService.DeleteBody(id);
            return Request.CreateResponse(HttpStatusCode.OK, success);
        }
    }
}