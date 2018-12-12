using System;

namespace Method_Optional_App
{
    class Magic
    {
        //STEP 1.) Created "Magic" class. Created "Calc" method that takes two integers, one optional, and returns an integer.
        //NOTE: The second integer has a default, but the default may be superfluous thanks to additional code in the main().
        // Said code is noted on main().
        public static int Calc(int firstInput, int secondInput = 0)
        {
            int calcAnswer = 20 + firstInput + secondInput;
            return calcAnswer;
        }
    }
}
