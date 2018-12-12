using System;

namespace Method_Optional_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //STEP 2.) Instantiated "Planeswalker" object.
            Magic Planeswalker = new Magic();

            //STEP 3.) Asked for user input of one integer with the option for a second integer.
            Console.WriteLine("Please type an integer you would like magic performed on, then press \"Enter.\"");
            int firstInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("If you would like a second integer to be a part of the magic, type it here and press \"Enter.\"");
            Console.WriteLine("If you are fine with just one integer and have no other integer, simply press \"Enter\" without input.");

            //NOTE: I have a default for "secondInput" already set in the method, but ran into trouble when asking for input.
            // My original code only had the line within the "try" (the Convert...ReadLine), but I hit a format error whenever
            // the user didn't enter anything. This is the first thing I tried that worked. I'm sure there's a simpler way to
            // handle it, but it's beyond me! At any rate, the try/catch accomplishes the goal of the app.
            int secondInput = 0;
            try
            {
                secondInput = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException)
            {
                secondInput = 0;
            }
            //STEP 4.) Called the "Calc" method, allowing for one or two separate integers.
            Console.WriteLine("Wowwy zowwy! I did magic things and now your integer(s) have become: " + Magic.Calc(firstInput, secondInput) + "!");
            
            Console.ReadLine();

            //STEP 5.) Tried several integer combinations, as well as only inputting one integer. Seems to work well.
        }
    }
}
