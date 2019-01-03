using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //STEP 1.) Asked user for their current age. (Step 2 at bottom.)
            Console.WriteLine("Please enter your current age in years:");
            string ageInput = Console.ReadLine();
            int userAge = 1;
            
            //STEP 3.) Established try/catch block for multiple exceptions.
            try
            {
                userAge = Convert.ToInt32(ageInput);
                if (userAge < 0)
                {
                    throw new ArgumentException();
                }
            }
            //Catch for FormatException; input must be an int.
            catch (FormatException)
            {
                Console.WriteLine("Invalid age. Please only use whole numerals (eg: 25, 70, 18).");
                Console.ReadLine();
                return;
            }
            //STEP 4.) Established catch for ArgumentException (created in try block)
            //         for ages too low to be valid.
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid age. You cannot be a negative number of years old.");
                Console.ReadLine();
                return;
            }
            //STEP 5.) Established catch for general exceptions.
            catch (Exception)
            {
                Console.WriteLine("I'm sorry, there was a problem with your input. Please try again.");
                Console.ReadLine();
                return;
            }

            //STEP 2.) Established DateTime, calculated year of user's birth, 
            //         and displayed (possible) birth year(s) to user.
            DateTime now = DateTime.Today;

            int birthYear1 = now.Year - userAge;
            int birthYear2 = birthYear1 - 1;

            if (birthYear1 == now.Year)
            {
                Console.WriteLine("A newborn? Effectively using a console app? The director of Baby Geniuses tried to warn us this day would come. " +
                    "\n...We should have listened...");
            }

            Console.WriteLine("If you are " + userAge + ", that means you were born in either " + birthYear1 + " or " + birthYear2 + ".");
            Console.ReadLine();
        }   
    }
}
