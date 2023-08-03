using EntityFrameworkIntro;
using Microsoft.EntityFrameworkCore;


List<City> list = new List<City>();

list = CitiesDal.GetAllCities();
list.ForEach(p => Console.WriteLine(p.CityName.ToString()));

CitiesDal.Add(new City()
{
    CityName = "Erzincan",
    Population = 4000000,
    Latitude = 39.920800M,
    Longitude = 39.920800M,
    Region = "Eastern",
    Country = "Turkey"
});
Console.WriteLine("===============updated=================");
list = CitiesDal.GetAllCities();
list.ForEach(p => Console.WriteLine(p.CityName.ToString()));



