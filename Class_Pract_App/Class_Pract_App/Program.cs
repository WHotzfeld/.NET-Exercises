using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Pract_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //STEP 2.) Instantiated "theStuff."
            Thing theStuff = new Thing();

            //STEP 3.) Called method with 2 numbers.
            Thing.Operation(3, 15);

            //Step 4.) Called method with named parameters.
            Thing.Operation(firstNum: 5, secondNum: 6);

            Console.ReadLine();
        }
    }
}
