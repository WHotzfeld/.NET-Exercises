using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_Array_App
{
    class Program
    {
        static void Main()
        {
            //
            //DRILL #1.) STRING ARRAY W/ PRINT LOOP
            //
            //Console.WriteLine("Let's play some Mad Libs! Please type any singular noun in lowercase to play.");
            //string madNoun = Console.ReadLine();
            //string[] madLibs = { "I always enjoy carrying around my ", "Whenever I feel sad, I just think about a ", "When playing hide & seek, you can always count on hiding under a ", "Don't hate the game, hate the " };

            //for (int i = 0; i < madLibs.Length; i++)
            //{
            //    Console.WriteLine(madLibs[i] + madNoun + ".");
            //}
            //Console.ReadLine();



            //
            //DRILL #2.) INFINITE LOOP
            //
            //Console.WriteLine("Hit \"Enter\" to watch me count from 1 to infinity REEEALLY fast!");
            //Console.ReadLine();
            //int i = 1;
            //while (i > 0)
            //{
            //    Console.WriteLine(i++);
            //}
            //Console.ReadLine();



            //
            //DRILL #3.) CORRECTED INFINITE LOOP
            //
            //Console.WriteLine("Hit \"Enter\" to watch me count from 1 to 50 REEEALLY fast!");
            //Console.ReadLine();
            //int i = 1;
            //while (i < 51)
            //{
            //    Console.WriteLine(i++);
            //}
            //Console.ReadLine();



            //
            //DRILL #4.) "<" COMPARISON LOOP
            //The last loop works for this as well so I'm reusing it.
            //
            //Console.WriteLine("Hit \"Enter\" to watch me count from 1 to 50 REEEALLY fast!");
            //Console.ReadLine();
            //int i = 1;
            //while (i < 51)
            //{
            //    Console.WriteLine(i++);
            //}
            //Console.ReadLine();



            //
            //DRILL #5.) "<=" COMPARISON LOOP
            //
            //Console.WriteLine("Hit \"Enter\" to watch me count from 1 to 50 REEEALLY fast!");
            //Console.ReadLine();
            //int i = 1;
            //while (i <= 50)
            //{
            //    Console.WriteLine(i++);
            //}
            //Console.ReadLine();



            //
            //DRILL #6.) SEARCH ARRAY INDEX
            //
            //Console.WriteLine("Please enter the name of your favorite Ninja Turtle to see what position they are in the TMNT array!");
            //Console.WriteLine("(Because, as we all know, understanding the positioning of the Ninja Turtles array is a must for any real fan.)");
            //Console.WriteLine("Type: Don, Leo, Mike, or Raph.");
            //List<string> TMNT = new List<string>() { "Don", "Leo", "Mike", "Raph" };
            //string favTurtle = Console.ReadLine();
            //for (int i = 0; i < TMNT.Count; i++)
            //{
            //    if (TMNT[i] == favTurtle)
            //    {
            //        Console.WriteLine(TMNT.IndexOf(favTurtle));
            //    }
            //}
            //Console.ReadLine();



            //
            //DRILL #7.) DRILL 6 + "NOT FOUND"
            //
            //Console.WriteLine("Please enter the name of your favorite Ninja Turtle to see what position they are in the TMNT array!");
            //Console.WriteLine("(Because, as we all know, understanding the positioning of the Ninja Turtles array is a must for any real fan.)");
            //Console.WriteLine("Type: Don, Leo, Mike, or Raph.");
            //List<string> TMNT = new List<string>() { "Don", "Leo", "Mike", "Raph" };
            //string favTurtle = Console.ReadLine();
            //for (int i = 0; i < TMNT.Count; i++)
            //{
            //    if (TMNT[i] == favTurtle)
            //    {
            //        Console.WriteLine(TMNT.IndexOf(favTurtle));
            //    }
            //}
            //bool favFound = TMNT.Contains(favTurtle) == true;
            //if (favFound == false)
            //{
            //    Console.WriteLine("YIKES. No turtle with that name. Try again next time!");
            //}
            //Console.ReadLine();



            //
            //DRILL #8.) DRILL 6/7 + FIRST MATCH
            //
            //Console.WriteLine("Please enter the name of your favorite Ninja Turtle to see what position they are in the TMNT array!");
            //Console.WriteLine("(Because, as we all know, understanding the positioning of the Ninja Turtles array is a must for any real fan.)");
            //Console.WriteLine("Type: Don, Leo, Mike, or Raph.");
            //List<string> TMNT = new List<string>() { "Don", "Leo", "Mike", "Raph" };
            //string favTurtle = Console.ReadLine();
            //for (int i = 0; i < TMNT.Count; i++)
            //{
            //    if (TMNT[i] == favTurtle)
            //    {
            //        Console.WriteLine(TMNT.IndexOf(favTurtle));
            //        Console.ReadLine();
            //    }
            //}
            //bool favFound = TMNT.Contains(favTurtle) == true;
            //if (favFound == false)
            //{
            //    Console.WriteLine("YIKES. No turtle with that name. Try again next time!");
            //}
            //Console.ReadLine();



            //
            //DRILL #9.) DUPLICATE SEARCH ARRAY INDEX
            //
            //Console.WriteLine("Please enter a shopping item to see its index in the list. (Items with multiples will display all indices.)");
            //Console.WriteLine("Type: milk, butter, eggs, flour, or sugar.");
            //List<string> shopList = new List<string> { "milk", "butter", "eggs", "eggs", "flour", "sugar", "sugar" };
            //string shopItem = Console.ReadLine();
            //for (int i = 0; i < shopList.Count; i++)
            //{
            //    if (shopList[i] == shopItem)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadLine();



            //
            //DRILL #10.) DRILL 9 + "NOT FOUND"
            //
            //Console.WriteLine("Please enter a shopping item to see its index in the list. (Items with multiples will display all indices.)");
            //Console.WriteLine("Type: milk, butter, eggs, flour, or sugar.");
            //List<string> shopList = new List<string> { "milk", "butter", "eggs", "eggs", "flour", "sugar", "sugar" };
            //string shopItem = Console.ReadLine();
            //for (int i = 0; i < shopList.Count; i++)
            //{
            //    if (shopList[i] == shopItem)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //bool itemFound = shopList.Contains(shopItem) == true;
            //if (itemFound == false)
            //{
            //    Console.WriteLine("Sorry, no items found with that name. Restart the program and try again.");
            //}
            //Console.ReadLine();



            //
            //DRILL #11.) FOREACH LOOP
            //
            //Console.WriteLine("Press \"Enter\" to see a bunch of names from a completely made up list,\n as well as whether or not you've seen that name already.");
            //Console.ReadLine();
            //List<string> randoNames = new List<string>() { "Applebaum", "Franks", "Smith", "Chapman", "Ziegler", "Smith", "Craig", "Franks" };
            //List<string> copyList = new List<string>();
            //foreach (string name in randoNames)
            //{
            //    if (copyList.Contains(name))
            //    {
            //        Console.WriteLine(name + ". Note: This name has appeared before.");
            //        copyList.Add(name);
            //    }
            //    else
            //    {
            //        Console.WriteLine(name);
            //        copyList.Add(name);
            //    }
            //}
            //Console.ReadLine();



        }
    }
}
