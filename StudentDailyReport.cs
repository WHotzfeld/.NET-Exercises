using System;


namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main()
        {
           
            Console.WriteLine("The Tech Academy");

            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();

            Console.WriteLine("What page number?");
            string coursePage = Console.ReadLine();
            int pageNumber = Convert.ToInt32(coursePage);

            Console.WriteLine("Do you need anything? Please answer \"true\" or \"false\".");
            string help_TF = Console.ReadLine();
            bool needHelp = Convert.ToBoolean(help_TF);

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExp = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string studFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            int studyTime = Convert.ToInt32(studyHours);

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}
