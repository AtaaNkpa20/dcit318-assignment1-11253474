using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== TRIANGLE TYPE IDENTIFIER ===");
            Console.WriteLine("Enter the lengths of three sides to determine the triangle type.");
            Console.WriteLine("===============================================");
            
            double side1, side2, side3;
            bool validInput = false;
            
            // Input validation loop
            do
            {
                try
                {
                    Console.Write("Enter the length of side 1: ");
                    side1 = Convert.ToDouble(Console.ReadLine());
                    
                    Console.Write("Enter the length of side 2: ");
                    side2 = Convert.ToDouble(Console.ReadLine());
                    
                    Console.Write("Enter the length of side 3: ");
                    side3 = Convert.ToDouble(Console.ReadLine());
                    
                    if (side1 > 0 && side2 > 0 && side3 > 0)
                    {
                        // Check if the sides can form a valid triangle
                        if (IsValidTriangle(side1, side2, side3))
                        {
                            validInput = true;
                            
                            // Determine triangle type
                            string triangleType = DetermineTriangleType(side1, side2, side3);
                            
                            // Display results
                            Console.WriteLine("\n=== TRIANGLE ANALYSIS ===");
                            Console.WriteLine($"Side 1: {side1}");
                            Console.WriteLine($"Side 2: {side2}");
                            Console.WriteLine($"Side 3: {side3}");
                            Console.WriteLine($"Triangle Type: {triangleType}");
                            
                            // Additional information
                            DisplayTriangleInfo(triangleType);
                            
                            Console.WriteLine("========================");
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid triangle! The sum of any two sides must be greater than the third side.");
                            Console.WriteLine("Triangle Inequality Theorem: a + b > c, a + c > b, b + c > a");
                            Console.WriteLine("Please enter valid triangle sides.\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. All sides must be positive numbers.\n");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter numeric values only.\n");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Number too large. Please enter reasonable values.\n");
                }
            } while (!validInput);
            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
        
        // Method to check if three sides can form a valid triangle
        static bool IsValidTriangle(double a, double b, double c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }
        
        // Method to determine triangle type based on side lengths
        static string DetermineTriangleType(double side1, double side2, double side3)
        {
            if (side1 == side2 && side2 == side3)
                return "Equilateral";
            else if (side1 == side2 || side1 == side3 || side2 == side3)
                return "Isosceles";
            else
                return "Scalene";
        }
        
        // Method to display additional information about triangle types
        static void DisplayTriangleInfo(string triangleType)
        {
            Console.WriteLine("\nTriangle Information:");
            switch (triangleType)
            {
                case "Equilateral":
                    Console.WriteLine("- All three sides are equal in length");
                    Console.WriteLine("- All angles are 60 degrees");
                    Console.WriteLine("- Has 3 lines of symmetry");
                    break;
                case "Isosceles":
                    Console.WriteLine("- Two sides are equal in length");
                    Console.WriteLine("- Two angles are equal");
                    Console.WriteLine("- Has 1 line of symmetry");
                    break;
                case "Scalene":
                    Console.WriteLine("- All three sides have different lengths");
                    Console.WriteLine("- All angles are different");
                    Console.WriteLine("- No lines of symmetry");
                    break;
            }
        }
    }
}