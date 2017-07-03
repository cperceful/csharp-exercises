using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> list = new List<int>();
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                list.Add(random.Next(0, 20));
            }

            foreach (int thing in list)
            {
                Console.WriteLine(thing);
            }

            Console.WriteLine("The sum of all the numbers is: " + sum(list));
            Console.ReadLine();
            
         
        }

        static int sum(List<int> list)
        {
            int sum = 0;

            foreach (int item in list)
            {
                sum += item;
            }

            return sum;
        }
    }
}