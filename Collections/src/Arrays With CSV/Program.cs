using System;
using System.IO;

namespace Arrays_With_CSV
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\mariam.nesiem\Documents\Studies\C# fundamental\Collections\src\Arrays With CSV\Pop by Largest Final.csv";
            StreamReader sr = new StreamReader(filePath);
            
            Country[] countries=new Country[10];
            for (int i=0;i<10;i++)
            {
                string[] parts=sr.ReadLine().Split(',');
 
                string name = parts[0];
                string code = parts[1];
                string region = parts[2];
              //  int population = int.Parse(parts[3]);
              countries[i]=new Country(name, code, region);
            }

            foreach(Country country in countries){
            Console.WriteLine(country.Name);
            }

        }
    }
}
