using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crm.Portal.Models
{
    public class EstadoViewModel
    {
    
        [Display(Name = "Estado")]
        public int Codigo { get; set; }
        public IEnumerable<SelectListItem> Estados { get; set; }
    }
}