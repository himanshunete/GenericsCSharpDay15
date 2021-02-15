using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    /// <summary>
    /// UC-1 Find maximum integer value
    /// </summary>
    public class MaxThreeNumbers
    {

        /// <summary>
        /// UC-1 To find maximum integer value
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <param name="thirdNumber"></param>
        /// <returns></returns>
        public int MaxOfThreeNumbers(int firstNumber, int secondNumber, int thirdNumber)
        {
            Console.WriteLine("Maximum Number using non generic for integer value");
            if(firstNumber.CompareTo(secondNumber) >0 && secondNumber.CompareTo(thirdNumber) > 0)
                return firstNumber;
            
            else if (secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
            {
                return secondNumber;
            }
            else if (thirdNumber.CompareTo(firstNumber) > 0 && thirdNumber.CompareTo(secondNumber) > 0)
            {
                return thirdNumber;
            }
            return secondNumber;
        }

        /// <summary>
        /// UC-2 To find maximum float value
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <param name="thirdNumber"></param>
        /// <returns></returns>
        public float MaxOfThreeFloats(float firstNumber, float secondNumber, float thirdNumber)
        {
            Console.WriteLine("Maximum Number using non generic for float value");
            if (firstNumber.CompareTo(secondNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
            {
                return firstNumber;
            }

            else if (secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
            {
                return secondNumber;
            }
            else if (thirdNumber.CompareTo(firstNumber) > 0 && thirdNumber.CompareTo(secondNumber) > 0)
            {
                return thirdNumber;
            }
            return firstNumber;
        }

        /// <summary>
        /// UC-3 To find maximum string value
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <param name="thirdNumber"></param>
        /// <returns></returns>
        public string MaxOfThreeString(string first, string second, string third)
        {
            Console.WriteLine("Maximum value using non generic for string value");
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
            return first;
        }
    }
}
