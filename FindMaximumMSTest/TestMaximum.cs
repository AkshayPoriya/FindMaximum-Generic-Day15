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
        /// Tests the maximum among integers.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <param name="expected">The expected.</param>
        [TestMethod]
        [DataRow(new int[] {10, -5, 7}, 10)]
        [DataRow(new int[] { -5, 10, 7 }, 10)]
        [DataRow(new int[] { 7, -5, 10 }, 10)]
        public void TestMaxAmongIntegers(int[] values, int expected)
        {
            //// Arrange
            FindMaxGeneric<int> findMaxGeneric = new FindMaxGeneric<int>(values);
            //// Act
            int actual = findMaxGeneric.MaxFromArray(values);
            //// Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests the maximum among doubles.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <param name="expected">The expected.</param>
        [TestMethod]
        [DataRow(new double[] { 10.2, -5.1, 7.1 }, 10.2)]
        [DataRow(new double[] { -5.1, 10.2, 7.1 }, 10.2)]
        [DataRow(new double[] { 7.1, -5.1, 10.2 }, 10.2)]
        public void TestMaxAmongDoubles(double[] values, double expected)
        {
            //// Arrange
            FindMaxGeneric<double> findMaxGeneric = new FindMaxGeneric<double>(values);
            //// Act
            double actual = findMaxGeneric.MaxFromArray(values);
            //// Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests the maximum among strings.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <param name="expected">The expected.</param>
        [TestMethod]
        [DataRow(new string[] { "Apple", "Peach", "Banana" }, "Peach")]
        [DataRow(new string[] { "Peach", "Banana", "Apple" }, "Peach")]
        [DataRow(new string[] { "Banana", "Apple", "Peach" }, "Peach")]
        public void TestMaxAmongStrings(string[] values, string expected)
        {
            //// Arrange
            FindMaxGeneric<string> findMaxGeneric = new FindMaxGeneric<string>(values);
            //// Act
            string actual = findMaxGeneric.MaxFromArray(values);
            //// Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
