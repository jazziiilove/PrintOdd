/* 
 * Programmer: Baran Topal 
 * Solution name: PrintOdd 
 * Project name: PrintOdd
 * File name: Program.cs
 * Status: Finished
 */

using System;

namespace PrintOdd
{
    /// <summary>
    /// prints the odd numbers between 0 and 100
    /// </summary>
    class Program
    {
        #region methods

        /// <summary>
        /// printing the odd number in recursion
        /// </summary>
        /// <param name="number">number</param>
        public static void PrintOdd(int number)
        {
            if (number < 1)
              return;

            Console.Write("{0}, ", (number -= 2));
            PrintOdd(number);
        }

        /// <summary>
        /// Main gate
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const int number = 99;

            Console.WriteLine("Odd numbers: ");
            PrintOdd(number);
        }
        #endregion methods
    }
}
