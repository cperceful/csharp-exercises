using System;

//Calculate the area of a circle based on user input. A = pi * r * r
namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What up? Let's calculate the area of a circle");
            while (true)
            {
                Console.WriteLine("Enter the radius of the circle: ");
                double radius = Double.Parse(Console.ReadLine());

                if (radius < 0)
                {
                    continue;
                } else
                {
                    double area = radius * radius * Math.PI;
                    Console.WriteLine("The area of the circle is: " + area);
                }
                
            }

        }
    }
}