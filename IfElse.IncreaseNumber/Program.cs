using System;

namespace IfElse.IncreaseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numberUser;

            Console.Write("Введите число      :");
            string stringNumber = Console.ReadLine();
            numberUser = Convert.ToDecimal(stringNumber);


            decimal increaseTheNumber;
            {
                const decimal MIN_NUMBER_FOR_INCREASE = 3;
                bool numberAvailable = numberUser > MIN_NUMBER_FOR_INCREASE;

                if (numberAvailable)
                {
                    const decimal INCREASE = 10;
                    increaseTheNumber = numberUser + INCREASE;
                }
                else
                {
                    increaseTheNumber = numberUser * 10;
                }
            }

            Console.WriteLine($" {increaseTheNumber} ");
        }
    }
}
