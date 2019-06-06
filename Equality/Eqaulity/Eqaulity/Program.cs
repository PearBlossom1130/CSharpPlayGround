using System;

namespace Eqaulity
{
    class Program
    {
        static void Main(string[] args)
        {
            int three = 3;
            int threeAgain = 3;

            bool compareThem = (three == threeAgain);

            // Casting value types to object boxes them
            // Below is reference comparison
            bool objCompare = (object)three == (object)threeAgain;


            // Casting value types to interface boxes them
            // Below is reference comparison
            bool interfaceCompare = (IComparable<int>)three == (IComparable<int>)threeAgain;

        }
    }
}
