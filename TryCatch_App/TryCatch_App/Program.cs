using System;
using System.Collections.Generic;

namespace TryCatch_App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter a number to divide several numbers by.");
                Console.WriteLine("These numbers are 12, 14, 84, 135, and 3.");
                int userDiv = Convert.ToInt32(Console.ReadLine());
                List<int> divNumbers = new List<int>() { 12, 14, 84, 135, 3 };
                foreach (int number in divNumbers)
                {
                    Console.WriteLine(number / userDiv);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Cannot divide by that. Please enter a whole number in numeral form.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Dividing by zero can easily cause the end of the universe. Please enter a different number.");
            }
            finally
            {
                Console.WriteLine("Exit and restart the program to try again with a different input.");
                Console.ReadLine();
            }
            
        }
    }
}
