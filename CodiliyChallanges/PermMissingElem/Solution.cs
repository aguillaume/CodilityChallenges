using System;
using System.Collections.Generic;
using System.Text;

namespace CodiliyChallanges.PermMissingElem
{
    public class Solution
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            Array.Sort(A);

            for (int i = 0; i < A.Length; i++)
            {
                var item = A[i];
                if (i+1 != item)
                {
                    return i + 1;
                }
            }
            return A.Length + 1;
        }
    }
}
