using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Plugins.Account
{
    /// <summary>
    /// Sample plugin to show how to use PluginBase.
    /// After undertand how to use this sample remove from your project before register to CRM
    /// </summary>
    public class TesteSetState : PluginBase, IPlugin
    {
        protected override void OnExecute()
        {
            if (Contexto.InputParameters.Contains("Target") &&
                Contexto.InputParameters["Target"] is Entity &&
                Contexto.Stage == (int)Stagio.PreEvento &&
                (Contexto.MessageName == "SetState" || Contexto.MessageName == "SetStateDynamicEntity") )
            {
                throw new InvalidPluginExecutionException("Teste - SetState acionado.");
            }
        }
    }
}
