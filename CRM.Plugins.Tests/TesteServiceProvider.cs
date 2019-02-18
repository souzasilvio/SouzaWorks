using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xrm.Sdk;

namespace CRM.Plugins.Tests
{
    public class TesteServiceProvider : IServiceProvider
    {
        public enum Stagio { PreValidacao = 10, PreEvento = 20, DuranteOperacao = 30, PosEvento = 40 };

        #region IServiceProvider Members
        private TestPluginContext _pluginContext;
        public TesteServiceProvider(TestPluginContext pluginContext)
        {
            _pluginContext = pluginContext;
        }

       public object GetService(Type serviceType)
       {
            if (serviceType == typeof(IPluginExecutionContext))
            {
                return _pluginContext;
            }
            if (serviceType == typeof(IOrganizationServiceFactory))
            {
                return new TestServiceFactory();
            }
            return null;
        }

        #endregion
    }
}
