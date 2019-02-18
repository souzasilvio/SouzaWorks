using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xrm.Sdk;
using Microsoft.Crm.Sdk.Messages;

namespace CRM.Plugins.Tests
{
    public class TestPluginContext : IPluginExecutionContext
    {
        public TestPluginContext()
        {
            this.InputParameters = new ParameterCollection();
            this.OutputParameters = new ParameterCollection();
            this.PreEntityImages = new EntityImageCollection();
            this.PostEntityImages = new EntityImageCollection();

            //set the userid and the orgid on the context
            IOrganizationService service = new TestServiceFactory().CreateOrganizationService(null);
           
            WhoAmIResponse whoAmI = (WhoAmIResponse)service.Execute(new WhoAmIRequest());
            this.InitiatingUserId = whoAmI.UserId;
            this.OrganizationId = whoAmI.OrganizationId;


        }


        public IPluginExecutionContext ParentContext { get; set; }
        public int Stage { get; set; }
        public Guid BusinessUnitId { get; set; }
        public Guid CorrelationId { get; set; }
        public int Depth { get; set; }
        public Guid InitiatingUserId { get; set; }
        public ParameterCollection InputParameters { get; set; }
        public bool IsExecutingOffline { get; set; }
        public bool IsInTransaction { get; set; }
        public bool IsOfflinePlayback { get; set; }
        public int IsolationMode { get; set; }
        public string MessageName { get; set; }
        public int Mode { get; set; }
        public DateTime OperationCreatedOn { get; set; }
        public Guid OperationId { get; set; }
        public Guid OrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public ParameterCollection OutputParameters { get; set; }
        public EntityReference OwningExtension { get; set; }
        public EntityImageCollection PostEntityImages { get; set; }
        public EntityImageCollection PreEntityImages { get; set; }
        public Guid PrimaryEntityId { get; set; }
        public string PrimaryEntityName { get; set; }
        public Guid? RequestId { get; set; }
        public string SecondaryEntityName { get; set; }
        public ParameterCollection SharedVariables { get; set; }
        public Guid UserId { get; set; }
    }
}
