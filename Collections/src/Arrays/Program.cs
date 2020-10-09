using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Week={"Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"};

            Console.WriteLine("Which day you want to display? > ");
            int num = int.Parse(Console.ReadLine());
            try{
                      Console.WriteLine(Week[num-1]);
            }catch{
                Console.WriteLine("you should enter a number between 1 and 7");
            }
            
        }
    }
}
