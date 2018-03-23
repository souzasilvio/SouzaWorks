namespace Crm.WorkFlows
{
    using System;
    using System.Activities;
    using System.ServiceModel;
    using Microsoft.Xrm.Sdk;
    using Microsoft.Xrm.Sdk.Workflow;
        
    /// <summary>
    /// Custom Activity to set default pricelist on opportunity
    /// </summary>
    public sealed class ConfiguraOportunidade : WorkFlowBase
    {
        protected override void OnExecute()
        {   
            //Atualiza lista de preço na oportunidade
            this.Trace("Atualizando lista de preço na oportunidade.");            
            Entity op = new Entity("opportunity");
            op.Id = Oportunidade.Get<EntityReference>(this.ExecutionContext).Id;
            op["pricelevelid"] = ListaPreco.Get<EntityReference>(this.ExecutionContext);
            this.Service.Update(op);

            this.Trace("Criando registro opportunityproduct.");
            Entity oOppProduct = new Entity("opportunityproduct");
            oOppProduct["opportunityid"] = Oportunidade.Get<EntityReference>(this.ExecutionContext);
            oOppProduct["productid"] = Produto.Get<EntityReference>(this.ExecutionContext);
            oOppProduct["quantity"] = new Decimal(1);
            oOppProduct["uomid"] = this.UnidadePadrao.Get<EntityReference>(this.ExecutionContext);
            this.Service.Create(oOppProduct);
        }

        [Input("Produto")]
        [ReferenceTarget("product")]
        public InArgument<EntityReference> Produto { get; set; }

        [Input("Oportunidade")]
        [ReferenceTarget("opportunity")]
        public InArgument<EntityReference> Oportunidade { get; set; }

        [Input("Unidade Padrão")]
        [ReferenceTarget("uom")]
        public InArgument<EntityReference> UnidadePadrao { get; set; }

        [Input("Lista de Preços")]
        [ReferenceTarget("pricelevel")]
        public InArgument<EntityReference> ListaPreco { get; set; }

    }
}