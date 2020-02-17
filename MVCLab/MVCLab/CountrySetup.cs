using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MVCLab
{
    class CountrySetup
    {
        
        public Country GetCountry(string Name, string Continent, string color1, string color2, string color3)
        {



            Country c = new Country
            {
                Name = Name,
                Continent = Continent,






            };
            c.Colors.Add(color1);
            c.Colors.Add(color2);
            c.Colors.Add(color3);
            return c;
        }
        public Country GetCountry(string Name, string Continent, string color1, string color2)
        {
            Country c = new Country
            {
                Name = Name,
                Continent = Continent,

            };
            c.Colors.Add(color1);
            c.Colors.Add(color2);
            return c;
        }
        public CountrySetup()
        {
        }
    }
}