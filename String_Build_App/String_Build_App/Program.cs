using System;
using System.Text;

namespace String_Build_App
{
    class Program
    {
        static void Main()
        {
            //Begin String Concatenation Section
            Console.WriteLine("Type your favorite word in lowercase.");
            string a1 = Console.ReadLine();
            Console.WriteLine("Ok, now type your second favorite word in lowercase.");
            string a2 = Console.ReadLine();
            Console.WriteLine("Great, now your third favorite word, also in lowercase, then I'll combine them all into one SUPERWORD.");
            string a3 = Console.ReadLine();

            Console.WriteLine("You've created a SUPERWORD! And that word is " + a1 + a2 + a3 + "!");

            //Begin Uppercase Conversion Section
            Console.WriteLine("\n Now, to see your superword become EXTRA SUPER, press \"Enter.\"");
            string aS = a1 + a2 + a3;
            aS = aS.ToUpper();
            Console.ReadLine();

            Console.WriteLine("Your superword is now EXTRA SUPER. Here it is: " + aS + "!");

            //Begin StringBuilder Paragraph Section
            Console.WriteLine("\n Now that we have your super word, " + aS + ", write a sentence about your word.");
            StringBuilder sp = new StringBuilder();

            sp.Append(Console.ReadLine() + " ");
            Console.WriteLine("Excellent. Let's see another sentence.");
            sp.Append(Console.ReadLine() + " ");
            Console.WriteLine("Of course, of course. And another sentence!");
            sp.Append(Console.ReadLine() + " ");
            Console.WriteLine("I agree wholeheartedly! Surely you've got another sentence... This is a SUPERWORD, after all.");
            sp.Append(Console.ReadLine() + " ");
            Console.WriteLine("And finally, write a closing sentence about your superword.");
            sp.Append(Console.ReadLine() + " ");

            Console.WriteLine("This is what you had to say about your superword: ");
            Console.WriteLine(sp);
            Console.ReadLine();
        }
    }
}
