using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {

        static void Main(string[] args)
        {
            IBook book = new DiskBook("Scott's Grade InMemoryBook");
            book.GradeAdded += OnGradeAdded;

            EnterGrades(null);

            var stats = book.GetStatistic();
            Console.WriteLine($"For the book named {book.Name}");
            Console.WriteLine($"the lowest grade is {stats.Low}");
            Console.WriteLine($"the highest grade is {stats.High}");
            Console.WriteLine($"the average grade is {stats.Average:N1}");
            Console.WriteLine($"the letter grade is {stats.Letter}");

        }

        private static void EnterGrades(IBook book)
        {
            while (true)
            {
                Console.WriteLine("Please enter a grade or enter 'q' to quit");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    Console.WriteLine("Thank you");
                    break;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine($"Thank you please come again");
                }

            }
        }

        static void OnGradeAdded(Object sender, EventArgs e)
        {
            Console.WriteLine("A grade was added");
        }
    }
}
   
