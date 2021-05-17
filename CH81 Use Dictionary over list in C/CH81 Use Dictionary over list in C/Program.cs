using System;
using System.Collections.Generic;

namespace CH81_Use_Dictionary_over_list_in_C
{
    class Program
    {
        public static void Main()
        {
            Country country1 = new Country() { Code = "AUS", Name = "AUSTRALA", Capital = "Canberra" };
            Country country2 = new Country() { Code = "IND", Name = "INDIA", Capital = "New Delhi" };
            Country country3 = new Country() { Code = "USA", Name = "UNITED STATES", Capital = "Washington D.C." };
            Country country4 = new Country() { Code = "GBR", Name = "UNITED KINGDOW", Capital = "London" };
            Country country5 = new Country() { Code = "CAN", Name = "CANADA", Capital = "Ottawa" };

            Dictionary<string, Country> dictionaryCountries = new Dictionary<string, Country>();
            dictionaryCountries.Add(country1.Code, country1);
            dictionaryCountries.Add(country2.Code, country2);
            dictionaryCountries.Add(country3.Code, country3);
            dictionaryCountries.Add(country4.Code, country4);
            dictionaryCountries.Add(country5.Code, country5);

            string strUserChoice = string.Empty;
            do
            {
                Console.WriteLine("Please enter country code");
                string strCountryCode = Console.ReadLine().ToUpper();

                Country resultCountry = dictionaryCountries.ContainsKey(strCountryCode) ? dictionaryCountries[strCountryCode] : null;
                if (resultCountry == null)
                {
                    Console.WriteLine("Country code not valid");
                }
                else
                {
                    Console.WriteLine("Name = {0}, Capital = {1}", resultCountry.Name, resultCountry.Capital);
                }
                do
                {
                    Console.WriteLine("Do you want to continue Yes or NO?");
                    strUserChoice = Console.ReadLine().ToUpper();
                } while (strUserChoice != "NO" && strUserChoice != "YES");

            }
            while (strUserChoice == "YES");
        }
    }

    public class Country
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Capital { get; set; }


    }
}