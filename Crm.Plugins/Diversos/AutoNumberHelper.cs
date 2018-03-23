using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Messages;
using System.Collections.ObjectModel;

namespace Crm.Plugins
{
    /// <summary>
    /// Helper to autonumber creation
    /// Note: This code is totaly base on a public code from someone on develper community. Thanks to the original autor.
    /// </summary>
    public class AutoNumberHelper
    {
        
        private const string autoNumberEntity = "auto_numeracao";
        /// <summary>
        /// Name of entity created to control generated number.
        /// </summary>
        public const string entityLogicalName = Constantes.prefixoOrganizacao + autoNumberEntity;
        

        public class Fields
        {
            private const string atributoId = "id";
            //Fields to use in AutoNumber entity. Do not especify org prefix here.
            //Note: Create fields on your entity following above names
            /// <summary>
            /// Field to input the name of a target entity to gerenate a number when a record is created. Type string
            /// </summary>
            public const string campoEntidadeDestino = "entidade";

            /// <summary>
            /// Field to input the name of attibute to receive gerenated number. Type string
            /// </summary>
            public const string campoAtributoDestino = "atributo_destino";

            /// <summary>
            /// Field to receive last generated number. Type integer
            /// </summary>
            public const string campoNumero = "numero";

            /// <summary>
            /// Field to input a prefix if you wish. example: XTPTO. Your geneted number on target record will be XTPTO-001
            /// </summary>
            public const string campoPrefixo = "prefixo";

            /// <summary>
            /// Field to input a sufix if you wish. example: WPT. Your geneted number on target record will be XTPTO-001-WPT
            /// </summary>
            public const string campoPosfixo = "sufixo";

            public const string EntidadeDestino = Constantes.prefixoOrganizacao + campoEntidadeDestino;
            public const string AtributoDestino = Constantes.prefixoOrganizacao + campoAtributoDestino;
            public const string Numero = Constantes.prefixoOrganizacao + campoNumero;
            public const string Prefixo = Constantes.prefixoOrganizacao + campoPrefixo;
            public const string Postfixo = Constantes.prefixoOrganizacao + campoPosfixo;
        }

        public Guid Id { get; set; }
        public string EntidadeDestino { get; set; }
        public string AtributoDestino { get; set; }
        public int Numero { get; set; }
        public string Prefix { get; set; }
        public string Postfix { get; set; }

        public AutoNumberHelper() { }

        public AutoNumberHelper(Entity entity)
        {
            this.Id = entity.Id;
            this.EntidadeDestino = entity[Fields.EntidadeDestino].ToString();
            this.AtributoDestino = entity[Fields.AtributoDestino].ToString().ToLower();
            this.Numero = int.Parse(entity[Fields.Numero].ToString());

            if (entity.Contains(Fields.Prefixo))
            {
                this.Prefix = entity[Fields.Prefixo].ToString();
            }
            else
            {
                this.Prefix = "";
            }

            if (entity.Contains(Fields.Postfixo))
            {
                this.Postfix = entity[Fields.Postfixo].ToString();
            }
            else
            {
                this.Postfix = "";
            }
        }

        public void Increment(IOrganizationService service, int next)
        {
            this.Numero = next; 
            var entity = new Entity(AutoNumberHelper.entityLogicalName);
            entity.Id = this.Id;
            entity[Fields.Numero] = this.Numero;
            service.Update(entity);
        }

        // see if there are any increment settings for this entity
        public static AutoNumberHelper GetSettings(IOrganizationService service, string entityName)
        {
            AutoNumberHelper setting = null;

            QueryByAttribute query = new QueryByAttribute();
            query.Attributes.AddRange(new string[] { AutoNumberHelper.Fields.EntidadeDestino });
            query.ColumnSet = new ColumnSet(new string[] {AutoNumberHelper.Fields.EntidadeDestino, AutoNumberHelper.Fields.AtributoDestino, 
                    AutoNumberHelper.Fields.Numero, AutoNumberHelper.Fields.Prefixo, 
                    AutoNumberHelper.Fields.Postfixo });
            query.EntityName = AutoNumberHelper.entityLogicalName;
            query.Values.AddRange(new object[] { entityName });

            //Execute using a request to test the OOB (XRM) message contracts
            RetrieveMultipleRequest request = new RetrieveMultipleRequest();
            request.Query = query;
            Collection<Entity> entityList = ((RetrieveMultipleResponse)service.Execute(request)).EntityCollection.Entities;

            if (entityList.Count > 0) // no error checkig to see if there are 2 incrementors set for the same entity
            {
                setting = new AutoNumberHelper(entityList[0]);
            }

            return setting;
        }

    }
}
