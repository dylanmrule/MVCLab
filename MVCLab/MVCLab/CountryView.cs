using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MVCLab
{
    class CountryView
    {
        public Country DisplayCountry;
        public CountryView(Country Country)
        {
            DisplayCountry = Country;
        }
        public void Display()
        {
            Console.WriteLine($"Name: {DisplayCountry.Name}\nContinent: {DisplayCountry.Continent}");
            foreach (String color in DisplayCountry.Colors)
            {
                Console.WriteLine("Colors: "+ color);
            }
        }
    }
}
//\nColors: {DisplayCountry.Colors}