using System;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu newMenu = new Menu();

            MenuItem pizza = new MenuItem();
            pizza.Description = "Pizza with stuff or whatever";
            pizza.Price = 9.99;
            pizza.Type = Type.MainCourse;
            newMenu.AddItem(pizza);

            MenuItem cheesecake = new MenuItem();
            cheesecake.Description = "Cheesecake";
            cheesecake.Price = 7.99;
            cheesecake.Type = Type.Dessert;
            newMenu.AddItem(cheesecake);

            MenuItem cheeseCubes = new MenuItem();
            cheeseCubes.Description = "Cubes of Cheese";
            cheeseCubes.Price = 4.99;
            cheeseCubes.Type = Type.Appetizer;
            newMenu.AddItem(cheeseCubes);

            Console.WriteLine("Here's today's menu!");
            Console.WriteLine("Item: " + pizza.Description);
            Console.WriteLine("Price: " + "$" + pizza.Price);
            Console.WriteLine("Course: " + pizza.Type);
            Console.WriteLine();

            Console.WriteLine("Item: " + cheesecake.Description);
            Console.WriteLine("Price: " + "$" + cheesecake.Price);
            Console.WriteLine("Course: " + cheesecake.Type);
            Console.WriteLine();

            Console.WriteLine("Item: " + cheeseCubes.Description);
            Console.WriteLine("Price: " + "$" + cheeseCubes.Price);
            Console.WriteLine("Course: " + cheeseCubes.Type);
            Console.WriteLine();

            Console.WriteLine("Menu last updated: " + newMenu.LastUpdated);
            Console.ReadLine();


        }
    }
}