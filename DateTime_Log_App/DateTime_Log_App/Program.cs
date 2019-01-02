using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Log_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //STEP 1.) Created datetime object, printed current datetime to console.
            DateTime rightNow = DateTime.Now;

            //STEP 2.) Asked user the amount of time they will waste by staring at a console window.
            Console.WriteLine("The current date and time is " + rightNow + ". \n" +
                "How many hours do you plan on staring at this screen?");
            int longWait = Convert.ToInt32(Console.ReadLine());

            //STEP 3.) Printed the expected completion datetime and provided user with sage life advice.
            Console.WriteLine("Wow, really? When you're done, it will be " + rightNow.AddHours(longWait) + ". \n" +
                "That's a long time. Maybe just do something else for the next " + longWait + " hours instead.");
            Console.ReadLine();
        }
    }
}
