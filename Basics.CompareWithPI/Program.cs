using System;

namespace Basics.CompareWithPI
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.141593;
            const bool MY_CONST = true;
            Console.WriteLine("Введите значение:");
            double value = Convert.ToDouble(Console.ReadLine());

            bool isEqual = PI == value;
            Console.WriteLine($"{PI} == {value} = {isEqual}");
            bool isNotEqual = PI != value;
            Console.WriteLine($"{PI} != {value} = {isNotEqual}");

            bool isConstBigger = PI > value;
            Console.WriteLine($"{PI} > {value} = {isConstBigger}");

            bool isEqual1 = MY_CONST == isConstBigger;
            Console.WriteLine($"{MY_CONST} == {isConstBigger} = {isEqual1}");
        }
    }
}
