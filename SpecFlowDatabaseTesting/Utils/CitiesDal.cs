using NUnit.Framework;
using SpecFlowDatabaseTesting.DbContexts;
using SpecFlowDatabaseTesting.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowDatabaseTesting.Utils
{
    internal class CitiesDal:IWorldDatabase
    {
        private List<string> cityName = new();
        public  List<City>GetAll()
        {
            using WorldContext context = new();
            return context.Cities.ToList();
            
        }

        public  void VerifyThatTheItemExistsInTheTable(string city,List<City> cityList){

            cityList.ForEach(city => cityName.Add(city.CityName));
            cityName.ForEach(name => Console.WriteLine(name.ToString()));
            Assert.True(cityName.Contains(city));
        }
    }
}


