using System;
using System.Collections.Generic;
using System.Text;

namespace CodiliyChallanges.MaxCounters
{
    public class Solution
    {
        public int[] solution(int N, int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var res = new int[N];
            var maxCounter = 0;
            var counterBase = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] <= N)
                {
                    var x = A[i] - 1;
                    res[x] = (res[x] < counterBase) ? counterBase + 1 : res[x] + 1;

                    if (maxCounter < res[x]) maxCounter = res[x];
                }
                else
                {
                    counterBase = maxCounter;
                }
            }

            for (int i = 0; i < res.Length; i++)
            {
                if (res[i] < counterBase) res[i] = counterBase;
            }

            return res;
        }
    }
}
