using System;

namespace Boolean_While_App
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Type a whole numeral. If it's less than 20, I'll count up to 20 for you!");
            int number = Convert.ToInt32(Console.ReadLine());

            bool numCount = number == 20;

            while (!numCount)
            {
                number = (number + 1);
                Console.WriteLine(number);
                
                if (number == 20)
                {
                    Console.WriteLine("And there you have it! That's how to count from your number to 20.");
                    Console.ReadLine();
                }
                else if (number > 20)
                {
                    Console.WriteLine("It's over 20!");
                    Console.ReadLine();
                }
                
            }
            Console.ReadLine();
        }
    }
}
