using System;
using System.Collections;
using System.Linq;

namespace WorkingWithTypesAndMethods
{
    /// <summary>
    /// Class that includes tasks on the topic of "Types and methods basics" 
    /// </summary>
    public static class Tasks
    {
        /// <summary>
        /// Method that try to find index in array, which separates array into left and right part and sums of left and right parts are equal
        /// </summary>
        /// <param name="numbers">Analyzing array</param>
        /// <returns>Aim index</returns>
        public static int Task1(int[] numbers)
        {
            if (numbers == null)
                throw new ArgumentNullException();

            if (numbers.Length <= 0 || numbers.Length >= 1000)
                throw new ArgumentOutOfRangeException();

            // If array length < 3, there will be no left and(or) right part in this array
            if (numbers.Length < 3)
                return -1;

            int resultIndex = -1;
            int leftSum = 0;
            int rightSum = numbers.Sum() - numbers[0];

            int i = 1;
            bool wasNotFound = true;

            while(wasNotFound && i < numbers.Length)
            {
                leftSum += numbers[i - 1];
                rightSum -= numbers[i];

                if (leftSum == rightSum)
                {
                    wasNotFound = false;
                    resultIndex = i;
                }

                i++;
            }
            
            return resultIndex;
        }

        /// <summary>
        /// Method that create a string by concating 2 strings, then sort this string and remove repeatable chars
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns>A sorted string without repeatable chars</returns>
        public static string Task2(string str1, string str2)
        {
            if (str1 == null || str2 == null)
            {
                throw new ArgumentNullException();
            }

            if (IsStringsHasBannedSymbols(str1, str2))
            {
                throw new ArgumentException();
            }

            //Concat 2 strings
            string resultString = String.Concat(str1, str2);

            //Remove repeatable chars
            resultString = String.Concat(resultString.Distinct());
                        
            //Sort string
            return String.Concat(resultString.OrderBy(c => c));
        }

        /// <summary>
        /// Method that insert second number into first number from position i to position j
        /// </summary>
        /// <param name="numberDestination">Number for insertion</param>
        /// <param name="numberSource">Number which will be inserted</param>
        /// <param name="i">Left boarder</param>
        /// <param name="j">Right boarder</param>
        /// <returns>Updated numberDestination</returns>
        public static int Task3(int numberDestination, int numberSource, int i, int j)
        {
            if (!IsBordersOK(i, j))
            {
                throw new ArgumentException();
            }

            BitArray bitsDestination = new BitArray(new int[] { numberDestination });
            BitArray bitsSource = new BitArray(new int[] { numberSource }); 

            int indexSrc = 0;
            for (int indexDest = i; indexDest <= j; indexDest++)
            {
                // Insert by bitwise OR
                if (bitsSource[indexSrc++] == true || bitsDestination[indexDest] == true)
                    bitsDestination[indexDest] = true;
                else
                    bitsDestination[indexDest] = false; 
            }

            // Convert BitArray to int
            int[] resultArray = new int[1];
            bitsDestination.CopyTo(resultArray, 0);

            return resultArray[0];
        }

        private static bool IsBordersOK(int i, int j)
        {
            return (i <= j && i < 31 && j < 31 && i > -1 && j > -1);
        }

        private static bool IsStringsHasBannedSymbols(string str1, string str2)
        {
            return !(str1.All(c => (c >= 'a') && (c <= 'z')) && str2.All(c => (c >= 'a') && (c <= 'z')));
        } 
    }
}
