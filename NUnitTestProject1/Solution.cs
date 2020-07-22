namespace NUnitTestProject1
{
    internal class Solution
    {
        public int solution(int X, int Y, int D)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            return (int)Math.Ceiling((Y - X) / (double)D);
        }
    }
}