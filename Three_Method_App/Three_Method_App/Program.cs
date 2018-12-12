using System;

namespace Three_Method_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //STEP 2.) Instantiated "multiplication" Math object. Called first method and displayed result.
            Math multiplication = new Math();
            
            Console.WriteLine(Math.FirstThing(inputInt: 12));
            Console.ReadLine();

            //STEP 4.) Instantiated "addition" Math object. Called second method and displayed result as int.
            Math addition = new Math();

            Console.WriteLine(Math.FirstThing(inputDec: 15.0m));
            Console.ReadLine();

            //STEP 6.) Instantiated "subtraction" Math object. Called third method and displayed result as int.
            Math subtraction = new Math();

            Console.WriteLine(Math.FirstThing(inputStr: "20"));
            Console.ReadLine();
        }
    }
}
