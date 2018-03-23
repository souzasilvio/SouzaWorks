using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Dominio.Base
{
    public class DominioBase
    {
        public ObjectCache Cache = MemoryCache.Default;
        private CacheItemPolicy _cacheItemPolicy;
        public CacheItemPolicy CacheItemPolicy
        {
            get
            {
                if (_cacheItemPolicy == null)
                {
                    _cacheItemPolicy = new CacheItemPolicy();
                    int tempoCache;
                    try
                    {
                        tempoCache = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["TempoCache"]);
                    }
                    catch
                    {
                        tempoCache = 10;
                    }
                    _cacheItemPolicy.AbsoluteExpiration = DateTime.Now.AddMinutes(tempoCache);
                }
                return _cacheItemPolicy;
            }
        }


        /// <summary>
        /// Retorna um registro pelo id
        /// </summary>
        /// <param name="nomeEntidade">nome logico da entidade</param>
        /// <param name="id">id do registro</param>
        /// <param name="atributos">campos de retorno</param>
        /// <returns></returns>
        public Entity Obter(string nomeEntidade, Guid id, params string[] atributos)
        {
            return Repositorio.RepositorioEntity.Instancia.Obter(nomeEntidade, id, atributos);
        }

        public Entity Obter(string nomeEntidade, Guid id, bool allCollumns)
        {
            return Repositorio.RepositorioEntity.Instancia.Obter(nomeEntidade, id, allCollumns);
        }

        /// <summary>
        /// Retorna o primeiro registro ativo localizado por atributo de filtro
        /// </summary>
        /// <param name="nomeEntidade">Entidade de consulta</param>
        /// <param name="campoFiltro">Campo de filtro</param>
        /// <param name="valorFiltro">Valor de filtro (Condição Equal)</param>
        /// <param name="atributos">Campos de retorno</param>
        /// <returns></returns>
        public Entity ObterPorFiltro(string nomeEntidade, string campoFiltro,  object valorFiltro, params string[] atributos)
        {
            var colecao = Listar(nomeEntidade, campoFiltro, valorFiltro, atributos);
            if (colecao.Entities.Count > 0)
                return colecao[0];
            else
                return null;
        }


        /// <summary>
        /// Create a entity record
        /// </summary>
        /// <param name="registro">Entity Record</param>
        /// <param name="userId">User id to inpersonate or Guid.Empty</param>
        /// <returns></returns>
        public Guid Create(Entity registro, Guid userId = new Guid())
        {
           return Repositorio.RepositorioEntity.Instancia.Create(registro, userId);
        }

        /// <summary>
        /// Atualiza um registro
        /// </summary>
        /// <param name="registro">Entity</param>
        /// <param name="idUsuario">Usuario</param>
        public void Atualizar(Entity registro, Guid idUsuario = new Guid())
        {
            Repositorio.RepositorioEntity.Instancia.Atualizar(registro, idUsuario);
        }

        /// <summary>
        /// Delete a record
        /// </summary>
        /// <param name="id">Record Id</param>
        /// <param name="userId">User to inpersonate</param>
        public void Delete(string entityName, Guid id, Guid userId = new Guid())
        {
            Repositorio.RepositorioEntity.Instancia.Delete(entityName, id, userId);
        }

        /// <summary>
        /// Executa uma query
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public EntityCollection RetrieveMultiple(QueryExpression query)
        {
            return Repositorio.RepositorioEntity.Instancia.RetrieveMultiple(query);
        }

        /// <summary>
        /// Retorna todos os registros com filtro opcional
        /// </summary>
        /// <param name="nomeEntidade">Entidade de consulta</param>
        /// <param name="campoFiltro">campo filtro ou null para nao filtar</param>
        /// <param name="valorFiltro">valor filtro ou null para nao filtrar</param>
        /// <param name="atributos">campos de retorno</param>
        /// <returns></returns>
        public EntityCollection Listar(string nomeEntidade, string campoFiltro, object valorFiltro, params string[] atributos)
        {
            var query = new QueryExpression(nomeEntidade);
            query.ColumnSet.AddColumns(atributos);
            if (!string.IsNullOrEmpty(campoFiltro) && valorFiltro != null)
                query.Criteria.AddCondition(campoFiltro, ConditionOperator.Equal, valorFiltro);
            query.Criteria.AddCondition("statecode", ConditionOperator.Equal, Model.Constantes.State_Active);
            return RetrieveMultiple(query);
        }

        public Object ObterDoCache(string key)
        {
            if (Cache.Contains(key))
                return Cache.Get(key);
            else
                return null;
        }
        public void AdicionaCache(string key, object conteudo)
        {
            Cache.Add(key, conteudo, this.CacheItemPolicy);
        }

        /// <summary>
        /// Altera o state de um registro
        /// </summary>
        /// <param name="nomeEntidade"></param>
        /// <param name="id"></param>
        /// <param name="stateCode"></param>
        /// <param name="statusCode"></param>
        /// <param name="idUsuario"></param>
        public void SetState(string nomeEntidade, Guid id, int stateCode, int statusCode, Guid idUsuario)
        {
            Repositorio.RepositorioEntity.Instancia.SetState(nomeEntidade, id, stateCode, statusCode, idUsuario);
        }

        public bool UsuarioPossuiPermissao(string idusuario, string equipe)
        {
            return ContemPerfil(idusuario, equipe);
        }

        private bool ContemPerfil(string id, string nomePerfil)
        {
            List<Model.Equipe> equipes = ObterEquipesPorUsuario(id);
            var perfisComPermissao = from eq in equipes
                                     where eq.Nome == nomePerfil
                                     select eq;
            return perfisComPermissao.Count() > 0;
        }

        private List<Model.Equipe> ObterEquipesPorUsuario(string idusuario)
        {
            var resultado = new List<Model.Equipe>();
            try
            {

                string key = string.Format("EQUIPES_{0}", idusuario);
                resultado = (List<Model.Equipe>)this.ObterDoCache(key);
                if (resultado == null)
                {
                    resultado = new List<Model.Equipe>();
                    EntityCollection colecao = Repositorio.RepositorioEntity.Instancia.ObterEquipesUsuario(new Guid(idusuario));
                    foreach (Model.TeamMembership item in colecao.Entities)
                    {
                        if (item.Attributes.Contains("tt.name"))
                        {
                            var cpNome = (AliasedValue)item["tt.name"];
                            var reg = new Model.Equipe() { Id = item.TeamId.Value, Nome = (string)cpNome.Value};
                            resultado.Add(reg);
                        }

                    }
                    if (resultado.Count > 0)
                        this.AdicionaCache(key, resultado);
                }
            }
            catch
            {
                throw;
            }
            return resultado;
        }
        
        public Entity ObterUnidadePadrao()
        {
            var query = new QueryExpression(Model.UoM.EntityLogicalName);
            var colecao = Repositorio.RepositorioEntity.Instancia.RetrieveMultiple(query);
            if (colecao.Entities.Count == 0)
                throw new Exception("Não existe unidade padrão cadastrada no sistema.");
            return colecao.Entities.First();
        }

        public Entity ObterMoedaPadrao()
        {
            var query = new QueryExpression(Model.TransactionCurrency.EntityLogicalName);
            query.Criteria.AddCondition("isocurrencycode", ConditionOperator.Equal, "BRL");
            var colecao = Repositorio.RepositorioEntity.Instancia.RetrieveMultiple(query);
            if (colecao.Entities.Count == 0)
                throw new Exception("Não existe moeda padrão cadastrada no sistema.");
            return colecao.Entities.First();
        }

        public Entity ObterGrupoUnidadesPadrao()
        {
            var query = new QueryExpression(Model.UoMSchedule.EntityLogicalName);
            var colecao = Repositorio.RepositorioEntity.Instancia.RetrieveMultiple(query);
            if (colecao.Entities.Count == 0)
                throw new Exception("Não existe grupo de unidades padrão cadastrada no sistema.");
            return colecao.Entities.First();
        }

        /// <summary>
        /// Update a collection of records
        /// </summary>
        /// <param name="colecao"></param>
        public void UpdateCollection(EntityCollection colecao)
        {
            //If quantity up to batchSize limmit do one by one, else use one transaction request
            if (colecao.Entities.Count > 1000)
            {
                foreach (Entity registro in colecao.Entities)
                    Repositorio.RepositorioEntity.Instancia.Atualizar(registro, Guid.Empty);
            }
            else
            {
                var requestGroup = new ExecuteTransactionRequest() { Requests = new OrganizationRequestCollection(), ReturnResponses = false };
                foreach (Entity registro in colecao.Entities)
                {
                    var updateRequest = new UpdateRequest() { Target = registro };
                    requestGroup.Requests.Add(updateRequest);
                }
                Repositorio.RepositorioEntity.Instancia.Execute(requestGroup);
            }
        }



    }
}
