using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cities.Models
{
    internal class CityMethods : ICityMethods
    {
        List<City> cityList=new();
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
            var csv = File.ReadLines(path).ToList();
            csv.RemoveAt(0);
            foreach (var row in csv)
            {
                var readedrows = row.ToString().Split(';');
                City city = new();
                city.CITY_CODE = readedrows[0];
                city.CITY_NAME = readedrows[1];
                city.Y2010 = readedrows[2] == "Nan" ? int.Parse(readedrows[2]) : null;
                city.Y2020 = readedrows[3] == "Nan" ? int.Parse(readedrows[3]) : null;
                city.Y2030 = readedrows[4] == "Nan" ? int.Parse(readedrows[4]) : null;
                city.Y2040 = readedrows[5] == "Nan" ? int.Parse(readedrows[5]) : null;
                city.Y2050 = readedrows[6] == "Nan" ? int.Parse(readedrows[6]) : null;

                cityList.Add(city);

            }
        }

        public void SaveToCSV(string path, List<City> cities, string charCode = "UTF-8")
        {
            throw new NotImplementedException();
        }

        public List<City> Top10City(int year)
        {
           



            if (year == 2010)
            {
                return cityList.OrderBy(x=>x.Y2010).Take(10).ToList();
                                               
            }
            else if (year == 2020)
            {
               
                    cities.OrderBy(x => x.Y2020).Take(10).ToList();

            }
            else if (year == 2030)
            {
               
                    cities.OrderBy(x => x.Y2030).Take(10).ToList();

            }
            else if (year == 2040)
            {
              
                    cities.OrderBy(x => x.Y2040).Take(10).ToList();

                
            }
            else if (year == 2050)
            {
               
                    cities.OrderBy(x => x.Y2050).Take(10).ToList();

            }
            else 
            {
                Console.WriteLine("Nem megfelelő érték");
            }
            return cities;
        }
    }
}
