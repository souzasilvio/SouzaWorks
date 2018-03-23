using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crm.Portal.Controllers
{
    [Authorize]
    public class ClienteController : Controller
    {
        // GET: Contato
        public ActionResult Index()
        {
            ViewBag.Clientes = Consultar();
            return View();
        }

        private DataCollection<Entity> Consultar(string nome = null)
        {
            ///return Dominio.Cliente.Instancia.Listar(nome);
            return null;
        }
    }
}