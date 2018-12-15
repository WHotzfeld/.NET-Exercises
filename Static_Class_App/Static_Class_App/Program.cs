using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //STEP 2.) Instantiated the "divider" object of the "Divider" class.
            Divider divider = new Divider();

            //STEP 3.) Asked user for numeral, and called method on the numeral entered by the user.
            // Displayed the output.
            Console.WriteLine("Please enter a numeral to be divided by 2.");

            int userInt = Convert.ToInt32(Console.ReadLine());
            int dividedNum = 0;

            Divider.Half(out dividedNum, userInt);
            
            Console.WriteLine(dividedNum);
            Console.ReadLine();
        }
    }
}
