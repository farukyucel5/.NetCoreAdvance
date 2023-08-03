using EntityFrameworkIntro;
using Microsoft.EntityFrameworkCore;


List<City> list = new List<City>();

//list = CitiesDal.GetAllCities();
//list.ForEach(p => Console.WriteLine(p.CityName.ToString()));

//CitiesDal.Add(new City()
//{
//    CityName = "Erzincan",
//    Population = 4000000,
//    Latitude = 39.920800M,
//    Longitude = 39.920800M,
//    Region = "Eastern",
//    Country = "Turkey"
//});
//Console.WriteLine("===============Addded=================");
list = CitiesDal.GetAllCities();
list.ForEach(p => Console.WriteLine(p.CityName.ToString()));

Console.WriteLine("===============Addded=================");

CitiesDal.Update(new City()
{
    CityId = 17,
    CityName = "Bolu",
    Population = 2000000,
    Latitude = 39.920800M,
    Longitude = 39.920800M,
    Region = "Eastern",
    Country = "Turkey"
});

Console.WriteLine("===============Updated=================");

list = CitiesDal.GetAllCities();
list.ForEach(p => Console.WriteLine(p.CityName.ToString()));

CitiesDal.Delete(new City()
{
    CityId=19,
    CityName = "Erzincan",
    Population = 4000000,
    Latitude = 39.920800M,
    Longitude = 39.920800M,
    Region = "Eastern",
    Country = "Turkey"
});

Console.WriteLine("===============Deleted=================");

list = CitiesDal.GetAllCities();
list.ForEach(p => Console.WriteLine(p.CityName.ToString()));





