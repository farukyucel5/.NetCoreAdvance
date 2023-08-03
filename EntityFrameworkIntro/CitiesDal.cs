using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkIntro
{
    internal class CitiesDal
    {
        public static List<City> GetAllCities()
        {
            using WorldContext context = new();
            return context.Cities.ToList();
        }

        public static void Add(City city)
        {
            using WorldContext context = new();
            context.Cities.Add(city);
            context.SaveChanges();
        }


    }
}
