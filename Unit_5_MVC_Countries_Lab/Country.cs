using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_5_MVC_Countries_Lab
{
    internal class Country
    {
        public string Name { get; set; }
        public Continent continent { get; set; }
        public List<ConsoleColor> Colors { get; set; }

        public Country(string Name, Continent continent, params ConsoleColor[] Colors) 
        {
            this.Name = Name;
            this.continent = continent;
            this.Colors = Colors.ToList();
        }
    }

    public enum Continent
    {
        North_America,
        South_America,
        Asia,
        Africa,
        Europe,
        Oceania,
        Antarctica
    }
}
