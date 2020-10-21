// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Akshay Poriya"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FindMaximum
{
    using System;

    /// <summary>
    /// Program class contains Main function
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Max among 5, 10 and 15 is: " + MaxAmongIntegers(5, 10, 15));
            Console.WriteLine("Max among 5.1, 10.1 and 15.1 is: " + MaxAmongDoubles(5.1, 10.1, 15.1));
            Console.WriteLine("Max among Apple, Peach and Banana is: " + MaxAmongStrings("Apple", "Peach", "Banana"));
        }

        /// <summary>
        /// return Maximum among integers.
        /// </summary>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <param name="thirdValue">The third value.</param>
        /// <returns>
        /// max integer
        /// </returns>
        public static int MaxAmongIntegers(int firstValue, int secondValue, int thirdValue)
        {
            if ((firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0) ||
                (firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0) ||
                (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0))
            {
                return firstValue;
            }

            if ((secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0) ||
                (secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) > 0) ||
                (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) >= 0))
            {
                return secondValue;
            }

            if ((thirdValue.CompareTo(secondValue) > 0 && thirdValue.CompareTo(firstValue) > 0) ||
                (thirdValue.CompareTo(secondValue) >= 0 && thirdValue.CompareTo(firstValue) > 0) ||
                (thirdValue.CompareTo(secondValue) > 0 && thirdValue.CompareTo(firstValue) >= 0))
            {
                return thirdValue;
            }

            return firstValue;
        }

        /// <summary>
        /// Maximums the among doubles.
        /// </summary>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <param name="thirdValue">The third value.</param>
        /// <returns>
        /// return double
        /// </returns>
        public static double MaxAmongDoubles(double firstValue, double secondValue, double thirdValue)
        {
            if ((firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0) ||
                (firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0) ||
                (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0))
            {
                return firstValue;
            }

            if ((secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0) ||
                (secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) > 0) ||
                (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) >= 0))
            {
                return secondValue;
            }

            if ((thirdValue.CompareTo(secondValue) > 0 && thirdValue.CompareTo(firstValue) > 0) ||
                (thirdValue.CompareTo(secondValue) >= 0 && thirdValue.CompareTo(firstValue) > 0) ||
                (thirdValue.CompareTo(secondValue) > 0 && thirdValue.CompareTo(firstValue) >= 0))
            {
                return thirdValue;
            }

            return firstValue;
        }

        /// <summary>
        /// Maximums the among strings.
        /// </summary>
        /// <param name="firstString">The first string.</param>
        /// <param name="secondString">The second string.</param>
        /// <param name="thirdString">The third string.</param>
        /// <returns>
        /// return string
        /// </returns>
        public static string MaxAmongStrings(string firstString, string secondString, string thirdString)
        {
            if ((firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) > 0) ||
                (firstString.CompareTo(secondString) >= 0 && firstString.CompareTo(thirdString) > 0) ||
                (firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) >= 0))
            {
                return firstString;
            }

            if ((secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) > 0) ||
                (secondString.CompareTo(firstString) >= 0 && secondString.CompareTo(thirdString) > 0) ||
                (secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) >= 0))
            {
                return secondString;
            }

            if ((thirdString.CompareTo(secondString) > 0 && thirdString.CompareTo(firstString) > 0) ||
                (thirdString.CompareTo(secondString) >= 0 && thirdString.CompareTo(firstString) > 0) ||
                (thirdString.CompareTo(secondString) > 0 && thirdString.CompareTo(firstString) >= 0))
            {
                return thirdString;
            }

            return firstString;
        }
    }
}
