using System;

namespace Three_Method_App
{
    class Math
    {
        //STEP 1.) Created "Math" class. Created method "FirstThing" that takes an integer and returns an integer.
        public static int FirstThing(int inputInt)
        {
            int displayInt = inputInt * 2;
            return displayInt;
        }

        //STEP 3.) Created second method "FirstThing" that takes a decimal and returns an integer.
        public static int FirstThing(decimal inputDec)
        {
            int displayDec = Convert.ToInt32(inputDec) + 2;
            return displayDec;
        }

        //STEP 5.) Created third method "FirstThing" that takes a string, converts it to an integer if possible,
        // and returns an integer.
        public static int FirstThing(string inputStr)
        {
            int displayStr = Convert.ToInt32(inputStr) - 2;
            return displayStr;
        }
    }
}
