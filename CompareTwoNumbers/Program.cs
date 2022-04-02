using System;

namespace CompareTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. (в том же выражении) Если проверка возвращает true – первому числу должно
            //присвоится значение 100, иначе 100 должно присвоится второму введенному
            //числу.
            //4.Выведите информацию о числах и их итоговых значениях на экран консоли.


            int Number1, Number2, Comparison;
            Console.WriteLine("Введите 1 число :");
            string stringN1 = Console.ReadLine();
            Number1 = Convert.ToInt32(stringN1);

            Console.WriteLine("Введите 2 число :");
            string stringN2 = Console.ReadLine();
            Number2 = Convert.ToInt32(stringN2);

            Comparison = Number1 >= Number2 ? Number1 = 100 : Number2 = 100;
            Console.WriteLine(Comparison);
        }
    }
}
