using System;

namespace TriangleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the coordinates of the three points
            Console.WriteLine("Enter the coordinates of the first point:");
            Console.Write("x1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("y1: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of the second point:");
            Console.Write("x2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("y2: ");
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of the third point:");
            Console.Write("x3: ");
            double x3 = double.Parse(Console.ReadLine());
            Console.Write("y3: ");
            double y3 = double.Parse(Console.ReadLine());

            // Calculate the length of the sides
            double side1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            double side2 = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            double side3 = Math.Sqrt(Math.Pow((x1 - x3), 2) + Math.Pow((y1 - y3), 2));

            // Round the length of sides to two decimal places
            side1 = Math.Round(side1, 2);
            side2 = Math.Round(side2, 2);
            side3 = Math.Round(side3, 2);

            // Check if it's an equilateral triangle
            bool isEquilateral = (side1 == side2) && (side2 == side3);

            // Check if it's an isosceles triangle
            bool isIsosceles = (side1 == side2) || (side2 == side3) || (side3 == side1);

            // Check if it's a right triangle
            bool isRight = (Math.Pow(side1, 2) == Math.Pow(side2, 2) + Math.Pow(side3, 2)) || 
                (Math.Pow(side2, 2) == Math.Pow(side1, 2) + Math.Pow(side3, 2)) || 
                (Math.Pow(side3, 2) == Math.Pow(side1, 2) + Math.Pow(side2, 2));

            // Calculate the perimeter of the triangle
            double perimeter = side1 + side2 + side3;

            // Round the perimeter to two decimal places
            perimeter = Math.Round(perimeter, 2);

            // Print out the results
            Console.WriteLine($"Side 1: {side1}");
            Console.WriteLine($"Side 2: {side2}");
            Console.WriteLine($"Side 3: {side3}");
            Console.WriteLine($"Is it an equilateral triangle? {isEquilateral}");
            Console.WriteLine($"Is it an isosceles triangle? {isIsosceles}");
            Console.WriteLine($"Is it a right triangle? {isRight}");
            Console.WriteLine($"Perimeter: {perimeter}");

            // Find even numbers from 0 to perimeter
            Console.Write("Even numbers from 0 to perimeter: ");
            for (int i = 0; i <= (int)perimeter; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
