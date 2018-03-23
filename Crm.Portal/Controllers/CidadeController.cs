using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crm.Portal.Controllers
{
    public class CidadeController : Controller
    {
        // GET: Contato
        public ActionResult Index()
        {
            ViewBag.Cidade = Consultar();
            return View();
        }

        private List<Models.Cidade> Consultar()
        {
            var lista = new List<Models.Cidade>();
            for (int i = 1; i <= 10; i++)
            {
                var cidade = new Models.Cidade();
                cidade.Codigo = i;
                cidade.Nome = "CIDADE " + i.ToString();
                cidade.NomeEstado = "Estado " + i.ToString();
                cidade.CodigoEstado = i;
                cidade.NomePais = "Pais" + i.ToString();
                cidade.CodigoPais = i;
                lista.Add(cidade);
            }

            return lista;

        }


        [HttpPost]
        public ActionResult Create([Bind(Include = "Codigo,Nome,CodigoEstado,NomeEstado,CodigoPais,NomePais")]Models.Cidade cidade)
        {
            try
            {

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Create(int Codigo=0)
        {
            try
            {

                var cidade = new Models.Cidade();
                cidade.CodigoEstado = 1;
                cidade.CodigoPais = 1;
                cidade.Codigo = Codigo;
                cidade.NomePais = "PAIS " + Codigo.ToString();
                cidade.NomeEstado = "Estado " + Codigo.ToString();
                cidade.Nome = "CIDADE " + Codigo.ToString();
                cidade.Estados = GetEstados();
                cidade.Paises = GetPaises();
                return View(cidade);                
            }
            catch
            {
                return View();
            }
        }


        private IEnumerable<SelectListItem> GetEstados()
        {

            var estados = new List<SelectListItem>();
            for (int i = 2; i <= 10; i++)
            {
              var  x = new SelectListItem(){
                                        Value = i.ToString(),
                                        Text = "Estado " + i.ToString()
                                    };
                estados.Add(x);
            }
            return new SelectList(estados, "Value", "Text");
        }

        private IEnumerable<SelectListItem> GetPaises()
        {

            var paises = new List<SelectListItem>();
            var b = new SelectListItem()
            {
                Value = "1",
                Text = "BRASIL"
            };
            paises.Add(b);
            for (int i = 2; i <= 10; i++)
            {
                var x = new SelectListItem()
                {
                    Value = i.ToString(),
                    Text = "País " + i.ToString()
                };
                paises.Add(x);
            }
            return new SelectList(paises, "Value", "Text");
        }

    }
}