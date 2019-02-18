using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;

namespace CRM.Plugins.Tests
{
    /// <summary>
    /// Summary description for UnitTest2
    /// </summary>
    [TestClass]
    public class UnitTest2
    {
        public UnitTest2()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {

            var entidade = new Entity();
            entidade.LogicalName = "account";
            entidade["name"] = "Conta teste";

            var pluginContext = new TestPluginContext();
            var provider = new TesteServiceProvider(pluginContext);
            


            pluginContext.InputParameters["Target"] = entidade;
            pluginContext.PrimaryEntityName = "account";
            pluginContext.MessageName = "SetState";
            pluginContext.Stage = (int)TesteServiceProvider.Stagio.PreEvento;
            

            var plugin = new Crm.Plugins.Account.TesteSetState();
            plugin.Execute(provider);
        }
    }
}
