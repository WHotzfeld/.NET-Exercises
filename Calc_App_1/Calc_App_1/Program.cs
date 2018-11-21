using System;

namespace Calc_App_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please type a numeral that you, for some reason, want to be multiplied by 50.");
            string user50 = Console.ReadLine();
            double num50 = Convert.ToDouble(user50);
            double result50 = num50 * 50.0;
            Console.WriteLine("After being multiplied, the resulting number is " + result50 + ". NEAT-O. Press \"Enter\" for the next question.");
            Console.ReadLine();

            Console.WriteLine("Pleae type a numeral that you wish was higher in value by exactly 25.");
            string user25 = Console.ReadLine();
            double num25 = Convert.ToDouble(user25);
            double result25 = num25 + 25.0;
            Console.WriteLine("Congrats! Your numeral has gained a value of 25, and is now " + result25 + ". Press \"Enter\" for the next question.");
            Console.ReadLine();

            Console.WriteLine("Got a numeral you wish were a fraction of itself? Like say, for instance, divided by 12.5? Type it here!");
            string user12 = Console.ReadLine();
            double num12 = Convert.ToDouble(user12);
            double result12 = num12 / 12.5;
            Console.WriteLine("Wow, what a numeral. You wanted " + result12 + ", and by George you've got it. Press \"Enter\" for the next question.");
            Console.ReadLine();

            Console.WriteLine("'Gee, I wish I knew whether or not my numeral was greater than 50...' Type the numeral you're curious about.");
            string userGreater = Console.ReadLine();
            double numGreater = Convert.ToDouble(userGreater);
            bool resultGreater = numGreater > 50;
            Console.WriteLine("Wonder no more! The idea that your numeral is greater than 50 is, in fact, " + resultGreater + ". Press \"Enter\" for the next question.");
            Console.ReadLine();

            Console.WriteLine("Time to find out what the remainder of your favorite numeral is when divided by 7. Type your favorite numeral now!");
            string user7 = Console.ReadLine();
            double num7 = Convert.ToDouble(user7);
            double result7 = num7 % 7;
            Console.WriteLine("After being divided by 7, the remainder of your favorite numeral is " + result7 + ". Thanks for answering!");
            Console.ReadLine();
        }
    }
}
