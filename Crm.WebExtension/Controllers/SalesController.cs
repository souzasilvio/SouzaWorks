using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Crm.WebExtension.Controllers
{
    // Allow CORS for all origins. (Caution!)
    //In production enviroment restrict this to origin your need
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/sales")]
    public class SalesController : ApiController
    {
        [Route("getaddress/{zipcode}")]
        [HttpGet]
        public Model.Endereco GetAddress(string zipcode)
        {
            return Dominio.SalesDomain.Instancia.GetAddress(zipcode);
        }
    }
}
