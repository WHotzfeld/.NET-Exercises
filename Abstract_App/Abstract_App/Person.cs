using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_App
{
    //STEP 1.) Created "Person" abstract class with FirstName and LastName properties.
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //STEP 2.) Created method "SayName."
        public abstract void SayName();
    }
}
