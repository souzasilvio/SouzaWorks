using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using Microsoft.Xrm.Sdk.Messages;
using Crm.Model;

namespace Crm.Repositorio
{
    /// <summary>
    /// Repositorio geral para qualquer entity.     
    /// </summary>
    /// remarks
    /// Nem toda entidade precisa de um repositorio especifico se o sistema fizer openas
    /// operações basicas de create, delete, update sobre ela
    public class RepositorioEntity : RepositorioBase<Entity>
    {
        #region singleton intancia
        private static volatile RepositorioEntity _instance;
        private static object syncRoot = new Object();

        private RepositorioEntity() { }
        public static RepositorioEntity Instancia
        {
            get
            {
                if (_instance == null)
                {
                    lock (syncRoot)
                    {
                        if (_instance == null)
                            _instance = new RepositorioEntity();
                    }
                }

                return _instance;
            }
        }

        #endregion

        /// <summary>
        /// Retorna equipe do usuario com nome da equipe na entidade alias
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns></returns>
        public EntityCollection ObterEquipesUsuario(Guid idUsuario)
        {
            var helper = new QueryExpression(TeamMembership.EntityLogicalName);
            helper.Criteria.AddCondition("systemuserid", ConditionOperator.Equal, idUsuario);
            helper.ColumnSet = new ColumnSet(true);
            var lkTeam = helper.AddLink(Team.EntityLogicalName, "teamid", "teamid");
            lkTeam.EntityAlias = "tt";
            lkTeam.Columns.AddColumn("name");
            return Contexto.Proxy.RetrieveMultiple(helper);
        }


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
            query.Criteria.AddCondition("statecode", ConditionOperator.Equal, Constantes.State_Active);
            query.ColumnSet = atributos;
            if (ordem != null)
                query.Orders.Add(ordem);
            return RetrieveMultiple(query);
        }

        
        //public virtual EntityType ObterPorFiltro(string atributoFiltro, object valorFiltro, params string[] atributos)
        //{
        //    var colecao = ListarPorFiltro(NomeLogico, atributoFiltro, valorFiltro, atributos);
        //    if (colecao.Entities.Count > 0)
        //        return colecao.Entities[0] as EntityType;
        //    else
        //        return null;
        //}

        //public virtual EntityType ObterPorFiltro(string entidade, string atributoFiltro, object valorFiltro, params string[] atributos)
        //{
        //    var colecao = ListarPorFiltro(entidade, atributoFiltro, valorFiltro, atributos);
        //    if (colecao.Entities.Count > 0)
        //        return colecao.Entities[0] as EntityType;
        //    else
        //        return null;
        //}

        public virtual EntityCollection ListarPorFiltro(string entidade, string atributoFiltro, object valorFiltro, params string[] atributos)
        {

            var query = new QueryExpression(entidade);
            query.Criteria.AddCondition("statecode", ConditionOperator.Equal, Constantes.State_Active);
            query.Criteria.AddCondition(atributoFiltro, ConditionOperator.Equal, valorFiltro);
            query.ColumnSet.AddColumns(atributos);
            return this.RetrieveMultiple(query);
        }

    }
}
