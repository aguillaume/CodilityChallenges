using CodiliyChallanges.MaxCounters;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace NUnitTestProject2.MaxCounters
{
    class MaxCountersTest
    {
        [Test]
        [TestCase(new int[] { 3, 4, 4, 6, 1, 4, 4 }, 5, new int[] { 3, 2, 2, 4, 2 })]
        [TestCase(new int[] { 3, 4, 4, 6, 1, 4, 4, 6, 4 }, 5, new int[] { 4, 4, 4, 5, 4 })]
        [TestCase(new int[] { 3, 4, 4, 1, 4, 4, 4 }, 5, new int[] { 1, 0, 1, 5, 0 })]
        [TestCase(new int[] { 3, 4, 4, 6, 1, 4, 4, 6 }, 5, new int[] { 4, 4, 4, 4, 4 })]
        [TestCase(new int[] { 6 }, 5, new int[] { 0, 0, 0, 0, 0 })]
        [TestCase(new int[] { 6 }, 5, new int[] { 0, 0, 0, 0, 0 })]
        [TestCase(new int[] { 1, 1, 6, 1, 1, 6, 6, 1, 1, 6, 6, 1, 1, 1 , 6 }, 5, new int[] { 9, 9, 9, 9, 9 })]
        [TestCase(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 , 6, 6, 6, 6, 6, 6 }, 5, new int[] { 9, 9, 9, 9, 9 })]
        public void SolutionTest(int[] operations, int X, int[] expected)
        {
            var a = new Solution();
            var b = a.solution(X, operations);
            Assert.AreEqual(expected, b);
        }

        [Test]
        [TestCase(1000)]
        [TestCase(10000)]
        [TestCase(100000)]
        public void PerformanceTest(int size)
        {
            var r = new Random();
            var leaves = new int[size];
            var x = r.Next(1, 100000);
            for (int i = 0; i < leaves.Length; i++)
            {
                leaves[i] = r.Next(1, 100000);
            }
            var a = new Solution();

            var timer = new Stopwatch();
            timer.Start();
            var b = a.solution(x, leaves);
            timer.Stop();
            Assert.IsTrue(timer.ElapsedMilliseconds < 100, $"running time: {timer.ElapsedTicks / 1000M}ms");
            Assert.Pass($"Solution: {b}, running time: {timer.ElapsedTicks / 1000M}ms");
        }

    }
}
