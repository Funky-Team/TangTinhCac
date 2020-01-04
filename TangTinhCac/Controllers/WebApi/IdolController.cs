using Microsoft.AspNet.Identity;
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
    public class IdolController : ApiController
    {
        private readonly IIdolService _idolService;

        public IdolController(IIdolService idolService)
        {
            _idolService = idolService;
        }

        [HttpGet]
        public HttpResponseMessage GetAllIdols()
        {
            var listIdols = _idolService.GetAllIdols();
            return Request.CreateResponse(HttpStatusCode.OK, listIdols);
        }

        [HttpGet]
        public HttpResponseMessage GetIdolByIdolID(Guid id)
        {
            var idol = _idolService.GetIdolByIdolID(id);
            return Request.CreateResponse(HttpStatusCode.OK, idol);
        }

        [HttpPut]
        public HttpResponseMessage UpdateIdol(IdolViewModel model)
        {
            var success = _idolService.UpdateIdol(model, "efc5e3d2-af64-4c36-993e-0fd6731807ff");
            return Request.CreateResponse(HttpStatusCode.OK, success);
        }

        [HttpPost]
        public HttpResponseMessage CreateNewIdol(IdolViewModel model)
        {
            var success = _idolService.CreateNewIdol(model, "efc5e3d2-af64-4c36-993e-0fd6731807ff");
            return Request.CreateResponse(HttpStatusCode.OK, success);
        }

        [HttpDelete]
        public HttpResponseMessage DeleteIdol(Guid id)
        {
            var success = _idolService.DeleteIdol(id);
            return Request.CreateResponse(HttpStatusCode.OK, success);
        }
    }
}
