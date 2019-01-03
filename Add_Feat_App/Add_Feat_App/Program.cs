using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Feat_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //STEP 1.) Created constant string "species".
            const string species = "Panda Bear";

            //STEP 2.) Created var object from Panda class. (Also, used const "species" to test STEP 1.)
            var firstPanda = new Panda("Xiao Mei", "Brown", "White", species);

            //STEP 3.) Created new object from Panda class using constructor call chain.
            Panda secondPanda = new Panda("Lum Lum");

            //STEP X.) Printed all panda info to console to check work.
            var Pandas = new List<Panda> { firstPanda, secondPanda };

            foreach(Panda panda in Pandas)
            {
                Console.WriteLine(panda.Name + " : " + panda.Species + ", " + panda.ColorOne + " & " + panda.ColorTwo + ".");
            }
            Console.ReadLine();
        }
    }
}
