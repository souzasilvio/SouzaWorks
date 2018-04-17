using System;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using System.Linq;
using Crm.Model;

namespace Crm.Dominio
{
    /// <summary>
    /// Objective: Domain classe to operations about salles (for example)
    /// Autor: Silvio Jose de Souza
    /// </summary>
    public class  SalesDomain : Base.DominioBase
    {
        #region singleton intancia
        private static volatile SalesDomain _instance;
        private static object syncRoot = new Object();

        private SalesDomain() { }
        public static SalesDomain Instancia
        {
            get
            {
                if (_instance == null)
                {
                    lock (syncRoot)
                    {
                        if (_instance == null)
                        {
                            _instance = new SalesDomain();
                        }
                    }
                }

                return _instance;
            }
        }
        #endregion

        public Endereco GetAddress(string zipcode)
        {
            //This Method shoud access a company service or third service to discover a address using
            //a zipcode. Then the returned address could be use to autocomplet a customer address in CRM form.
            var address = new Endereco();
            address.Cep = zipcode;
            address.Bairro = "Centro";
            address.Cidade = "Belo Horizonte";
            address.Estado = "Minas Gerais";
            address.Logradouro = "St. Santa Maria";
            return address;
        }

        public EntityCollection GetContactsByLastName(string lastLame, params string[] columns)
        {
            return ListarPorFiltro(Contact.EntityLogicalName, "lastname", columns);
        }

    }
}
