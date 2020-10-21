// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TestMaximum.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Akshay Poriya"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FindMaximumMSTest
{
    using FindMaximum;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Class to test find max functions
    /// </summary>
    [TestClass]
    public class TestMaximum
    {
        /// <summary>
        /// Tests the MaxAmongIntegers Function of Program Class.
        /// </summary>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <param name="thirdValue">The third value.</param>
        /// <param name="expected">The expected.</param>
        [TestMethod]
        [DataRow(10, -5, 7, 10)]
        [DataRow(-5, 10, 7, 10)]
        [DataRow(7, -5, 10, 10)]
        public void TestMaxAmongIntegers(int firstValue, int secondValue, int thirdValue, int expected)
        {
            //// Arrange
            //// Act
            int actual = Program.MaxAmongIntegers(firstValue, secondValue, thirdValue);
            //// Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests the maximum among Doubles.
        /// </summary>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <param name="thirdValue">The third value.</param>
        /// <param name="expected">The expected.</param>
        [TestMethod]
        [DataRow(10.2, -5.1, 7.1, 10.2)]
        [DataRow(-5.1, 10.2, 7.1, 10.2)]
        [DataRow(7.1, -5.1, 10.2, 10.2)]
        public void TestMaxAmongDoubles(double firstValue, double secondValue, double thirdValue, double expected)
        {
            //// Arrange
            //// Act
            double actual = Program.MaxAmongDoubles(firstValue, secondValue, thirdValue);
            //// Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests the maximum among strings.
        /// </summary>
        /// <param name="firstString">The first string.</param>
        /// <param name="secondString">The second string.</param>
        /// <param name="thirdString">The third string.</param>
        /// <param name="expected">The expected.</param>
        [TestMethod]
        [DataRow("Apple", "Peach", "Banana", "Peach")]
        [DataRow("Peach", "Banana", "Apple", "Peach")]
        [DataRow("Banana", "Apple", "Peach", "Peach")]
        public void TestMaxAmongStrings(string firstString, string secondString, string thirdString, string expected)
        {
            //// Arrange
            //// Act
            string actual = Program.MaxAmongStrings(firstString, secondString, thirdString);
            //// Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
