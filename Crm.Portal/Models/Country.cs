using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Crm.Portal.Models
{
    public class Country
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public static IQueryable<Country> GetCountries()
        {
            return new List<Country>
            {
                new Country {
                    Code = "CA",
                    Name = "Canada"
                },
                new Country{
                    Code = "US",
                    Name = "United States"
                },
                new Country{
                    Code = "UK",
                    Name = "United Kingdom"
                } 
            }.AsQueryable();
        }
    }
}