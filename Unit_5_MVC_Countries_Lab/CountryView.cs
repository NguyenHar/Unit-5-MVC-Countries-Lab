using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_5_MVC_Countries_Lab
{
    internal class CountryView
    {
        public Country DisplayCountry { get; set; }
        public CountryView(Country country)
        {
            DisplayCountry = country;
        }

        public void Display()
        {
            if (DisplayCountry.Colors.Count > 0)
                Console.BackgroundColor = DisplayCountry.Colors[0];
            Console.WriteLine("Name: " + DisplayCountry.Name);

            if (DisplayCountry.Colors.Count > 1)
                Console.BackgroundColor = DisplayCountry.Colors[1];
            Console.WriteLine("Continent: " + DisplayCountry.continent);

            if (DisplayCountry.Colors.Count > 2)
                Console.BackgroundColor = DisplayCountry.Colors[2];
            Console.WriteLine("Color: " + string.Join(", ",DisplayCountry.Colors));

            Console.ResetColor();
        }
    }
}
