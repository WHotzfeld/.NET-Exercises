using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //STEP 2.) Asked for user to input the current day.
            Console.WriteLine("Please enter the current day of the week. (Remember proper capitalization!)");
            string dayInput = Console.ReadLine();

            try
            {
                //STEP 3.) Assigned user input value to a "Day."
                Day dayParse = (Day)Enum.Parse(typeof(Day), dayInput);
                Console.WriteLine("Today is " + dayParse + ".");
            }
            catch(ArgumentException)
            {
                //STEP 4.) Created try/catch for instances where the user's input does not match any of the days of the week.
                Console.WriteLine(dayInput + " is not a proper day. Please enter an actual day of the week.");
            }
            Console.ReadLine();
        }
        //STEP 1.) Created enum "Day", and included each English day of the week.
        public enum Day
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }
}
