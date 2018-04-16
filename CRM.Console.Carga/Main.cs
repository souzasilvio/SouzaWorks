using Crm.Dominio;
using Microsoft.Xrm.Sdk;
using System;

namespace CRM.Console.Carga
{
    /// <summary>
    /// Objective: Use this program to create temporary tasks like update and load crm data. 
    /// Any task with require massive interaction on crm data.
    /// This program must run on your local machine. Do not deploy do CRM server or production enviroment.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CreateTems();
                CreateContacts();
                UpdateContacts();
                DeleteContacts();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }

     
        private static void CreateTems()
        {
            try
            {
                //Create Team with a specific guid.
                //This guid could be used later as constant in project to perform query in teammembership

                //Search for root businesunit to use for create a team
                var lista = SalesDomain.Instancia.Listar(Crm.Model.BusinessUnit.EntityLogicalName, "name", "mrv", false, "name");
                if (lista.Entities.Count > 0)
                {
                    var team = new Crm.Model.Team();
                    team.Id = new Guid("00000000-0000-0000-0000-000000000001");
                    team.Name = "Equipe 1";
                    team.BusinessUnitId = lista[0].ToEntityReference();
                    Guid id = SalesDomain.Instancia.Create(team);
                }
            }
            catch (Exception ex)
            {
                //Let error be if team alread exists
                System.Console.WriteLine(ex.Message);

            }
        }



        //Create Sample Contact
        private static void CreateContacts()
        {

            for (int i = 1; i <= 10; i++)
            {
                var contact = new Crm.Model.Contact();
                contact.FirstName = "Sample";
                contact.LastName  = $"Contact {i}";
                Guid id = SalesDomain.Instancia.Create(contact);
                System.Console.WriteLine($"Contact {id} created.");
            }

        }

        /// <summary>
        /// Create sample contacts
        /// </summary>
        private static void UpdateContacts()
        {
            var collection = SalesDomain.Instancia.GetContactsByLastName("Contact", "firstname","lastname", "emailaddress1");
            int cont = 1;
            foreach (Crm.Model.Contact ct in collection.Entities)
            {
                ct.EMailAddress1 = $"teste{cont}@gmail.com";
                cont++;
            }
            System.Console.WriteLine($"Read {collection.Entities.Count} contacts.");
            SalesDomain.Instancia.UpdateCollection(collection);
            System.Console.WriteLine($"All {collection.Entities.Count} contacts updated.");
        }

        private static void DeleteContacts()
        {
            var collection = SalesDomain.Instancia.GetContactsByLastName("Contact", "contactid");
            foreach (Crm.Model.Contact ct in collection.Entities)
            {
                SalesDomain.Instancia.Delete("contact", ct.Id);
                System.Console.WriteLine($"Contact {ct.Id} deleted.");
            }            
        }
    }
}
