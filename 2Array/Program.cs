using System;

namespace _2Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк и столбцов для массива");
            int rowsAndColumns = Convert.ToInt32(Console.ReadLine());

            int[,] array;

            array = new int[rowsAndColumns, rowsAndColumns];

            Console.Write("Elements: \n");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine("\tElement[" + i + "," + j + "]: ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }

            Console.Write("Diagonal: \n");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine(array[i, j]);
                    }
                }
                Console.WriteLine();
            }

            int sum = 0;

            Console.Write("Sum: \n");
            for (int i = 0; i < rowsAndColumns; i++)
            {
                {
                    sum += array[i, i];
                }
                Console.WriteLine();
            }

            Console.WriteLine(sum);

        }
    }
}
