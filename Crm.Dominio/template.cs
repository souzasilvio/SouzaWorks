using System;
using Crm.Model;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk;

namespace Crm.Dominio
{
    /// <summary>
    /// Objective: Copy this class to start a new domain class
    /// Autor: Silvio Jose de Souza
    /// </summary>
    public class  Template : Base.DominioBase
    {
        #region singleton intancia
        private static volatile Template _instance;
        private static object syncRoot = new Object();

        private Template() { }
        public static Template Instancia
        {
            get
            {
                if (_instance == null)
                {
                    lock (syncRoot)
                    {
                        if (_instance == null)
                            _instance = new Template();
                    }
                }

                return _instance;
            }
        }
        #endregion
              
    }
}
