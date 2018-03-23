using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;

namespace Crm.Plugins
{
    /// <summary>
    /// Plugin base. Use as a base class to all plugins. Check some samples to know how to use.
    /// Note: This classe is based on code published on communit. Thanks to orignal autor.
    /// </summary>
    public abstract class PluginBase : IPlugin
    {
        public const string NomeImagePre = "IMAGEPRE";
        public const string NomeImagePos = "IMAGEPOS";
        public enum Mensagem { Create, Update, Delete, Win, Lose, Close };
        public enum Stagio { PreValidacao = 10, PreEvento = 20, PosEvento = 40 };

        private IOrganizationServiceFactory _serviceFactory;
        public IOrganizationServiceFactory ServiceFactory
        {
            get { return _serviceFactory; }
            set { _serviceFactory = value; }
        }

        private IPluginExecutionContext _context;
        public IPluginExecutionContext Contexto
        {
            get { return _context; }
            set { _context = value; }
        }

        private ITracingService tracingService;
        public ITracingService TracingService
        {
            get { return tracingService; }
            set { this.tracingService = value; }
        }


        private IOrganizationService _service;
        public IOrganizationService Service
        {
            get { return _service; }
            set { this._service = value; }
        }

        /// <summary>
        /// Retorna entidade objeto do plugin
        /// </summary>
        public Entity EntidadeContexto
        {
            get { return (Entity)this.Contexto.InputParameters["Target"]; }
        }

        public Object ObterAtributo(string campo)
        {
            return this.EntidadeContexto.Contains(campo) ? this.EntidadeContexto[campo] : null;
        }

        public void Execute(IServiceProvider serviceProvider)
        {
            try
            {
                this.Contexto = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
                this.TracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
                this.ServiceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                this.Service = this.ServiceFactory.CreateOrganizationService(this.Contexto.UserId);
                OnExecute();
            }
            catch (Exception ex)
            {
                try
                {
                    OnError(ex);
                }
                catch {
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
        /// Retrieve a record on the fly based on a simple filter
        /// </summary>
        /// <param name="entityName">Entity to Query</param>
        /// <param name="fieldToFilter">Field to query</param>
        /// <param name="valueToFilter">Value to query exact match</param>
        /// <param name="atributos">Fields to return</param>
        /// <returns></returns>
        public Entity GetRecordByFilter(string entityName, string fieldToFilter, object valueToFilter, params string[] atributos)
        {
            var colecao = GetCollectionByFilter(entityName, fieldToFilter, valueToFilter, atributos);
            if (colecao.Entities.Count > 0)
                return colecao.Entities[0];
            else
                return null;
        }

        /// <summary>
        /// Return a collection by exact filter
        /// </summary>
        /// <param name="entityName">Entity to query</param>
        /// <param name="fieldToFielter">Field to filter</param>
        /// <param name="valueToFilter">Value to filter on field. Exact Match</param>
        /// <param name="atributos">Fields to return</param>
        /// <returns></returns>
        public EntityCollection GetCollectionByFilter(string entityName, string fieldToFilter, object valueToFilter, params string[] atributos)
        {
            var query = new QueryExpression(entityName);
            query.ColumnSet.AddColumns(atributos);
            query.Criteria.AddCondition(fieldToFilter, ConditionOperator.Equal, valueToFilter);
            return Service.RetrieveMultiple(query);
        }

    }
}
