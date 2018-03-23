using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xrm.Sdk;
using System.Threading;

namespace Crm.Plugins
{
    /// <summary>
    /// Plugin to do number generation to any entity (like we have on quote and contract)
    /// How to use: 
    /// 1. Edit variable prefixoOrganizacao on the Comum/Contantant.cs to the your organization prefix.
    /// 2. Create a curtom entity to controling autonumber generation. In AutoNumeracaoHelper.cs we difene this entity as auto_numeracao. You can change this.
    /// 3. Add to auto_numeracao entiy some attributes according AutoNumeracaoHelper.cs especification. Add all attributes created to the main form.
    /// 4  Create a record on the autonumer entity. Complete all requird fields.
    /// 5. Using plugin registration tool add one create-pre sync step to any entity with you wish generated a number. 
    /// Of course the target entity must have be a field to receive the number create by this plugin.
    /// </summary>
    public class AutoNumber : PluginBase, IPlugin
    {

        private static readonly object SyncLock = new object();

        protected override void OnExecute()
        {            
            if (Contexto.InputParameters.Contains("Target") &&
                Contexto.InputParameters["Target"] is Entity &&
                Contexto.Stage == (int)Stagio.PreEvento)
            {
                Entity entity = Contexto.InputParameters["Target"] as Entity;
                lock (SyncLock)
                {
                    try
                    {
                        var setting = AutoNumberHelper.GetSettings(this.Service, entity.LogicalName);
                        if (setting != null)
                        {
                            string valorAtual = entity.Contains(setting.AtributoDestino) ? entity[setting.AtributoDestino] as string : string.Empty;
                            if (string.IsNullOrEmpty(valorAtual))
                            {
                                int next = setting.Numero + 1;
                                string nextAlternateClientNumber = $"{setting.Prefix}-{next}-{setting.Postfix}";
                                if (entity.Contains(setting.AtributoDestino))
                                {
                                    entity[setting.AtributoDestino] = nextAlternateClientNumber;
                                }
                                else
                                {
                                    entity.Attributes.Add(setting.AtributoDestino, nextAlternateClientNumber);
                                }
                                setting.Increment(this.Service, next);
                            }                          
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new InvalidPluginExecutionException(ex.ToString());
                    }

                }
            }
          

        }
    }
}
