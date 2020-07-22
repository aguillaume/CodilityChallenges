using System;
using System.Collections.Generic;
using System.Text;

namespace CodiliyChallanges.FrogRiverOne
{
    public class Solution
    {
        public int solution(int X, int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var arrCount = new int[100001];
            var leavesOnPath = 0;
            for (int i = 0; i < A.Length; i++)
            {
                arrCount[A[i]]++;
                if (A[i] <= X && arrCount[A[i]] == 1) leavesOnPath++;

                if (leavesOnPath == X) return i;
            }
            return -1;
        }
    }
}
