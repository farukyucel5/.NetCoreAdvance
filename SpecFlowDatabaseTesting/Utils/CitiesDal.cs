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
    internal class CitiesDal
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

        public List<City> GetTheFilteredData(string key)
        {
            using WorldContext worldContext = new();
            return worldContext.Cities.Where(p => p.CityName.Contains(key)).ToList();
            
        }

        public void VerifyThatTheItemsFilteredAccurately(List<City> cityList,string key)
        {
           
            cityList.ForEach(city => cityName.Add(city.CityName));
            cityName.ForEach(name => Console.WriteLine(name.ToString()));
            cityName.ForEach(cityName => Assert.True(cityName.ToLower().Contains(key.ToLower())));

        }
    }
}


