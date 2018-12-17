using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_App
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }

        public override void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
        
        void IQuittable.Quit(Employee employee)
        {
            employee.LastName = employee.LastName + " is a quitter";
        }

        //DRILL p.129, STEP 1.) Overloaded == and != operators to allow for comparison of Employee Id numbers.
        public static bool operator== (Employee employee, Employee someGuy)
        {
            bool idMatch = false;
            if (employee.Id == someGuy.Id)
            {
                idMatch = true;
            }
            return idMatch;
        }

        public static bool operator!= (Employee employee, Employee someGuy)
        {
            bool idDiff = false;
            if (employee.Id != someGuy.Id)
            {
                idDiff = true;
            }
            return idDiff;
        }
    }
}
