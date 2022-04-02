using System;

namespace LoopWHILE.NumbersFromZeroToUserNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //int Number1, Number2, max, min;

            //Console.WriteLine("Введите число: ");
            //string stringN1 = Console.ReadLine();
            //Number1 = Convert.ToInt32(stringN1);

            //Console.WriteLine("Введите число: ");
            //string stringN2 = Console.ReadLine();
            //Number2 = Convert.ToInt32(stringN2);


            //if (Number2 > Number1)
            //{

            //    min = Number1;
            //    max = Number2;
                
            //}
            //else
            //{
            //    max = Number1;
            //    min = Number2;
            //}



            // while (Number1<= Number2)

            //{


            //    if (Number1 % 2 != 0)
            //    {
            //        Console.WriteLine(Number1);

            //    }
            //    Number1 = Number1 + 1;


                int Number1, Number2, max, min;

                Console.WriteLine("Введите число: ");
                string stringN1 = Console.ReadLine();
                Number1 = Convert.ToInt32(stringN1);

                Console.WriteLine("Введите число: ");
                string stringN2 = Console.ReadLine();
                Number2 = Convert.ToInt32(stringN2);


                if (Number2 > Number1)
                {

                    min = Number1;
                    max = Number2;

                }
                else
                {
                    max = Number1;
                    min = Number2;
                }



                while (min <= max)

                {


                    if (min % 2 != 0)
                    {
                        Console.WriteLine(min);

                    }
                    min = min + 1;


                }
        }
    }
}
