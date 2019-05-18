using System;
using System.Collections.Generic;

namespace HelloWorld1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++) {
                string val = TurnNumberIntoString(i);
                Console.WriteLine(val);
            }

            ////int[] things = new int[]{ 1, 2, 3 };
            List<int> things = new List<int> { 1, 2, 3 };

            foreach (int thing in things)
            {
                string val = TurnNumberIntoString(thing);
                Console.WriteLine(val);
            }
        }

        public static string TurnNumberIntoString(int aNumber)
        {
            int blah = aNumber * 1000 + 150;
            string returnValue = $"the value of {nameof(blah)} is {blah}";
            return returnValue;
        }
    }
}
