using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\mariam.nesiem\Documents\Studies\C# fundamental\Collections\src\Dictionary\Pop by Largest Final.csv";
            StreamReader sr = new StreamReader(filePath);
            
            Dictionary<string, Country> countries=new Dictionary<string, Country>();
            while ((sr.ReadLine()) != null)
            {
                string[] parts=sr.ReadLine().Split(',');
 
                string name = parts[0];
                string code = parts[1];
                string region = parts[2];
               countries.Add(code,new Country(name, code, region));
            }
            Country selectcon = countries["NOR"];

            Console.WriteLine(selectcon.Name);

            foreach(Country country in countries.Values.OrderBy(x=>x.Name).Take(10)){
            Console.WriteLine(country.Name);
            }

                foreach(Country country in countries.Values.Where(x=>!x.Name.Contains('"')).Take(10)){
            Console.WriteLine(country.Name);
            }
        }
    }
}
