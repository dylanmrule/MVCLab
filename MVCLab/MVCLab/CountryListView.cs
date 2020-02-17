using System;
using System.Collections.Generic;
using System.Text;

namespace MVCLab
{
    class CountryListView
    {
        public List<Country> Countries;
        public CountryListView(List<Country> Countries)
        {
            this.Countries = Countries;
        }

        public void Display()
        {
            for (int i = 0; i < Countries.Count; i++)
            {
                Console.WriteLine($"Index: {i} \nCountry name: {Countries[i].Name}");
            }

        }
    }
}
