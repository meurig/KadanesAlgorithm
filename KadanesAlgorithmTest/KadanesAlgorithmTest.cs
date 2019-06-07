//-----------------------------------------------------------------------
// <copyright file="KadanesAlgorithmTest.cs" company="Local Leaves Limited">
//     Copyright (c) Local Leaves Limited. All rights reserved.
// </copyright>
// <author>Meurig Freeman</author>
//-----------------------------------------------------------------------

namespace KadanesAlgorithmTest
{
    using KadanesAlgorithm;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Provides unit tests for the <see cref="KadanesAlgorithm"/> class.
    /// </summary>
    [TestClass]
    public class KadanesAlgorithmTest
    {
        /// <summary>
        /// Method: GetSubarrayWithMaximumSum()
        /// Conditions: Short array (five elements)
        /// Expected: Correct result.
        /// </summary>
        [TestMethod]
        public void GetSubarrayWithMaximumSum()
        {
            // Arrange
            var input = new int[] { 1, 3, -20, 5, 10 };

            // Act
            var (start, end, sum) = KadanesAlgorithm.GetSubarrayWithMaximumSum(input);

            // Assert
            Assert.AreEqual(3, start);
            Assert.AreEqual(4, end);
            Assert.AreEqual(15, sum);
        }
    }
}
