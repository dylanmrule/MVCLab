using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MVCLab
{
    class CountryController
    {
        public List<Country> CountryDb { get; set; }
        public CountryController()
        {
            CountryDb = new List<Country>();
            CountrySetup cs = new CountrySetup();
            Country USA = cs.GetCountry("United States", "North America", "Red", "White", "Blue");
            Country Ireland = cs.GetCountry("Ireland", "Europe", "Green", "White", "Orange");
            Country Canada = cs.GetCountry("Canada", "North America", "Red", "White");
            Country Iceland = cs.GetCountry("Iceland", "North America", "Red", "White", "Blue");
            Country China = cs.GetCountry("China", "Asia", "Red", "Yellow");
            CountryDb.Add(USA);
            CountryDb.Add(Ireland);
            CountryDb.Add(Canada);
            CountryDb.Add(Iceland);
            CountryDb.Add(China);
        }
        public void CountryAction(Country c)
        {
            CountryView cc = new CountryView(c);
            cc.Display(); 
        }
        public void WelcomeAction()
        {
            CountryListView cl = new CountryListView(CountryDb);
            bool run = true;

            while (run)
            {
                Console.WriteLine("Hello, welcome to the country app. Please select from the following list: ");
                cl.Display();
                try
                {
                    int input = int.Parse(Console.ReadLine());
                    CountryAction(CountryDb[input]);
                }

                catch (FormatException)
                {
                    Console.WriteLine("That was not a valid number. Please try again");
                    continue;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("That was not a valid number. Please try again");
                    continue;
                }
                
                
                
                Console.WriteLine("Would you like to learn about another country? y/n");
                string restart = Console.ReadLine().Trim().ToLower();

                if (restart == "y")
                {
                    continue;
                }
                else if(restart == "n")
                {
                    Console.WriteLine("Thank you for playing!");
                    break;
                }
                else
                {

                }
                
            }




        }


    }
}
