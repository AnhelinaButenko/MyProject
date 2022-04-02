using System;

namespace TernaryOperator.DivideByFour
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.WriteLine("Введите 1 число :");
            string stringX1 = Console.ReadLine();
            x = Convert.ToInt32(stringX1);

            Console.WriteLine("Введите 2 число :");
            string stringY2 = Console.ReadLine();
            y = Convert.ToInt32(stringY2);


            x = (x % 2) == 0 ? x : x + 1;
            Console.WriteLine(x);

            y = (y % 2) == 0 ? y : y + 1;
            Console.WriteLine(y);

            string Result = Console.ReadLine();

            Result = (x + y) % 4 == 0 ? "Сумма значений { x} и { y} делится на 4" : "Сумма значений { x} и { y} не делится на 4";
            Console.WriteLine(Result);
        }
    }
}
