using System;
using System.Linq;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Crm.Model;

namespace Crm.Dominio
{
    /// <summary>
    /// Métodos complementares especializados
    /// </summary>
    /// <typeparam name="EntityType"></typeparam>
    public partial class RepositorioBase<EntityType> : IDisposable where EntityType : Entity
    {
        
        /// <summary>
        /// Lista registros com statecode Ativo (valor zero)
        /// </summary>
        /// <param name="atributos"></param>
        /// <returns></returns>
         public EntityCollection ListarAtivos(ColumnSet atributos, OrderExpression ordem = null)
         {
             return ListarAtivos(NomeLogico, atributos, ordem);
         }

        public EntityCollection ListarAtivos(string entidade, ColumnSet atributos, OrderExpression ordem = null)
        {
            var query = new QueryExpression(entidade);
            query.Criteria.AddCondition("statecode", ConditionOperator.Equal, Constantes.StateAtivo);
            query.ColumnSet = atributos;
            if (ordem != null)
                query.Orders.Add(ordem);
            return this.RetrieveMultiple(query);
        }

        public virtual EntityType ObterPorFiltro(string atributoFiltro, object valorFiltro, params string[] atributos)
         {
             var colecao = ListarPorFiltro(NomeLogico, atributoFiltro, valorFiltro, atributos);                
             if (colecao.Entities.Count > 0)
                 return colecao.Entities[0] as EntityType;
             else
                 return null;
        }

        public virtual EntityType ObterPorFiltro(string entidade, string atributoFiltro, object valorFiltro, params string[] atributos)
        {
            var colecao = ListarPorFiltro(entidade, atributoFiltro, valorFiltro, atributos);
            if (colecao.Entities.Count > 0)
                return colecao.Entities[0] as EntityType;
            else
                return null;
        }

        public virtual EntityCollection ListarPorFiltro(string entidade, string atributoFiltro, object valorFiltro, params string[] atributos)
        {

            var query = new QueryExpression(entidade);
            query.Criteria.AddCondition("statecode", ConditionOperator.Equal, Constantes.StateAtivo);
            query.Criteria.AddCondition(atributoFiltro, ConditionOperator.Equal, valorFiltro);
            query.ColumnSet.AddColumns(atributos);
            return this.RetrieveMultiple(query);
        }




    }
}
