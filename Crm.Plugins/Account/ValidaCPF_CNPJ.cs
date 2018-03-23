using Microsoft.Xrm.Sdk;

namespace Crm.Plugins.Account
{
    /*
     Autor: Silvio j souza
     Objetivo: Restrict duplicate account creation base on Brazil CPF/CNPJ number( like a US Social)
     How to use: On Account entity, Register one sync step on Pre-Create event and one sync step on pre-update envent.
     Note: This plugin target specif custom fields on account entity to enforce a businnes rule: There exist only on account with cpf/cnpj number on crm database.
    */
    public class ValidateUniqueCpfCnpj : PluginBase, IPlugin{

        private const string AtributoCPF = Constantes.prefixoOrganizacao + "cpf";
        private const string AtributoCNPJ = Constantes.prefixoOrganizacao + "cnpj";

        protected override void OnExecute()
        {
            if (Contexto.InputParameters.Contains("Target") &&
                Contexto.InputParameters["Target"] is Entity &&
                Contexto.Stage == (int)Stagio.PreEvento)
            {
                Entity entity = (Entity)Contexto.InputParameters["Target"];
                if (entity.LogicalName == Constantes.Cliente.EntityLogicalName && 
                   (entity.Contains(AtributoCNPJ) || entity.Contains(AtributoCPF) ) )
                {
                    Trace("Begin of account validation."); 
                    string cpf = entity.Attributes.Contains(AtributoCPF) ? entity[AtributoCPF].ToString() : string.Empty;
                    string cnpj = entity.Attributes.Contains(AtributoCNPJ) ? entity[AtributoCNPJ].ToString() : string.Empty;
                    Trace($"CPF Field: {cpf}" );
                    Trace($"CNPJ Field: {cnpj}");
                    if (!string.IsNullOrEmpty(cpf))
                    {
                        var cliente = GetRecordByFilter(Constantes.Cliente.EntityLogicalName, AtributoCPF, cpf, "name");
                        //Return exception to inform that already exist a record with a cpf number.
                        if (cliente != null)
                            throw new InvalidPluginExecutionException("já existe um cliente com o CPF informado.");
                    }
                    if (!string.IsNullOrEmpty(cnpj))
                    {
                        var cliente = GetRecordByFilter(Constantes.Cliente.EntityLogicalName, AtributoCNPJ, cnpj, "name");
                        //Return exception to inform that already exist a record with a cnpj number.
                        if (cliente != null)
                            throw new InvalidPluginExecutionException("já existe um cliente com o CNPJ informado.");
                    }
                   
                }
            }
        }
    }
  }
