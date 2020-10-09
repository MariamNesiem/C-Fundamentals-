using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\mariam.nesiem\Documents\Studies\C# fundamental\Collections\src\Lists\Pop by Largest Final.csv";
            StreamReader sr = new StreamReader(filePath);
            
            List<Country> countries=new List<Country>();
            while ((sr.ReadLine()) != null)
            {
                string[] parts=sr.ReadLine().Split(',');
 
                string name = parts[0];
                string code = parts[1];
                string region = parts[2];
               countries.Add(new Country(name, code, region));
            }
            countries.Add(new Country("Mariam", "123", "123"));
            //countries.Sort(x => -x.Name);

            countries.Insert(10,new Country("Bassant", "123", "123"));
            countries.RemoveAt(10);

	        Console.Write("Enter no. of countries to display> ");
			bool inputIsInt = int.TryParse(Console.ReadLine(), out int userInput);
			if (!inputIsInt || userInput <= 0)
			{
				Console.WriteLine("You must type in a +ve integer. Exiting");
				return;
			}

			int maxToDisplay = userInput;
			for (int i = 0; i< countries.Count; i++)
			{
				if (i > 0 && (i % maxToDisplay == 0))
				{
					Console.WriteLine("Hit return to continue, anything else to quit>");
					if (Console.ReadLine() != "")
						break;
				}

				Country country = countries[countries.Count-1-i];
				Console.WriteLine((countries.Count-i)+": "+country.Name);
			}

        }
    }
}
