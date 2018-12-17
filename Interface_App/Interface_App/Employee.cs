using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_App
{
    //STEP 2.) Employee class now inherets both "Person" class and "IQuittable" interface properties.
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }

        //STEP 2 (cont.) Implemented Quit() method.
        void IQuittable.Quit()
        {
            throw new NotImplementedException();
        }

        //STEP 3.) Created IQuittable object "quitter" and called Quit() method on said object.
        IQuittable quitter = new Employee();

        void Quit(IQuittable quitter)
        {
            throw new NotImplementedException();
        }
    }
}
