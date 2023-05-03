using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_5_MVC_Countries_Lab
{
    internal class CountryController
    {
        public List<Country> CountryDB {  get; set; } = new List<Country>();
        public CountryController()
        {
            CountryDB.Add(new Country("Canada", Continent.North_America, ConsoleColor.Red, ConsoleColor.White));
            CountryDB.Add(new Country("United States of America", Continent.North_America, ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Blue));
            CountryDB.Add(new Country("Japan", Continent.Asia, ConsoleColor.White, ConsoleColor.Red));
            CountryDB.Add(new Country("Vietnam", Continent.Asia, ConsoleColor.Yellow, ConsoleColor.Red));
            CountryDB.Add(new Country("France", Continent.Europe, ConsoleColor.Blue, ConsoleColor.White, ConsoleColor.Red));
        }
        public void CountryAction(Country c)
        {
            CountryView cView = new CountryView(c);
            cView.Display();
        }
        public void WelcomeAction()
        {
            CountryListView cListView = new CountryListView(CountryDB);
            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list.");
            do
            {
                cListView.Display();
                int choice = Validator.GetNumber(0, CountryDB.Count - 1, "Select an index");
                CountryAction(CountryDB[choice]);
            } while (Validator.Continue("Would you like to learn about another country (y/n)?"));
        }
    }
}
