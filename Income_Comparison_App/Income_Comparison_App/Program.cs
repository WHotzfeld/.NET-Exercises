using System;

namespace Income_Comparison_App
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1: Please enter your your hourly rate (numerals only, please).");
            string p1_hourly = Console.ReadLine();
            double p1_rate = Convert.ToDouble(p1_hourly);
            Console.WriteLine("Person 1: Please enter the number of hours you work per week (numerals only, please).");
            string p1_work = Console.ReadLine();
            double p1_hours = Convert.ToDouble(p1_work);

            Console.WriteLine("Person 2: Please enter your your hourly rate (numerals only, please).");
            string p2_hourly = Console.ReadLine();
            double p2_rate = Convert.ToDouble(p2_hourly);
            Console.WriteLine("Person 2: Please enter the number of hours you work per week (numerals only, please).");
            string p2_work = Console.ReadLine();
            double p2_hours = Convert.ToDouble(p2_work);

            Console.WriteLine("While working 52 weeks per year, Person 1's salary is:");
            double p1_salary = p1_rate * p1_hours * 52;
            Console.WriteLine(p1_salary);

            Console.WriteLine("While working 52 weeks per year, Person 2's salary is:");
            double p2_salary = p2_rate * p2_hours * 52;
            Console.WriteLine(p2_salary);

            Console.WriteLine("Is Person 1's annual salary greater than Person 2's annual salary?");
            bool salary_compare = p1_salary > p2_salary;
            Console.WriteLine(salary_compare);
            Console.ReadLine();

        }
    }
}
