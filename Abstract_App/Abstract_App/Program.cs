using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //STEP 5.) Instantiated new "employee" object, named properties, called SayName() method.
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            employee.SayName();
            Console.ReadLine();
        }
    }
}
