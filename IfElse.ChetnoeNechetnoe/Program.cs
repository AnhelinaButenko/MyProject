using System;
using System.Linq;

namespace IfElse.ChetnoeNechetnoe
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number1, Number2, Number3, Number4;

            Console.WriteLine("Введите 1 число :");
            string stringN1 = Console.ReadLine();
            Number1 = Convert.ToInt32(stringN1);

            Console.WriteLine("Введите 2 число :");
            string stringN2 = Console.ReadLine();
            Number2 = Convert.ToInt32(stringN2);

            Console.WriteLine("Введите 3 число :");
            string stringN3 = Console.ReadLine();
            Number3 = Convert.ToInt32(stringN3);

            Console.WriteLine("Введите 4 число :");
            string stringN4 = Console.ReadLine();
            Number4 = Convert.ToInt32(stringN4);





            if ((Number1 % 2) == 0)
            {
                Console.WriteLine("chetnoe");
            }
            else
            {
                Console.WriteLine("nechetnoe");
            }


            if ((Number2 % 2) == 0)
            {
                Console.WriteLine("chetnoe");
            }
            else
            {
                Console.WriteLine("nechetnoe");
            }


            if ((Number3 % 2) == 0)
            {
                Console.WriteLine("chetnoe");
            }
            else
            {
                Console.WriteLine("nechetnoe");
            }


            if ((Number4 % 2) == 0)
            {
                Console.WriteLine("chetnoe");
            }
            else
            {
                Console.WriteLine("nechetnoe");
            }


            int[] Arr = { Number1, Number2, Number3, Number4 };

            int Result = Arr.Select(w => w = w % 2 == 0 ? w : -1).Max();

            string res = string.Join(" ", Result == -1 ? "not found" : Result.ToString());

            Console.WriteLine(res);
        }
    }
}
