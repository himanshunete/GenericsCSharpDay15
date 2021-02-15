using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    public class Generic <T> where T: IComparable
    {
        /// <summary>
        /// UC-1, 2, 3 Refactored To find maximum value
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <param name="thirdNumber"></param>
        /// <returns></returns>
        public static T MaxAmongThreeGenericInput(T first, T second, T third)
        {
            Console.WriteLine("Maximum Value using generic inputs");
            if (first.CompareTo(second) > 0 && second.CompareTo(third) > 0)
                return first;

            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                return third;
            }
            return second;
        }
    }
}
