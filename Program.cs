
using System;

namespace progex01_MathematicalFormula
{
    class Program
    {
        static void Main(string[] args)
        {

                    try
                    {
                        // Part 1: Area and circumference of circle
                        double radius = 0;
                        while(radius == 0)
                        {
                            Console.WriteLine("\nPart 1, circumference and area of a circle.");
                            Console.Write("Enter the value of the radius (input must be greater than zero): ");

                            radius = double.Parse(Console.ReadLine());
                        }
                        
                        
                        double circumference = 2.0 * Math.PI * radius;
                        Console.WriteLine($"The circumference is {circumference}");

                        double area = Math.PI * radius * radius;
                        Console.WriteLine($"The area is {area}");
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);

                    }

                    try
                    {
                        // Part 2: Volume of a hemisphere
                        double radius = 0;
                        while (radius == 0)
                        {
                            Console.WriteLine("\nPart 2, volume of a hemisphere.");

                            Console.Write("Enter the value of the radius (input must be greater than zero): ");
                            radius = double.Parse(Console.ReadLine());
                        }

                        double volume = 4.0 / 3.0 * Math.PI * (radius * radius * radius) / 2.0;

                        Console.WriteLine($"The volume is {volume}");
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);

                    }

                    try
                    {
                        //Part 3: Area of triangle given the length of the sides
                        Console.WriteLine("\nPart 3, area of a triangle (Heron's formula).");

                        Console.Write("Enter the value of a: ");
                        double a = double.Parse(Console.ReadLine());

                        Console.Write("Enter the value of b: ");
                        double b = double.Parse(Console.ReadLine());

                        Console.Write("Enter the value of c: ");
                        double c = double.Parse(Console.ReadLine());

                        double p = (a + b + c) / 2.0;

                        double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                        Console.WriteLine($"The area is {area}");
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    try
                    {
                        // Part 4: Solving a quadratic equation
                        Console.WriteLine("\nPart 4, solving a quadratic equation.");

                        Console.Write("Enter the value of a: ");
                        double a = double.Parse(Console.ReadLine());

                        Console.Write("Enter the value of b: ");
                        double b = double.Parse(Console.ReadLine());

                        Console.Write("Enter the value of c: ");
                        double c = double.Parse(Console.ReadLine());

                        Console.Write("\n");

                        //Check for division by zero
                        if (a != 0)
                        {
                            //Complex/Imaginary numbers
                            //Discriminant than zero

                            if (b * b - 4 * a * c < 0)
                            {

                                Console.WriteLine($"x = {-b / (2.0 * a)}, + { (Math.Sqrt(Math.Abs(b * b - 4 * a * c)) / (2.0 * a))} i");
                                Console.WriteLine($"x = {-b / (2.0 * a)}, - { (Math.Sqrt(Math.Abs(b * b - 4 * a * c)) / (2.0 * a))} i");
                            }
                            else
                            {   //Real Numbers
                                //Discriminant greater than or equal to zero
                                if (b * b - 4 * a * c > 0)
                                {
                                    Console.WriteLine($"The positive solution is {(-b + Math.Sqrt(b * b - 4 * a * c)) / (2.0 * a)}");
                                    Console.WriteLine($"The negative solution is {(-b - Math.Sqrt(b * b - 4 * a * c)) / (2.0 * a)}");
                                }
                                else
                                    Console.WriteLine($"The solution is {(-b) / (2.0 * a)}");
                            }


                        }
                        else
                            Console.WriteLine("Coefficient 'a' cannot be equal to zero ");
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }       

        }
    }
}
