using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Workflow;
using System;
using System.Activities;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Crm.WorkFlows
{
    public abstract class WorkFlowBase : CodeActivity
    {


        private ITracingService tracingService;
        public ITracingService TracingService
        {
            get { return tracingService; }
            set { tracingService = value; }
        }

        private IWorkflowContext _context;
        public IWorkflowContext Context
        {
            get { return _context; }
            set { _context = value; }
        }

        private IOrganizationServiceFactory serviceFactory;
        public IOrganizationServiceFactory ServiceFactory
        {
            get { return serviceFactory; }
            set { serviceFactory = value; }
        }

        private IOrganizationService service;
        public IOrganizationService Service
        {
            get { return service; }
            set { service = value; }
        }

        private CodeActivityContext _executionContext;
        public CodeActivityContext ExecutionContext
        {
            get { return _executionContext; }
            set { _executionContext = value; }
        }

        protected override void Execute(CodeActivityContext executionContext)
        {
            try
            {
                this.ExecutionContext = executionContext;
                //Create the tracing service
                this.TracingService = executionContext.GetExtension<ITracingService>();
                //Create the context
                this.Context = executionContext.GetExtension<IWorkflowContext>();
                this.ServiceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
                this.Service = serviceFactory.CreateOrganizationService(this.Context.UserId);

                OnExecute();
            }
            catch (Exception ex)
            {
                try
                {
                    OnError(ex);
                }
                catch
                {
                }

                throw;
            }
            finally
            {
                OnCleanup();
            }
        }

        // Todos as classes herdadas devem fazer o override deste metodo
        protected abstract void OnExecute();

        // method is virtual so if an inheriting class wishes to do something different, they can
        protected virtual void OnError(Exception ex)
        {
            // Perform logging how ever you log:
            //Logger.Write(ex);
        }

        /// <summary>
        /// Cleanup resources.
        /// </summary>
        protected virtual void OnCleanup()
        {
            // Allows inheriting class to perform any cleaup after the plugin has executed and any exceptions have been handled
        }

        public void Trace(string mensagem, params object[] args)
        {
            if (this.TracingService != null)
                this.TracingService.Trace(mensagem, args);
        }

        /// <summary>
        /// retorna o array de bytes de um stream
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] LerStream(Stream input)
        {
            byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }
    }
}
