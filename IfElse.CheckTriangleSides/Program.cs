using System;

namespace IfElse.CheckTriangleSides
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal SideOfTriangle1, SideOfTriangle2, SideOfTriangle3;

            Console.Write("Введите 1 сторону      :");
            string stringSide1 = Console.ReadLine();
            SideOfTriangle1 = Convert.ToDecimal(stringSide1);

            Console.Write("Введите 2 сторону треугольника         :");
            string stringSide2 = Console.ReadLine();
            SideOfTriangle2 = Convert.ToDecimal(stringSide2);

            Console.Write("Введите 3 сторону треугольника         :");
            string stringSide3 = Console.ReadLine();
            SideOfTriangle3 = Convert.ToDecimal(stringSide3);


            decimal triangleView;


            if ((SideOfTriangle1 <= 0 || SideOfTriangle2 <= 0 || SideOfTriangle3 <= 0) || (SideOfTriangle1 + SideOfTriangle2 <= SideOfTriangle3 || SideOfTriangle1 + SideOfTriangle3 <= SideOfTriangle2 || SideOfTriangle3 + SideOfTriangle2 <= SideOfTriangle1))
            {
                Console.WriteLine("Треугольник не существует");
                return;
            }
            else
            {
                Console.WriteLine("Треугольник существует");
                decimal max = Math.Max(Math.Max(SideOfTriangle1, SideOfTriangle2), SideOfTriangle3);
                if (SideOfTriangle1 == max)
                {
                    if (SideOfTriangle1 * SideOfTriangle1 == SideOfTriangle2 * SideOfTriangle2 + SideOfTriangle3 * SideOfTriangle3)
                    {
                        Console.WriteLine("Прямоугольный треугольник");
                    }
                }
                else if (SideOfTriangle2 == max)
                {
                    if (SideOfTriangle2 * SideOfTriangle2 == SideOfTriangle1 * SideOfTriangle1 + SideOfTriangle3 * SideOfTriangle3)
                    {
                        Console.WriteLine("Прямоугольный треугольник");
                    }
                }
                else if (SideOfTriangle3 == max)
                {
                    if (SideOfTriangle3 * SideOfTriangle3 == SideOfTriangle1 * SideOfTriangle1 + SideOfTriangle2 * SideOfTriangle2)
                    {
                        Console.WriteLine("Прямоугольный треугольник");
                    }
                }

                if (SideOfTriangle1 == SideOfTriangle2 && SideOfTriangle2 == SideOfTriangle3 && SideOfTriangle1 == SideOfTriangle3)
                {
                    Console.WriteLine("Равносторонний треугольник");
                }
                if ((SideOfTriangle1 == SideOfTriangle2 || SideOfTriangle2 == SideOfTriangle3) && !(SideOfTriangle1 == SideOfTriangle3))
                {
                    Console.WriteLine("Равнобедренный треугольник");
                }
            }

        }
    }
}