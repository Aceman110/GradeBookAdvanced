using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Derrick's Grade Book");           
            var done = false;
            while(!done)
            {
                System.Console.WriteLine("Enter a grade or press 'q' to quit");
                var input = Console.ReadLine();
                if(input == "q")
                {
                    done = true;
                    continue;
                }
                try{
                var grade = double.Parse(input);
                book.AddGrade(grade);
                }
                catch(ArgumentException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                catch(FormatException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
            }
           var stats = book.GetStatistics();


           Console.WriteLine($"The average grade is: {stats.Average:N1}");
           Console.WriteLine($"The lowest grade is: {stats.Low}");
           Console.WriteLine($"The highest grade is: {stats.High}");
           System.Console.WriteLine($"The letter grade is {stats.letter}");
        }
    }
}