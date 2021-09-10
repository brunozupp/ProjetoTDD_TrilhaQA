using System;
using System.Linq;

namespace UseTestCase
{
    public class MyMath
    {
        public static int Factorial(int n)
        {
            return Enumerable.Range(1, n).Aggregate(1, (x, y) => x * y);
        }
    }
}
