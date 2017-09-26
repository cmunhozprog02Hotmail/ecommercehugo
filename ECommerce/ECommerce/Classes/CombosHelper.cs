using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerce.Classes
{
    public class CombosHelper : IDisposable
    {
        private static EcommerceContext db = new EcommerceContext();

        public static List<Departaments> GetDepartaments()
        {
            var departaments = db.Departaments.ToList();
            departaments.Add(new Departaments
            {
                DepartamentsId = 0,
                Name = "[Selecione um Departamento...]"
            });
            return departaments.OrderBy(d => d.Name).ToList();
        }

        public static List<City> GetCities()
        {
            var city = db.Cities.ToList();
            city.Add(new City
            {
                DepartamentsId = 0,
                Name = "[Selecione uma Cidade...]"
            });
            return city.OrderBy(d => d.Name).ToList();
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}