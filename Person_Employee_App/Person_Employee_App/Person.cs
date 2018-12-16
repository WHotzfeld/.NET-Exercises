using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Employee_App
{
    class Person
    {
        //STEP 1.) Created class "Person" with two string properties.
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //STEP 2.) Created void method "SayName" which displays the string values.
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
