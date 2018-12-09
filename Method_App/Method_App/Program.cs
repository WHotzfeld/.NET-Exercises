using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole numeral to be operated on.");
            Console.WriteLine("I will produce three new numerals: your numeral added to 5, your numeral added to 10, and your numeral added to 20.");
            int numInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Class1.AddFive(numInput));
            Console.WriteLine(Class1.AddTen(numInput));
            Console.WriteLine(Class1.AddTwenty(numInput));

            Console.ReadLine();
        }
    }
}
