using System;
using System.Linq;

namespace TaskAndrew
{
    public enum Operations
    {
        Perimetr = 1,
        Area,
        Back
    }

    public enum Figures
    {
        Square = 1,
        Rectangle,
        Triangle,
        Circle,
        Trapeze,
        Exit
    }

    class Program
    {
        static void Main(string[] args)
        {
            BuildMenuFigure();
            int userFigureChoise = GetUserInput(new[] { 1, 2, 3, 4, 5, 6 });
            BuildMenuOperation();
            HandleUserChoise(userFigureChoise);
            Back();
        }

        static void BuildMenuFigure()
        {
            Console.WriteLine("Choice of figure:");
            Console.WriteLine("1 - square");
            Console.WriteLine("2 - rectangle");
            Console.WriteLine("3 - triangle");
            Console.WriteLine("4 - circle");
            Console.WriteLine("5 - trapeze");
            Console.WriteLine("6 - exit");
        }

        static int GetUserInput(int[] possibleValues)
        {
            int.TryParse(Console.ReadLine(), out int userInput);

            while (!possibleValues.Contains(userInput))
            {
                Console.WriteLine("Incorrect Input. Please type 1, 2, 3, 4, 5, 6");
                int.TryParse(Console.ReadLine(), out userInput);
            }

            if (userInput == 6)
            {
                System.Environment.Exit(0);
            }
            return userInput;
        }

        static void BuildMenuOperation()
        {
            Console.WriteLine("Choice of formula:");
            Console.WriteLine("1 - perimeter");
            Console.WriteLine("2 - area");
            Console.WriteLine("3 - back");
        }

        static void Back()
        {
            BuildMenuFigure();
            int userFigureChoise = GetUserInput(new[] { 1, 2, 3, 4, 5, 6 });
            BuildMenuOperation();
            HandleUserChoise(userFigureChoise);
        }

        static int GetValidValue(string parametr)
        {
            Console.WriteLine(parametr);
            string stringSide = Console.ReadLine();
            int side;
            bool parseResult = Int32.TryParse(stringSide, out side);

            while (!parseResult)
            {
                Console.WriteLine("Incorrect Input. Please type only numbers. Letters and signs are prohibited!");
                parseResult = int.TryParse(Console.ReadLine(), out side);
                if (side<= 0)
                {
                    parseResult = false;
                }
            }
            return side;
        }

        static void HandleUserChoiseSquare(int choiseOperation)
        {
            if (choiseOperation == 3)
            {
                Back();
                return;
            }
            int side = GetValidValue("Enter the side of the square");
            switch ((Operations)choiseOperation)
            {
                case Operations.Perimetr:
                    Console.WriteLine($"Perimetr square: {4 * side}");
                    break;

                case Operations.Area:
                    Console.WriteLine($"Area square: {side * side}");
                    break;

                default:
                    Console.WriteLine("Neverno");
                    break;
            }
        }

        static void HandleUserChoiseRestangle(int choiseOperation)
        {
            if (choiseOperation == 3)
            {
                Back();
                return;
            }
            int side = GetValidValue("Enter the side of the rectangle");
            int side2 = GetValidValue("Enter the 2 side of the rectangle");
            switch ((Operations)choiseOperation)
            {
                case Operations.Perimetr:
                    Console.WriteLine($"Perimetr rectangle: {2 * (side + side2)} ");
                    break;

                case Operations.Area:
                    Console.WriteLine($"Area rectangle: {side * side2}");
                    break;

                default:
                    Console.WriteLine("Neverno");
                    break;
            }
        }

        static void HandleUserChoiseTriangle(int choiseOperation)
        {
            if (choiseOperation == 3)
            {
                Back();
                return;
            }
            int side = GetValidValue("Enter the 1 katet of the triangle");
            int side2 = GetValidValue("Enter the 2 katet of the triangle");
            switch ((Operations)choiseOperation)
            {
                case Operations.Perimetr:
                    int side3 = GetValidValue("Enter the hipotenusa of the triangle");
                    Console.WriteLine($"Perimetr triangle: {side + side2 + side3} ");
                    break;

                case Operations.Area:
                    int hipotenusa = GetValidValue("Enter the hipotenusa of the triangle");
                    Console.WriteLine($"Area triangle: {(side * side2) / 2}");
                    break;

                default:
                    Console.WriteLine("Neverno");
                    break;
            }
        }

        static void HandleUserChoiseCircle(int choiseOperation)
        {
            if (choiseOperation == 3)
            {
                Back();
                return;
            }
            int radius = GetValidValue("Enter the radius circle: ");
            switch ((Operations)choiseOperation)
            {
                case Operations.Perimetr:
                    Console.WriteLine($"Perimetr circle:{2 * Math.PI * radius} ");
                    break;

                case Operations.Area:
                    Console.WriteLine($"Area circle:{Math.PI * (radius * radius)} ");
                    break;

                default:
                    Console.WriteLine("Neverno");
                    break;
            }
        }

        static void HandleUserChoiseTrapeze(int choiseOperation)
        {
            if (choiseOperation == 3)
            {
                Back();
                return;
            }
            int side = GetValidValue("Enter the 1 side trapeze: ");
            int side2 = GetValidValue("Enter the 2 side trapeze: ");
            switch ((Operations)choiseOperation)
            {
                case Operations.Perimetr:
                    int side3 = GetValidValue("Enter the 3 side trapeze: ");
                    int side4 = GetValidValue("Enter the 4 side trapeze: ");
                    Console.WriteLine($"Perimetr trapeze: {side + side + side3 + side4} ");
                    break;

                case Operations.Area:
                    int high = GetValidValue("Enter the high trapeze: ");
                    Console.WriteLine($"Area trapeze: {(side + side2) * high} ");
                    break;

                default:
                    Console.WriteLine("Neverno");
                    break;
            }
        }

        static void HandleUserChoise(int choiceFigure)
        {
            int userOperationChoise = GetUserInput(new[] { 1, 2, 3 });
            switch ((Figures)choiceFigure)
            {
                case Figures.Square:
                    HandleUserChoiseSquare(userOperationChoise);

                    Back();
                    return;


                case Figures.Rectangle:
                    HandleUserChoiseRestangle(userOperationChoise);

                    Back();
                    return;


                case Figures.Triangle:
                    HandleUserChoiseTriangle(userOperationChoise);

                    Back();
                    return;

                case Figures.Circle:
                    HandleUserChoiseCircle(userOperationChoise);

                    Back();
                    return;

                case Figures.Trapeze:
                    HandleUserChoiseTrapeze(userOperationChoise);

                    Back();
                    return;

                default:
                    {
                        Console.WriteLine("MISTAKE! Try again, please!");
                        System.Environment.Exit(0);
                    }
                    break;
            }
        }
    }
}



















