using cities.Models;

internal class Program
{
    static void Main(string[] args)
    {
        //A kapott CSV állomány Európa nagyobb városainak a korábbi és a jövőbeli becsült népességszámait tartalmazza.
        // CITY_CODE;CITY_NAME;Y2010;Y2020;Y2030;Y2040;Y2050


        //todo: 1F Készítsen osztályt egy város adatainak tárolására! (City)
        //todo: 2F Készítsen osztályt a városok adatainak kezelésére! (CitiesMethods), ami a megadott interfészt implementálja!

        //todo: Válaszoljon a következő kérdésekre a korábban létrehozott osztályok felhasználásával!

        //todo: 3F Hány város adatait tartalmazza a CSV fájl? (CitiesMethods)
        CityMethods cityMethods = new CityMethods();
        cityMethods.LoadFromCSV("pop_city.csv");
        Console.WriteLine(cityMethods.CityCount());
        //todo: 4F Melyik 10 város volt a legnépesebb 2020-ban? (CitiesMethods)

        Console.WriteLine(cityMethods.Top10City(2010));
        //todo: 5F Kérje be billentyűzetről egy város nevét! Ha nem létezik, akkor jelezze azt és kérje be újra! (CitiesMethods)
        //         Miután létező nevet adott meg, döntse el, hogy a város lakossága folyamatosan növekedett-e az évek alatt?
        //todo: 6F Írja (bigCities.CSV) fájlba a 2020-ban 1 millió főnél nagyobb népességgel rendelkező városokat! (CitiesMethods)
        //todo: 7F Írassa képernyőre azoknak a városoknak a nevét és népességváltozását, ahol 2050-ben kevesebben lesznek mint 2010-ben voltak!
        //todo:    A kiíratás népességcsökkenés szerint növevően rendezetten történjen! 
        //todo:    Tipp: Érdemes megfelelő metódussal vagy property-vel bővíteni az osztályt! (CitiesMethods)
    }
}