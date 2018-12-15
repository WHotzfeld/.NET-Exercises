using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class_App
{
    class Divider
    {
        //STEP 1.) Created "Divider" class. Created void "Half" method.
        //STEP 4.) Altered original method to contain out parameter. Added second method to allow for multiple methods.
        public static void Half(out int dividedNum, int userInt)
        {
            dividedNum = userInt / 2;
        }

        //STEP 5.) Made second method to overload "Half" method.
        public static void Half(int userInt)
        {
            int dividedNum = userInt / 2;
        }
    }
}
