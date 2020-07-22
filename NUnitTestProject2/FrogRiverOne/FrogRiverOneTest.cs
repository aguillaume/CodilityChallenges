using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using CodiliyChallanges.FrogRiverOne;
using System.Diagnostics;

namespace NUnitTestProject2.FrogRiverOne
{
    class FrogRiverOneTest
    {
        [Test]
        [TestCase(new int[] { 1, 3, 1, 4, 2, 3, 5, 4 }, 5, 6)]
        [TestCase(new int[] { 1 }, 1, 0)]
        [TestCase(new int[] { 1 }, 2, -1)]
        [TestCase(new int[] { 5, 6, 7 }, 2, -1)]
        [TestCase(new int[] { 1, 1, 1, 1, 1 }, 5, -1)]
        [TestCase(new int[] { 1,2,3 }, 3, 2)]
        public void SolutionTest(int[] leaves, int X, int expected)
        {
            var a = new Solution();
            var b = a.solution(X, leaves);
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
            Assert.IsTrue(timer.ElapsedMilliseconds < 100, $"running time: {timer.ElapsedTicks/1000M}ms");
            Assert.Pass($"Solution: {b}, running time: {timer.ElapsedTicks/1000M}ms");
        }

        [Test]
        [TestCase(1000)]
        [TestCase(10000)]
        [TestCase(100000)]
        public void PerformanceTest2(int size)
        {
            var r = new Random();
            var leaves = new int[size];
            var x = r.Next(1, size);
            for (int i = 0; i < leaves.Length; i++)
            {
                leaves[i] = i+1;
            }
            var a = new Solution();

            var timer = new Stopwatch();
            timer.Start();
            var b = a.solution(x, leaves);
            timer.Stop();
            Assert.IsTrue(timer.ElapsedMilliseconds < 100, $"running time: {timer.ElapsedTicks / 1000M}ms");
            Assert.Pass($"Solution: {b}, running time: {timer.ElapsedTicks / 1000M}ms");
        }

        [Test]
        [TestCase(3)]
        [TestCase(1000)]
        [TestCase(10000)]
        [TestCase(100000)]
        public void PerformanceTest3(int size)
        {
            var r = new Random();
            var leaves = new int[size];
            var x = size;
            for (int i = 0; i < leaves.Length; i++)
            {
                leaves[i] = i + 1;
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
