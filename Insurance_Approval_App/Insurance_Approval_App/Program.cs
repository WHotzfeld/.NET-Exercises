using System;

namespace Insurance_Approval_App
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please answer the following questions to complete your insurance approval process:");

            Console.WriteLine("What is your age? (Numerals only, please.)");
            string ageInput = Console.ReadLine();
            int driverAge = Convert.ToInt32(ageInput);

            Console.WriteLine("Have you ever had a DUI? Please answer \"true\" or \"false\".");
            string duiInput = Console.ReadLine();
            bool duiStatus = Convert.ToBoolean(duiInput);

            Console.WriteLine("How many speeding tickets do you have? (Numerals only, please.)");
            string ticketInput = Console.ReadLine();
            int speedingTickets = Convert.ToInt32(ticketInput);

            bool isApproved = (driverAge > 15 && duiStatus == false && speedingTickets < 4);
            Console.WriteLine("Thank you for your responses. Checking status... Approved?");
            Console.WriteLine(isApproved);

            Console.ReadLine();
        }
    }
}
