using System;

namespace Shipping_Quote_App
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter package weight in pounds.");
            Console.WriteLine("(Use numerals to answer each question.)");
            string inputWeight = Console.ReadLine();
            double packageWeight = Convert.ToDouble(inputWeight);

            if (packageWeight <= 50.0)
            {
                Console.WriteLine("Please enter package width in inches.");
                string inputWidth = Console.ReadLine();
                double packageWidth = Convert.ToDouble(inputWidth);

                Console.WriteLine("Please enter package height in inches.");
                string inputHeight = Console.ReadLine();
                double packageHeight = Convert.ToDouble(inputHeight);

                Console.WriteLine("Please enter package length in inches.");
                string inputLength = Console.ReadLine();
                double packageLength = Convert.ToDouble(inputLength);

                double dimensionTotal = packageLength + packageHeight + packageWidth;

                if (dimensionTotal <= 50.0)
                {
                    double shippingRate = dimensionTotal * packageWeight / 100.0;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + shippingRate.ToString("f") + ".");
                    Console.WriteLine("Thank you.");
                    Console.ReadLine();
                }
                else
                { 
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                    Console.ReadLine();
                }

            }    
            else
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
        }
    }
}
