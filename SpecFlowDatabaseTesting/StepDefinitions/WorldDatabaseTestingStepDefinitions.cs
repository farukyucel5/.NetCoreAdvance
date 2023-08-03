using NUnit.Framework;
using SpecFlowDatabaseTesting.DbContexts;
using SpecFlowDatabaseTesting.Entities;
using SpecFlowDatabaseTesting.Utils;
using System;
using System.Xml.Linq;
using TechTalk.SpecFlow;

namespace SpecFlowDatabaseTesting.StepDefinitions
{
    [Binding]
    public class WorldDatabaseTestingStepDefinitions
    {
        private List<City> cityList = new();
        CitiesDal worldDal = new();
        
        [Given(@"fetch the list of the cities from the table city")]
        public void GivenFetchTheListOfTheCitiesFromTheTableCity()
        {
            cityList = worldDal.GetAll();
        }

        [Given(@"verify that ""([^""]*)"" exists in the table")]
        public void GivenVerifyThatExists›nTheTable(string city)
        {
            worldDal.VerifyThatTheItemExistsInTheTable(city, cityList);
        }


    }



}
