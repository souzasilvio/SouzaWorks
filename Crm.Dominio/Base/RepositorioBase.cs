using System;
using System.Runtime.Caching;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Crm.Sdk.Messages;

namespace Crm.Dominio
{
    /// <summary>
    /// Metodos basicos
    /// </summary>
    /// <typeparam name="EntityType"></typeparam>
    public partial class RepositorioBase<EntityType> : IDisposable where EntityType : Entity
    {
        private System.Globalization.CultureInfo oCulture;
        private ObjectCache Cache = MemoryCache.Default;
        private CacheItemPolicy _cacheItemPolicy;
        private static object syncRoot = new Object();       
        
        public string NomeLogico
        {
            get
            {
                return typeof(EntityType).Name.ToLower();
            }
        }

        private CacheItemPolicy CacheItemPolicy
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
        /// Retorna a cultura pt-BR
        /// </summary>
        public System.Globalization.CultureInfo CulturaPadrao
        {
            get
            {
                if (oCulture == null)
                    oCulture = new System.Globalization.CultureInfo("pt-BR");
                return oCulture;
            }
        }

        /// <summary>
        /// Recupera um objeto do cache
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public Object ObterDoCache(string key)
        {
            if (Cache.Contains(key))
                return Cache.Get(key);
            else
                return null;        
        }

        /// <summary>
        /// Adiciona um objeto no cache com tempo definido na chave TempoCache do config
        /// </summary>
        /// <param name="key"></param>
        /// <param name="conteudo"></param>
        public void AdicionaCache(string key, object conteudo)
        {
            this.Cache.Add(key, conteudo, this.CacheItemPolicy);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                Contexto.Proxy.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }



        /// <summary>
        /// Retorna um registro por id
        /// </summary>
        /// <param name="id">ID do registro</param>
        /// <param name="useAllColumns">retornar todos os campos true/false</param>
        /// <returns></returns>
        public virtual EntityType Obter(Guid id, bool useAllColumns)
        {
            if (Contexto.Proxy.CallerId != Guid.Empty)
                Contexto.Proxy.CallerId = Guid.Empty;
            Microsoft.Xrm.Sdk.Query.ColumnSet colums = new Microsoft.Xrm.Sdk.Query.ColumnSet(useAllColumns);
            return Contexto.Proxy.Retrieve(this.NomeLogico, id, colums) as EntityType;
        }

        public Entity Obter(string nomeEntidade, Guid id, params string[] atributos)
        {
            if (Contexto.Proxy.CallerId != Guid.Empty)
                Contexto.Proxy.CallerId = Guid.Empty;
            return Contexto.Proxy.Retrieve(nomeEntidade, id, new Microsoft.Xrm.Sdk.Query.ColumnSet(atributos));
        }

        public Entity Obter(string nomeEntidade, Guid id, bool allCollumns)
        {
            if (Contexto.Proxy.CallerId != Guid.Empty)
                Contexto.Proxy.CallerId = Guid.Empty;
            return Contexto.Proxy.Retrieve(nomeEntidade, id, new Microsoft.Xrm.Sdk.Query.ColumnSet(allCollumns));
        }


        public Entity Obter(Guid id, params string[] atributos)
        {
            if (Contexto.Proxy.CallerId != Guid.Empty)
                Contexto.Proxy.CallerId = Guid.Empty;
            return Contexto.Proxy.Retrieve(this.NomeLogico, id, new Microsoft.Xrm.Sdk.Query.ColumnSet(atributos));
        }


        /// <summary>
        /// Cria um registro
        /// </summary>
        /// <param name="registro"></param>
        /// <param name="idUsuario"></param>
        /// <returns></returns>
        public Guid Criar(Entity registro, Guid idUsuario)
        {
            lock (syncRoot)
            {
               Contexto.Proxy.CallerId = idUsuario;
                    try
                    {
                        return Contexto.Proxy.Create(registro);
                    }
                    catch
                    {
                        throw;
                    }
                    finally
                    {
                        Contexto.Proxy.CallerId = Guid.Empty;                        
                    }
                
            }
            
        }


        public void Excluir(string nomeEntidade, Guid id, Guid idUsuario)
        {
            lock (syncRoot)
            {
                Contexto.Proxy.CallerId = idUsuario;
                try
                {
                    Contexto.Proxy.Delete(nomeEntidade, id);
                }
                catch
                {
                    throw;
                }
                finally
                {
                    Contexto.Proxy.CallerId = Guid.Empty;
                }
            }
        }

        /// <summary>
        /// Atualiza um registro 
        /// </summary>
        /// <param name="registro"></param>
        /// <param name="idUsuario"></param>
        public void Atualizar(Entity registro, Guid idUsuario)
        {
            lock (syncRoot)
            {
                Contexto.Proxy.CallerId = idUsuario;
                try
                {
                    Contexto.Proxy.Update(registro);
                }
                catch
                {
                    throw;
                }
                finally
                {
                    Contexto.Proxy.CallerId = Guid.Empty;
                }
            }
        }


         internal EntityCollection RetrieveMultiple(QueryExpression query)
         {
             return Contexto.Proxy.RetrieveMultiple(query);
         }

         internal EntityCollection RetrieveMultiple(string fetchXml)
         {
             return Contexto.Proxy.RetrieveMultiple(new FetchExpression(fetchXml));

         }

        internal OrganizationResponse Execute(OrganizationRequest request)
        {
            return Contexto.Proxy.Execute(request);
        }

        /// <summary>
        /// Retorna registros da entidade dado conjunto de atributos e condições
        /// </summary>
        /// <param name="atributos"></param>
        /// <param name="condicoes"></param>
        /// <returns></returns>
        internal EntityCollection RetrieveMultiple(ColumnSet atributos, params ConditionExpression[] condicoes)
         {
             var query = new QueryExpression(this.NomeLogico);            
             query.Criteria.Conditions.AddRange(condicoes);
             query.ColumnSet = atributos;
             return this.RetrieveMultiple(query);
         }

       
        
        public void SetState(string nomeEntidade, Guid id, int stateCode, int statusCode, Guid idUsuario)
        {
            lock (syncRoot)
            {
                var request = new SetStateRequest();
                request.State = new OptionSetValue(stateCode);
                request.Status = new OptionSetValue(statusCode);
                request.EntityMoniker = new EntityReference(nomeEntidade, id);

                Contexto.Proxy.CallerId = idUsuario;
                try
                {
                    Contexto.Proxy.Execute(request);
                }
                catch
                {
                    throw;
                }
                finally
                {
                    Contexto.Proxy.CallerId = Guid.Empty;
                }
            }

        }

        public void SetState(Guid id, int stateCode, int statusCode, Guid idUsuario)
        {
            SetState(NomeLogico, id, statusCode, statusCode, idUsuario);
        }
    }
}
