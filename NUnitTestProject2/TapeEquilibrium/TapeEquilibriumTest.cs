using CodiliyChallanges.TapeEquilibrium;
using NUnit.Framework;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace NUnitTestProject2.TapeEquilibrium
{
    class TapeEquilibriumTest
    {
        [Test]
        [TestCase(new int[] { 3, 1, 2, 4, 3}, 1)]
        [TestCase(new int[] { 0, 0}, 0)]
        [TestCase(new int[] { -1000, 1000}, 2000)]
        [TestCase(new int[] { 1000, -1000}, 2000)]
        [TestCase(new int[] { -1000, -1000}, 0)]
        public void SolutionTest(int[] data, int expected)
        {
            var a = new Solution();
            var b = a.solution(data);
            Assert.AreEqual(expected, b);
        }

        [Test]
        [TestCase(10000)]
        [TestCase(100000)]
        [TestCase(1000000)]
        public void PerformanceTest(int size)
        {
            var r = new Random();
            var data = new int[size];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = r.Next(-1000, 1000);
            }
            var a = new Solution();

            var timer = new Stopwatch();
            timer.Start();
            var b = a.solution(data);
            timer.Stop();
            Assert.IsTrue(timer.ElapsedMilliseconds < 100, $"running time: {timer.ElapsedTicks}");
            Assert.Pass($"running time: {timer.ElapsedTicks}");

        }
    }
}
