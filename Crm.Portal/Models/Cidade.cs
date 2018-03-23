using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crm.Portal.Models
{
    public class Cidade
    {
        public int Codigo { get; set; }

        [Display(Name = "Estado")]
        [Required(ErrorMessage = "Informe o nome da cidade.")]
        public string Nome { get; set; }

        public int CodigoEstado { get; set; }

        [Display(Name = "Estado")]
        [Required(ErrorMessage ="Selecione o estado")]
        public string NomeEstado { get; set; }

        public int CodigoPais { get; set; }

        [Display(Name = "País")]
        [Required(ErrorMessage = "Selecione o país")]
        public string NomePais { get; set; }

        public IEnumerable<SelectListItem> Estados { get; set; }

        public IEnumerable<SelectListItem> Paises { get; set; }
    }
}