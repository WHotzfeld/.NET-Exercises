using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Feat_App
{
    public class Panda
    {
        //STEP [all].) Created parameters and constructor for Panda class.
        public string Name { get; set; }
        public string ColorOne { get; set; }
        public string ColorTwo { get; set; }
        public string Species { get; set; }

        public Panda(string name, string furColor1, string furColor2, string species)
        {
            Name = name;
            ColorOne = furColor1;
            ColorTwo = furColor2;
            Species = species;
        }

        //STEP 3 (cont). Created constructor call chain.
        public Panda(string name) : this(name, "Black", "White", "Panda Bear")
        {
        }
        
    }
}
