using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee { FirstName = "Sample", LastName = "Student" };

            //STEP 3.) Created IQuittable object "quitter" and called Quit() method on said object.
            IQuittable quitter = new Employee();
            quitter.Quit(employee);

            employee.SayName();
            Console.ReadLine();
        }
    }
}
