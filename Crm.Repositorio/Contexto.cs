using System;
using Microsoft.Xrm.Sdk.Client;
using System.ServiceModel.Description;
using System.Configuration;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;

namespace Crm.Repositorio
{
    /// <summary>
    /// Objective: This class conect to CRM organization using Microsoft.Xrm.Tooling.Connector.
    /// Autor: Silvio Jose de Souza
    /// </summary>
    public class Contexto
    {
        private static OrganizationServiceProxy _serviceProxy;
        private static object syncRoot = new Object();

        public static OrganizationServiceProxy Proxy
        {
            get
            {
                if (_serviceProxy == null)
                {
                    lock (syncRoot)
                    {
                        var conn = new CrmServiceClient(ConfigurationManager.AppSettings["Username"],
                        CrmServiceClient.MakeSecureString(ConfigurationManager.AppSettings["Password"]),
                       ConfigurationManager.AppSettings["Region"], ConfigurationManager.AppSettings["Orgname"],
                        useUniqueInstance: true,
                       useSsl: true, isOffice365: true);

                        if (!conn.IsReady)
                        {
                            throw new ApplicationException(conn.LastCrmError);
                        }
                        _serviceProxy = conn.OrganizationServiceProxy;
                        _serviceProxy.EnableProxyTypes();
                    }
                }
                return _serviceProxy;
            }
        }

    }
}