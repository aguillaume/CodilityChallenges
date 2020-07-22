using CodiliyChallanges.FrogJump;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var a = new Solution();
            var b = a.solution(1, 1000, 10);
            Assert.Pass(b.ToString());
        }
    }
}