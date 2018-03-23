using Microsoft.Xrm.Sdk;
using System;
using System.Web.Mvc;

namespace Crm.Portal.Controllers
{
    [Authorize]
    public class ContatoController : Controller
    {
        // GET: Contato
        public ActionResult Index()
        {          
           ViewBag.Contatos = Consultar();
           return View(); 
        }

        private DataCollection<Entity> Consultar(string nome = null)
        {
            //return Dominio.ContacDomain.Instancia.Listar(nome);            
            return null;
        }

        [HttpPost]
        public ActionResult Index(FormCollection fc, string nomePesquisa)
        {
            
            ViewBag.Contatos = Consultar(nomePesquisa);
            return View();
        }



        [HttpPost]
        public ActionResult AddNew([Bind(Include = "Id,FirstName, LastName, EmailAddress1, Telephone1")]Model.Contact contato)
        {
            try
            {

                return null;
              //if(contato.Id == Guid.Empty)
              //  Dominio.ContacDomain.Instancia.Create(contato);
              //else
              //      Dominio.ContacDomain.Instancia.Atualizar(contato);

              // return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]        
        public ActionResult AddNew(string id)
        {
            try
            {

                //if (!string.IsNullOrEmpty(id))
                //{
                //  var contato = Dominio.ContacDomain.Instancia.Obter(Model.Contact.EntityLogicalName, new Guid(id), true);
                //  return View(contato);
                //}
                return View();
            }
            catch
            {
                return View();
            }
        }
        

        [HttpGet]
        public ActionResult Delete(Guid id)
        {
            //if (id != Guid.Empty)
            //    Dominio.ContacDomain.Instancia.Excluir(Model.Contact.EntityLogicalName, id);
            return Redirect("~/Contato");
        }

      
        // GET: Pessoas/Create
        public ActionResult Create()
        {
            return View();
        }

       

    }
}