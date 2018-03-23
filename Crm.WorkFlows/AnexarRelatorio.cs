using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Workflow;
using System;
using System.Activities;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Crm.WorkFlows
{
    public class AnexarRelatorio : WorkFlowBase
    {
        [Input("URL Relatorio")]
        public InArgument<string> URLRelatorio { get; set; }


        [Input("ID Entidade")]
        public InArgument<string> IDEntidade { get; set; }

        [Input("Nome Entidade")]
        public InArgument<string> NomeEntidade { get; set; }

        [Input("Nome Anexo")]
        public InArgument<string> NomeAnexo { get; set; }

        private Stream ObterConteudo(string url)
        {
            Stream streamOut = null;
            try
            {
                var req = HttpWebRequest.Create(url) as HttpWebRequest;
                req.Credentials = CredentialCache.DefaultCredentials;
                //req.KeepAlive = true;
                //// Criar requisição com usuário padrão do arquivo de configuração do CRM
                //var cred = new NetworkCredential();
                //var informacaoLogin = ObterLogon(_servico);
                //cred.Domain = informacaoLogin.Dominio;
                //cred.UserName = informacaoLogin.Login;
                //cred.Password = Utility.Decrypt(informacaoLogin.Senha);
                //req.Credentials = System.Threading.c;
                
                //req.Credentials = cred;
                var response = req.GetResponse() as HttpWebResponse;
                using (Stream stream = response.GetResponseStream())
                {
                    byte[] data = null;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        stream.CopyTo(ms);
                        data = ms.ToArray();
                    }
                    streamOut = new MemoryStream(data);
                }

            }
            catch
            {
                throw;
            }


            return streamOut;
        }

        private Guid AnexarPDF(EntityReference referencia, string nome, byte[] conteudo)
        {
            var anotacao = new Entity("annotation");
            anotacao["subject"] = nome;
            anotacao["filename"] = nome;
            anotacao["documentbody"] = Convert.ToBase64String(conteudo);
            anotacao["mimetype"] = "application/pdf";
            anotacao["objectid"] = referencia;
            return Service.Create(anotacao);
        }

        

        protected override void OnExecute()
        {
            string url = string.Format(URLRelatorio.Get<string>(ExecutionContext), IDEntidade.Get<string>(ExecutionContext) );
            Stream conteudo = ObterConteudo(url);
            var pdf = LerStream(conteudo);
            var referencia = new EntityReference(NomeEntidade.Get<string>(ExecutionContext), new Guid(IDEntidade.Get<string>(ExecutionContext)));
            AnexarPDF(referencia, NomeAnexo.Get<string>(ExecutionContext), pdf);
        }
    }
}
