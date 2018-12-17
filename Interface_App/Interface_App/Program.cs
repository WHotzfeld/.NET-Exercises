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
            Employee employee = new Employee { FirstName = "Sample", LastName = "Student", Id = 201 };
            Employee someGuy = new Employee { FirstName = "Another", LastName = "Employee", Id = 202 };
            IQuittable quitter = new Employee();
            
            //DRILL p.129 STEP 1 (cont.) Added if/else to test overloaded == operator.
            if (employee==someGuy)
            {
                Console.WriteLine("Selected employees share ID numbers.");
            }
            else
            {
                Console.WriteLine("Different employees selected: \n" + employee.LastName + " " + employee.Id + "\n" + someGuy.LastName + " " + someGuy.Id);
            }
            Console.ReadLine();
        }
    }
}
