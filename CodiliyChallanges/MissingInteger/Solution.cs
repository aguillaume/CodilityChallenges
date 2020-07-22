using System;
using System.Collections.Generic;
using System.Text;

namespace CodiliyChallanges.MissingInteger
{
    public class Solution
    {
        public int solution(int[] A)
        {
            // write your code in Java SE 8
            var res = new int[1000001];
            for (int i = 0; i < A.Length; i++)
            {
                var x = A[i];
                if (x < 1) continue;
                res[x]++;
            }

            for (int i = 1; i < res.Length; i++)
            {
                if (res[i] == 0) return i;
            }
            return 0;
        }
    }
}
