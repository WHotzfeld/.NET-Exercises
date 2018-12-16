using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_App
{
    //STEP 3.) Created "Employee" class inherited from "Person" abstract class.
    public class Employee : Person
    {
        //STEP 4.) Implemented SayName() method.
        public override void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
}
