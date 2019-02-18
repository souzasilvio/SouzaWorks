using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xrm.Sdk;
using System.ServiceModel.Description;
using Microsoft.Xrm.Sdk.Client;
using System.Configuration;
using Microsoft.Xrm.Tooling.Connector;

namespace CRM.Plugins.Tests
{
    public class TestServiceFactory : IOrganizationServiceFactory
    {
        private static OrganizationServiceProxy _serviceProxy;
        public IOrganizationService CreateOrganizationService(Guid? userId)
        {
            if (_serviceProxy == null)
            {
                var conn = new CrmServiceClient(ConfigurationManager.ConnectionStrings["Crm365"].ConnectionString);
                if (!conn.IsReady)
                {
                    throw new ApplicationException(conn.LastCrmError);
                }
                _serviceProxy = conn.OrganizationServiceProxy;
                _serviceProxy.EnableProxyTypes();
            }
            return _serviceProxy;
        }
     
    }
}
