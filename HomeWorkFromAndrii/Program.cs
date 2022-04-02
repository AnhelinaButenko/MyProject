using System;

namespace HomeWorkFromAndrii
{
    class Program
    {
        static void Main(string[] args)
        {
         
            //double[,] array = new double[2, 2] {{ 3,1 }, { 4,5 }};
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        Console.Write(array[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}




            //Console.WriteLine("Введите количество строк для 1 массива (до 5): ");
            //int rows = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите количество столбцов для 1 массива (до 5): ");
            //int columns = Convert.ToInt32(Console.ReadLine());

            //int[,] array1;
            //int[,] array2;

            //array1 = new int[rows, columns];
            //array2 = new int[rows, columns];

            //Console.Write("Enter Elements : \n");
            //for (int i = 0; i < array1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array1.GetLength(1); j++)
            //    {
            //        Console.Write("\tElement[" + i + "," + j + "]: ");
            //        array1[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //Console.Write("\n\nElements are: \n");
            //for (int i = 0; i < array1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array1.GetLength(1); j++)
            //    {
            //        Console.Write(array1[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.Write("Enter Element : \n");
            //for (int i = 0; i < array2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array2.GetLength(1); j++)
            //    {
            //        Console.Write("\tElement[" + i + "," + j + "]:");
            //        array2[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //Console.Write("\n\nElements are: \n");
            //for (int i = 0; i < array2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array2.GetLength(1); j++)
            //    {
            //        Console.Write(array2[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //int[,] Multiplication;

            //Multiplication = new int[rows, columns];

            //Console.Write("Multiplication : \n");
            //for (int i = 0; i < Multiplication.GetLength(0); i++)
            //{
            //    for (int j = 0; j < Multiplication.GetLength(1); j++)
            //    {

            //        Multiplication[i, j] = array1[i, j] * array2[i, j];
            //    }
            //}

            //Console.Write("\n\nElements are: \n");
            //for (int i = 0; i < Multiplication.GetLength(0); i++)
            //{
            //    for (int j = 0; j < Multiplication.GetLength(1); j++)
            //    {
            //        Console.Write(Multiplication[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}









            //int[] numbers = new int [20];
            //Random rand = new Random();


            //int countOfPositive = 0;
            //int countOfNegative = 0;
            //int countOfZero = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    {
            //        numbers[i] = (rand.Next(-4, 10));
            //        Console.WriteLine(numbers[i]);
            //    }

            //    if (numbers[i] > 0)
            //    {
            //        countOfPositive = countOfPositive + 1;
            //    }
            //    if (numbers[i] < 0)
            //    {
            //        countOfNegative = countOfNegative + 1;
            //    }
            //    if (numbers[i] == 0)
            //    {
            //        countOfZero = countOfZero + 1;
            //    }
            //}

            //Console.WriteLine($"Нули:{ countOfZero}");
            //Console.WriteLine($"Положительные:{ countOfPositive}");
            //Console.WriteLine($"Отрицательные:{countOfNegative}");





            //int[] numbers = {-5, 0, 4, -1, 3, 1 };

            //int countOfPositive = 0;
            //int countOfNegative = 0;
            //int countOfZero = 0;
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > 0)
            //    {
            //        countOfPositive = countOfPositive + 1;
            //    }
            //    if (numbers[i] < 0)
            //    {
            //        countOfNegative = countOfNegative + 1;
            //    }
            //    if (numbers[i] == 0) 
            //    {
            //        countOfZero = countOfZero + 1;
            //    }

            //}
            //Console.WriteLine(countOfZero);
            //Console.WriteLine(countOfPositive);
            //Console.WriteLine(countOfNegative);






            //int result;

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        result = i * j;
            //        Console.Write($"{result}\t");
            //    }

            //    Console.Write("\n");
            //}


            //Console.WriteLine("Введите число: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //int i = 0;

            //while (number > 0)
            //{
            //    number = number / 10;

            //    i++;
            //}

            //Console.WriteLine(i);




            //Console.WriteLine("Введите длину массива: ");
            //int numberLength = Convert.ToInt32(Console.ReadLine());
            //double[] array = new double[numberLength];
            //double sum = 0;
            //double mult = 1;

            //Console.WriteLine("Введите элементы массива: ");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine($" Введите {i + 1} число");
            //    double number = Convert.ToDouble(Console.ReadLine());
            //    array[i] = number;

            //    mult *= array[i];

            //    sum += array[i];

            //}
            //Console.WriteLine(mult);
            //Console.WriteLine(sum);







            //Console.WriteLine("Введите длину массива: ");
            //int numberLength = Convert.ToInt32(Console.ReadLine());
            //int[] array = new int[numberLength];

            //Console.WriteLine("Введите элементы массива: ");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine($" Введите {i + 1} число");
            //    int number = Convert.ToInt32(Console.ReadLine());
            //    array[i] = number;
            //}

            //double sum = 0;
            //double result;
            //int counter = 0;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (0 < array[i])
            //    {
            //        counter++;
            //        sum = sum + array[i];   
            //    }


            //}

            //Console.WriteLine(sum / counter);







            //int [] array1 = new int[3];
            //int [] array2 = new int [3];
            //int [] array3 = new int[3];

            //Random rand = new Random();

            //Console.WriteLine(rand.Next(10));

            //Console.WriteLine("Введите элементы 1 массива: ");
            //for (int i = 0; i < array1.Length; i++)
            //{

            //    array1[i] = (rand.Next(10));
            //    Console.WriteLine(array1[i]);
            //}

            //Console.WriteLine("Введите элементы 2 массива: ");
            //for (int i = 0; i < array2.Length; i++)
            //{
            //    Console.WriteLine($"Введите {i + 1} число");
            //    int Number = Convert.ToInt32(Console.ReadLine());
            //    array2[i] = Number;
            //}

            //Console.WriteLine("Элементы 3 массива: ");
            //for (int i = 0; i < array3.Length; i++)
            //{
            //    array3[i] = array1[i] + array2[i];
            //    Console.WriteLine(array3[i]);
            //}


            //string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //string lowercase = "abcdefghijklmnopqrstuvwxyz";
            //string testString = "AnLin";

            //int counter = 0;

            //for (int i = 0; i < testString.Length; i++)
            //{
            //    for (int j = 0; j < uppercase.Length; j++)
            //    {
            //        if (testString[i] == uppercase[j])
            //        {
            //            counter++;
            //            break;
            //        }
            //    }
            //}
            //Console.WriteLine($"uppercase = {counter}");
            //Console.WriteLine($"lowercase = {testString.Length - counter}");







            //int[] Numbers = { 10, -3, -5, 2, 5 };

            //for (int i = 2; i <  Numbers.Length; i+=2)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}



            //int max = Numbers [2];

            //for (int i = 2; i < Numbers.Length; i+=2)
            //{
            //    if (Numbers[i] > max)
            //    {
            //        max = Numbers[i];
            //    }
            //    Console.WriteLine(max);

            //}

            //Console.WriteLine(max);



            //Console.WriteLine("Введите число:");
            //int Number = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(Number * i);
            //}



            //int[] Numbers = { 10, -3, -5, 2, 5 };

            //int min = Numbers[0];
            //int numberOfMinElement = 1;


            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    int current = Math.Abs(Numbers[i]);

            //    if (current < min)
            //    {
            //        min = current;
            //        numberOfMinElement = i + 1;
            //    }
            //}

            //Console.WriteLine(min);
            //Console.WriteLine(numberOfMinElement);


            //Console.WriteLine("Введите число:");
            //int step = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Введите минимальное натуральное число:");
            //int min = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Введите миксимальное натуральное число:");
            //int max = Convert.ToInt32(Console.ReadLine());

            //for (int index = min          /*, Number2 = max */;       index <= max; index += step)
            //{
            //    Console.WriteLine(index);
            //}


            //Console.WriteLine("Введите 1 число:");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Введите 2 число:");
            //int b = Convert.ToInt32(Console.ReadLine());

            //int c = 0;

            //c = a;
            //a = b;
            //b = c;

            //Console.WriteLine(a);
            //Console.WriteLine(b);


            //Console.WriteLine("Введите 1 число:");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Введите 2 число:");
            //int b = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Введите 1 число:");
            //int c = Convert.ToInt32(Console.ReadLine());


            //int m = 0;
            //int max = 0;

            //if (a > b && a > c)
            //{
            //    max = a;
            //}

            //else if (b > a && b > c)
            //{
            //    max = b;
            //}

            //else
            //{
            //    max = c;
            //}

            //m = max;

            //Console.WriteLine(m);



            //Console.WriteLine("Введите число: ");
            //int Number = Convert.ToInt32(Console.ReadLine());
            //int Result = 0;

            //Console.WriteLine("Выберите байт напиcав b или килобайт написав k");
            //string bOrK = Console.ReadLine();


            //if (bOrK == "b")
            //{
            //   Result = Number * 1024;
            //}

            //if (bOrK == "k")
            //{
            //   Result = Number / 1024;
            //}

            //Console.WriteLine(Result);




            //Console.WriteLine("Введите значение для Х: ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //int y = 0;

            //if ( x > 0 )
            //{
            //    y = 2 * x - 10;
            //}

            //else if (x == 0)
            //{
            //    y = 0;
            //}

            //else if (x < 0)
            //{
            //    y = 2 * (Math.Abs(x) - 1);
            //}

            //Console.WriteLine(y);

        }


    }
}
