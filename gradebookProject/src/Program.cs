using System;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new InMemoryBook("Mariam's Grade Book");
            book.GradeAdded += OnGradeAdded;
            book.GradeAdded -= OnGradeAdded;

            Console.WriteLine("If you want to quit enter 'q' ");
            EnterGrades(book);

            var stat = book.GetStatistics();
            Console.WriteLine($"Sum of list: {stat.SUM}");
            Console.WriteLine($"Avg of list: {stat.Avg}");
            Console.WriteLine($"Max of list: {stat.High}");
            Console.WriteLine($"Min of list: {stat.Low}");
            Console.WriteLine($"The Letter grade is {stat.Letter}");
        }

        private static void EnterGrades(IBook book)
        {
            while (true)
            {
                Console.WriteLine("Enter your grade: ");
                var num = Console.ReadLine();
                if (num == "q")
                {
                    break;
                }

                try
                {
                    var grade = double.Parse(num);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }
                finally
                {
                    Console.WriteLine("**");
                }
            }
        }

        static void OnGradeAdded(object sender, EventArgs e){
            Console.WriteLine("A grade was added");
        }

    
    }
}
