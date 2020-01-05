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
    public class BoobStatusController : ApiController
    {
        private readonly IBoobStatusService _boobStatusService;
        public BoobStatusController(IBoobStatusService boobStatusService)
        {
            _boobStatusService = boobStatusService;
        }
        [HttpGet]
        public HttpResponseMessage GetAllBoobStatus()
        {
            var listBoobStatus = _boobStatusService.GetAllBoobStatus();
            return Request.CreateResponse(HttpStatusCode.OK, listBoobStatus);
        }
        [HttpGet]
        public HttpResponseMessage GetBoobStatusByID(int id)
        {
            var boobStatus = _boobStatusService.GetBoobStatusByID(id);
            return Request.CreateResponse(HttpStatusCode.OK, boobStatus);
        }
        [HttpPost]
        public HttpResponseMessage CreateBoobStatus(BoobStatusViewModel model)
        {
            var success = _boobStatusService.CreateBoobStatus(model, "efc5e3d2-af64-4c36-993e-0fd6731807ff");
            return Request.CreateResponse(HttpStatusCode.OK, success);
        }
        [HttpPut]
        public HttpResponseMessage UpdateBooStatus(BoobStatusViewModel model)
        {
            var success = _boobStatusService.UpdateBooStatus(model, "efc5e3d2-af64-4c36-993e-0fd6731807ff");
            return Request.CreateResponse(HttpStatusCode.OK, success);
        }
        public HttpResponseMessage DeleteBoobStatus(int id)
        {
            var success = _boobStatusService.DeleteBoobStatus(id);
            return Request.CreateResponse(HttpStatusCode.OK, success);
        }
    }
}
