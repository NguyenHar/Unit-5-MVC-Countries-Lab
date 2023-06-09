﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_5_MVC_Countries_Lab
{
    internal class CountryListView
    {
        public List<Country> Countries { get; set; }
        public CountryListView(List<Country> countries)
        {
            Countries = countries;
        }

        public void Display()
        {
            for (int i=0; i<Countries.Count; i++) 
            {
                Console.WriteLine($"Index: {i}, Country: {Countries[i].Name}");
            }
        }
    }
}
