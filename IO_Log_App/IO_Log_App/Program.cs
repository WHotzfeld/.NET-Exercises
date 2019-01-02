using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO_Log_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //STEP 1.) Asked user for number, converted to int.
            Console.WriteLine("Please enter a number:");
            int theNumber = Convert.ToInt32(Console.ReadLine());
            
            //STEP 2.) Created StreamWriter, logged int input.
            using (StreamWriter file = new StreamWriter(@"C:\Users\wesle\Logs\log.txt", true))
            {
                file.WriteLine(theNumber);
            }
            
            //STEP 3.) Printed entirety of log.txt.
            string logText = File.ReadAllText(@"C:\Users\wesle\Logs\log.txt");
            Console.WriteLine(logText);
            Console.ReadLine();
        }
    }
}
