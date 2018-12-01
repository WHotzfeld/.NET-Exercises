using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_List_App
{
    class Program
    {
        static void Main()
        {
            //Begin program / String array
            Console.WriteLine("Welcome to the Tech High School database!");
            Console.WriteLine("Please type a student number (1-4) to see the student's last name.");
            string[] studentName = { "Franklin", "Harkson", "Smith", "Williams" };
            int studentID = Convert.ToInt32(Console.ReadLine()) - 1;
            while (studentID != 0 && studentID != 1 && studentID != 2 && studentID != 3)
            {
                Console.WriteLine("I'm sorry, that student number could not be found. Please try another number (1-4).");
                studentID = Convert.ToInt32(Console.ReadLine()) - 1;
            }
            Console.WriteLine(studentName[studentID]);
            

            //Begin Int array
            Console.WriteLine("\n Please type a student number (1-4) to see the student's most recent test score.");
            int[] testScore = { 95, 70, 90, 100 };
            studentID = Convert.ToInt32(Console.ReadLine()) - 1;
            while (studentID != 0 && studentID != 1 && studentID != 2 && studentID != 3)
            {
                Console.WriteLine("I'm sorry, that student number could not be found. Please try another number (1-4).");
                studentID = Convert.ToInt32(Console.ReadLine()) - 1;
            }
            Console.WriteLine(testScore[studentID]);


            //Begin String list
            Console.WriteLine("\n Please type a student number (1-4) to see the student's answer to the most recent test.");
            List<string> testAnswer = new List<string>();
            testAnswer.Add("George Washingtun");
            testAnswer.Add("Wash Georgeington");
            testAnswer.Add("Georg Woshingten");
            testAnswer.Add("George Washington");
            studentID = Convert.ToInt32(Console.ReadLine()) - 1;
            while (studentID != 0 && studentID != 1 && studentID != 2 && studentID != 3)
            {
                Console.WriteLine("I'm sorry, that student number could not be found. Please try another number (1-4).");
                studentID = Convert.ToInt32(Console.ReadLine()) - 1;
            }
            Console.WriteLine(testAnswer[studentID]);
            Console.ReadLine();

        }
    }
}
