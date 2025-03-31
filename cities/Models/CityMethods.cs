using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cities.Models
{
    internal class CityMethods : ICityMethods
    {
        List<City> cityList;
        public int CityCount()
        {
            return cityList.Count;
        }

        public bool IsContinuousGrowing(List<int> populationDatas)
        {
            return populationDatas == populationDatas.Order();
        }

        public void LoadFromCSV(string path)
        {
            var csv = File.ReadLines(path);
            foreach (var row in csv)
            {
                var readedrows = row.ToString().Split(';');
                City city = new();
                city.CITY_CODE = readedrows[0];
                city.CITY_NAME = readedrows[1];
                city.Y2010 = readedrows[0] == "Nan" ? int.Parse(readedrows[2]) : null;
                city.Y2020 = readedrows[0] == "Nan" ? int.Parse(readedrows[3]) : null;
                city.Y2030 = readedrows[0] == "Nan" ? int.Parse(readedrows[4]) : null;
                city.Y2040 = readedrows[0] == "Nan" ? int.Parse(readedrows[5]) : null;
                city.Y2050 = readedrows[0] == "Nan" ? int.Parse(readedrows[6]) : null;

                cityList.Add(city);

            }
        }

        public void SaveToCSV(string path, List<City> cities, string charCode = "UTF-8")
        {
            throw new NotImplementedException();
        }

        public List<City> Top10City(int year)
        {
            List<City> cities = new List<City>();

            if (year == 2010)
            {
                foreach (var item in cityList)
                {
                    cities.OrderBy(x=>x.Y2010).Take(10);

                }
                
            }
            else if (year == 2020)
            {
                foreach (var item in cityList)
                {
                    cities.OrderBy(x => x.Y2020).Take(10);

                }
            }
            else if (year == 2030)
            {
                foreach (var item in cityList)
                {
                    cities.OrderBy(x => x.Y2030).Take(10);

                }
            }
            else if (year == 2040)
            {
                foreach (var item in cityList)
                {
                    cities.OrderBy(x => x.Y2040).Take(10);

                }
            }
            else if (year == 2050)
            {
                foreach (var item in cityList)
                {
                    cities.OrderBy(x => x.Y2050).Take(10);

                }
            }
            else 
            {
                Console.WriteLine("Nem megfelelő érték");
            }
            return cities;
        }
    }
}
