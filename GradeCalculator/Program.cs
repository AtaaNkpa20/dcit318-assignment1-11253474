using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== GRADE CALCULATOR ===");
            
            double grade;
            bool validInput = false;
            
            // Input validation loop
            do
            {
                Console.Write("Enter a numerical grade (0-100): ");
                string input = Console.ReadLine() ?? "";
                
                if (double.TryParse(input, out grade) && grade >= 0 && grade <= 100)
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
                }
            } while (!validInput);
            
            // Determine letter grade
            string letterGrade;
            
            if (grade >= 90)
                letterGrade = "A";
            else if (grade >= 80)
                letterGrade = "B";
            else if (grade >= 70)
                letterGrade = "C";
            else if (grade >= 60)
                letterGrade = "D";
            else
                letterGrade = "F";
            
            // Display results
            Console.WriteLine($"\nNumerical Grade: {grade}");
            Console.WriteLine($"Letter Grade: {letterGrade}");
                        
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}