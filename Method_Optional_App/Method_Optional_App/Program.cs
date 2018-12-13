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
            Console.WriteLine("If you would like a second integer to be a part of the magic, type it here and press \"Enter.\" " +
                "\n If you are fine with just one integer and have no other integer, simply press \"Enter\" without input.");


            //NOTE: Changed try/catch to if/else with a TryParse statement as the boolean factor in determining string-to-int conversion.
            // Works well and looks WAY cleaner.
            bool ifInteger = Int32.TryParse(Console.ReadLine(), out int secondInput);

            //STEP 4.) Called the "Calc" method, allowing for one or two separate integers.
            if (ifInteger == true)
            {
                Console.WriteLine("Wowwy zowwy! I did magic things and now your integers have become: " + Magic.Calc(firstInput, secondInput) + "!");
            }
            else
            {
                Console.WriteLine("Wowwy zowwy! I did magic things and now your integer has become: " + Magic.Calc(firstInput, secondInput) + "!");
            }
            
            Console.ReadLine();

            //STEP 5.) Tried several integer combinations, as well as only inputting one integer. Works well in each case.
        }
    }
}
