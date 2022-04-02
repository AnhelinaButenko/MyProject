using System;

namespace SwitchCase.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double Number1, Number2;

            Console.WriteLine("Введите 1 значение :");
            string stringN1 = Console.ReadLine();
            Number1 = Convert.ToDouble(stringN1);

            Console.WriteLine("Введите 2 значение :");
            string stringN2 = Console.ReadLine();
            Number2 = Convert.ToDouble(stringN2);

            Console.WriteLine("Введите знак арифметической операции :");
            string Sign = Console.ReadLine();


            switch (Sign)
            {
                case "+":
                    Console.WriteLine(Number1 + Number2);
                    break;

                case "-":
                    Console.WriteLine(Number1 - Number2);
                    break;

                case "*":
                    Console.WriteLine(Number1 * Number2);
                    break;

                case "/":

                    if (Number2 == 0)
                    {
                        Console.WriteLine("Neverno");
                    }
                    Console.WriteLine(Number1 / Number2);
                    break;

                default:
                    Console.WriteLine("Neverno");
                    break;
            }
        }
    }
}
