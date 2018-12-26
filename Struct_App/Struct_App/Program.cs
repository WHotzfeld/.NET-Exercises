using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //STEP 2.) Created new Number "number" and set "number" Amount to 12.5.
            Number number = new Number();
            number.Amount = 12.5m;

            //STEP 3.) Printed Amount for "number" to console.
            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
        //STEP 1.) Created struct Number with "Amount" as decimal data type.
        public struct Number
        {
            public decimal Amount { get; set; }
        }
    }
}
