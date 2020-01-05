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
    public class BraController : ApiController
    {
        private readonly IBraService _braService;
        public BraController(IBraService braService)
        {
            _braService = braService;
        }
        [HttpPost]
        public HttpResponseMessage CreateNewBra(BraViewModel model)
        {
            var success = _braService.CreateNewBra(model, "efc5e3d2 - af64 - 4c36 - 993e-0fd6731807ff");
            return Request.CreateResponse(HttpStatusCode.OK, success);
        }
        [HttpPut]
        public HttpResponseMessage UpdateBra(BraViewModel model)
        {
            var success = _braService.UpdateBra(model, "efc5e3d2 - af64 - 4c36 - 993e-0fd6731807ff");
            return Request.CreateResponse(HttpStatusCode.OK, success);
        }
        [HttpGet]
        public HttpResponseMessage GetAllBra()
        {
            var listBra = _braService.GetAllBra();
            return Request.CreateResponse(HttpStatusCode.OK, listBra);
        }
        [HttpGet]
        public HttpResponseMessage GetBraByBraID(int id)
        {
            var bra = _braService.GetBraByBraID(id);
            return Request.CreateResponse(HttpStatusCode.OK, bra);
        }
        [HttpDelete]
        public HttpResponseMessage DeleteBra(int id) 
        {
            var success = _braService.DeleteBra(id);
            return Request.CreateResponse(HttpStatusCode.OK, success);
        }
    }
}
