using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Workflow;
using System;
using System.Activities;

namespace Crm.WorkFlows
{
    /// <summary>
    /// Return a boolean argument if a incident have a related opened activity.
    /// This is usefull to create workflow that should close a incident on some point of process.
    /// </summary>
    public class GetOpenActivity : CodeActivity
    {
        [Input("Inform the incident record of process")]        
        [ReferenceTarget("incident")]
        public InArgument<EntityReference> Ocorrencia { get; set; }

        [Output("Have opened activity")]   
        [Default("False")]    
        public OutArgument<Boolean> OpenedActivity { get; set; }

        protected override void Execute(CodeActivityContext executionContext)
        {
            //Obter objetos uteis do contexto
            var servicoTrace = executionContext.GetExtension<ITracingService>();
            IWorkflowContext WfContext = executionContext.GetExtension<IWorkflowContext>();
            IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();            
            IOrganizationService _orgService = serviceFactory.CreateOrganizationService(WfContext.InitiatingUserId);

            //Obter parametros de entrada
            EntityReference ocorrenciaOperacao = Ocorrencia.Get<EntityReference>(executionContext);
            servicoTrace.Trace($"Incident of input :{ocorrenciaOperacao.Id}");

            QueryExpression query = new QueryExpression("activitypointer");
            query.Criteria.AddCondition("regardingobjectid", ConditionOperator.Equal, ocorrenciaOperacao.Id);
            //Filter of Open/Scheduled status code
            query.Criteria.AddCondition("statuscode", ConditionOperator.In, new string[] { "1", "4" }); 
            EntityCollection colecao = _orgService.RetrieveMultiple(query);
            bool possuiAberto = colecao.Entities.Count > 0;
            //Return of result
            OpenedActivity.Set(executionContext, possuiAberto);

        }
    }
}
