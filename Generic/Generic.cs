using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    public class Generic <T> where T: IComparable
    {
        public T first, second, third;

        public Generic(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;

        }
        /// <summary>
        /// UC-1, 2, 3 Refactored To find maximum value
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <param name="thirdNumber"></param>
        /// <returns></returns>
        public static T MaxAmongThreeGenericInput(params T[] value)
        {
            Console.WriteLine("Maximum Value using generic inputs");
            if (value[0].CompareTo(value[1]) > 0 && value[0].CompareTo(value[2]) > 0)
                return value[0];

            else if (value[1].CompareTo(value[0]) > 0 && value[1].CompareTo(value[2]) > 0)
            {
                return value[1];
            }
            else if (value[2].CompareTo(value[0]) > 0 && value[2].CompareTo(value[1]) > 0)
            {
                return value[2];
            }
            return value[1];
        }

        /// <summary>
        /// Generic Method
        /// </summary>
        /// <returns></returns>
        public T MaxMethod()
        {
            T max = Generic<T>.MaxAmongThreeGenericInput(this.first, this.second, this.third);
            return max;
        }
    }
}
