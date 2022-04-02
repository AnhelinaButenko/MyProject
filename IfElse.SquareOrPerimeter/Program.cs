using System;

namespace IfElse.SquareOrPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal SideOfRectangle1, SideOfRectangle2;
            // На 10 стоке создаем переменные типа decimal SideOfRectangle1, SideOfRectangle2
            Console.WriteLine("Введите 1 сторону прямоугольника:");
            // На 11 стр на объкте консоль вызываем команду WriteLine, которая принимает в качестве параметрас строку
            // "Введите 1 сторону прямоугольника:"
            string stringSide1 = Console.ReadLine();
            // На 13 строке создаем переменную типа string c именем stringSide1 и вызываем на объкте консоль команду ReadLine()
            // которая может считать информацию с консоли в виде строки
            SideOfRectangle1 = Convert.ToDecimal(stringSide1);
            // На 17 строке создаем пересенную типа decimal SideOfRectangle1 и преобразуем строку stringSide1 к типу decimal
            Console.WriteLine("Введите 2 сторону прямоугольника:");
            // На 19 стр на объкте консоль вызываем команду WriteLine, которая принимает в качестве параметра строку
            // "Введите 2 сторону прямоугольника:"
            string stringSide2 = Console.ReadLine();
            // На 22 строке создаем переменную типа string c именем stringSide2 и вызываем на объкте консоль команду ReadLine()
            // которая может считать информацию с консоли в виде строки
            SideOfRectangle2 = Convert.ToDecimal(stringSide2);
            // На 25 строке создаем переменную типа decimal SideOfRectangle2 и преобразуем строку stringSide2 к типу decimal
            if (SideOfRectangle2 == SideOfRectangle1)
            {

                Console.WriteLine("Квадрат");
            }
            // ЕСЛИ SideOfRectangle2 равна SideOfRectangle1, ТО на объекте консоль вызываем команду WriteLine, которая принимает
            // в качестве параметра строку"Квадрат"
            Console.WriteLine("Введите Площадь или Периметр");
            // На 34 строке на объекте консоль вызываем команду WriteLine, которая принимает в качестве параметра строку"Введите Площадь или Периметр"

            string stringSquareOrPerimetr = Console.ReadLine();
            // На 37 строке создаем переменную типа string c именем stringSquareOrPerimetr и вызываем на объкте консоль команду ReadLine()
            // которая может считать информацию с консоли в виде строки

            decimal PerimeterRectangle, SquareRectangle;
            // На 41 стоке создаем переменные типа decimal PerimeterRectangle, SquareRectangle
            if (stringSquareOrPerimetr == "Площадь")
            {
                Console.WriteLine(SideOfRectangle1 * SideOfRectangle2);

            }
            // На 43 строке условие ЕСЛИ stringSquareOrPerimetr будет равно введенному пользователем строке "Площадь", ТО на объекте консоль вызываем
            // команду WriteLine, которая принимает в качестве параметра выражение в котором SideOfRectangle1 * SideOfRectangle2
            else if (stringSquareOrPerimetr == "Периметр")
            {
                Console.WriteLine(2 * (SideOfRectangle1 + SideOfRectangle2));

            }
            // НА 51 строке условие ИНАЧЕ ЕСЛИ stringSquareOrPerimetr будет равно введенному пользователем строке "Периметр", ТО на объекте консоль вызываем
            // команду WriteLine, которая принимает в качестве параметра выражение в котором (2 * (SideOfRectangle1 + SideOfRectangle2)
            else
            {
                Console.WriteLine("Неверная команда");
            }
            // На 58 строке условие ИНАЧЕ stringSquareOrPerimetr будет не подходящим указанным условием (неправильный ввод), ТО на объекте консоль вызываем
            // команду WriteLine, которая принимает в качестве параметра строку"Неверная команда"
        }
    }
}
