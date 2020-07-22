using CodiliyChallanges.PermMissingElem;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject2.PermMissingElem
{
    class Test
    {
        [Test]
        [TestCase(new int[] { 2, 3, 1, 5 }, 4)]
        [TestCase(new int[] { } , 1)]
        [TestCase(new int[] { 2 } , 1)]
        [TestCase(new int[] { 1 } , 2)]
        [TestCase(new int[] { 3, 2 }, 1 )]
        [TestCase(new int[] { 2, 3, 1, 4 }, 5 )]
        public void SolutionTest(int[] data, int expected)
        {
            var a = new Solution();
            var b = a.solution(data);
            Assert.AreEqual(expected, b);
        }
    }
}
