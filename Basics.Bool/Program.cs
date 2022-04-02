using System;

namespace Basics.Bool
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 12, y = 17;

            bool isEqual = x == y;
            Console.WriteLine($"{x} == {y} = { isEqual}");

            bool isNotEqual = x != y;
            Console.WriteLine($"{x} !== {y} = { isNotEqual}");

            bool isLess = x < y;
            Console.WriteLine($"{x} < {y} = {isLess}");

            bool isGreater = x > y;
            Console.WriteLine($"{x}>{y}={isGreater}");

            bool isLessOrEqual = x <= y;
            Console.WriteLine($"{x} <= {y} = {isLessOrEqual} ");

            bool isGreaterOrEqual = x >= y;
            Console.WriteLine($"{x} >= {y} = {isGreaterOrEqual}");

        }
    }
}
