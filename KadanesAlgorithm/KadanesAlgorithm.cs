//-----------------------------------------------------------------------
// <copyright file="KadanesAlgorithm.cs" company="Local Leaves Limited">
//     Copyright (c) Local Leaves Limited. All rights reserved.
// </copyright>
// <author>Meurig Freeman</author>
//-----------------------------------------------------------------------

namespace KadanesAlgorithm
{
    using System;
    using System.Linq;

    /// <summary>
    /// Provides an implementation of Kadanes Algorithm for finding the subarray with maximum sum.
    /// </summary>
    public class KadanesAlgorithm
    {
        /// <summary>
        /// Given an array of items, returns the continuous subarray with maximum sum.
        /// </summary>
        /// <param name="input">An array of integers.</param>
        /// <returns>Two indexes into the input array, giving the start and end of the subarray with maximum sum.</returns>
        public static (int start, int end, int sum) GetSubarrayWithMaximumSum(int[] input)
        {
            if (input.Length == 0)
            {
                throw new ArgumentException("Empty arrays are not supported.");
            }

            // Avoid nulls by assuming first element is our subArray until proven otherwise.
            var (start, end) = (0, 0);
            var (maxStart, maxEnd) = (0, 0);
            var maxSumEndingAtElement = input[0];
            var maxSlice = input[0];
            foreach (var (element, index) in input.Select((element, index) => (element, index)))
            {
                // The max subarray ending at element i (MS[i]) is either element i or element i + MS[i-1]
                // MS[0] is a special case as MS[-1] is not defined (so MS[0] = element 0)
                maxSumEndingAtElement = index == 0 ? element : maxSumEndingAtElement + element;
                end = index;
                if (element >= maxSumEndingAtElement)
                {
                    start = index;
                    maxSumEndingAtElement = element;
                }

                if (maxSumEndingAtElement > maxSlice)
                {
                    (maxStart, maxEnd, maxSlice) = (start, end, maxSumEndingAtElement);
                }
            }

            return (maxStart, maxEnd, maxSlice);
        }
    }
}
