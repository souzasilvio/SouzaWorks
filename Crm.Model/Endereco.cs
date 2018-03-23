using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Crm.Model
{
    /// <summary>
    /// Model class to represent a customer address
    /// </summary>
    public class Endereco : Resultado
    {
        public string Cep { get; set; }

        public string Logradouro { get; set; }

        public string LogradouroResumido { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string IdCidade { get; set; }

        public string Estado { get; set; }

        public string IdEstado { get; set; }
    }
}