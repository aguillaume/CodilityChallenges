using System;
using System.Collections.Generic;
using System.Linq;

namespace CodiliyChallanges.TapeEquilibrium
{
    public class Solution
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var left = 0;
            var right = 0;
            left = A[0];
            right = A.Sum() - left;

            var minDiff = Math.Abs(left - right);

            for (int i = 1; i < A.Length-1; i++)
            {
                left += A[i];
                right -= A[i];
                var diff = Math.Abs(left - right);
                if (diff < minDiff) minDiff = diff;
            }

            return minDiff;
        }
    }
}
