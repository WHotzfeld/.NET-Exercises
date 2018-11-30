using System;

namespace Bool_DoWhile_App
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("POP QUIZ! What was President Washington's first name? (Include correct capitalization!)");
            string ThePrez = Console.ReadLine();
            bool prezAnswer = ThePrez == "George";

            do
            {
                switch (ThePrez)
                {
                    case "george":
                        Console.WriteLine("Correct, but you forgot capitalization! Score: 75/100.");
                        prezAnswer = true;
                        break;

                    case "George":
                        Console.WriteLine("Nice! You passed 1st Grade US Social Studies! Score: 100/100.");
                        prezAnswer = true;
                        break;

                    default:
                        Console.WriteLine("Nope! Sorry, you failed. Score: 0/100.");
                        Console.WriteLine("Would you like to try again? If so, type your new answer below:");
                        ThePrez = Console.ReadLine();
                        break;
                }
            }
            while (!prezAnswer);

            Console.Read();
        }
    }
}
