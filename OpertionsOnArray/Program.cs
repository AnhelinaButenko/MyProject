using System;

namespace OpertionsOnArray
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Введите длину массива");
            int NumberLength = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[NumberLength];

            int index = 0;

            while (index < NumberLength)
            {
                Console.WriteLine($"Введите {index + 1} число");
                int Number = Convert.ToInt32(Console.ReadLine());
                array[index] = Number;
                index = index + 1; // index++


            }

            Array.Resize<int>(ref array, array.Length + 1);


            Console.WriteLine("Введите число ");
            int Number1 = Convert.ToInt32(Console.ReadLine());

            array[array.Length - 1] = Number1;


        }
    }
}
