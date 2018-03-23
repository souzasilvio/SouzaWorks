using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crm.Portal.Models
{
    public class Reserva
    {
        public Guid Id { get; set; }

        [Display(Name = "Titulo")]
        public string Titulo { get; set; }

        
        public Guid IdCliente { get; set; }

        [Display(Name = "Cliente")]
        [Required(ErrorMessage = "Informe o cliente")]
        public string NomeCliente { get; set; }


        public Guid IdProduto { get; set; }

        [Display(Name = "Lote")]
        [Required(ErrorMessage = "Informe o lote")]
        public string NomeProduto { get; set; }
                        
    }
}