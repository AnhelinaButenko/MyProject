using System;

namespace IfElse.CalculateDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Запросить у кассира, ввести количество плитки в метрах квадрат,
            //   цену плитки за квадратный метр.

            decimal tileQuontiti, tilePrice;
            {
                Console.Write("Количество плитки      :");
                string stringQuontiti = Console.ReadLine();
                tileQuontiti = Convert.ToDecimal(stringQuontiti);

                Console.Write("Цена за 1 м.кв. плитки:    ");
                string stringPrice = Console.ReadLine();
                tilePrice = Convert.ToDecimal(stringPrice);
            }

            //2. Посчитать общую стоимость плитки.
            decimal tileCost = tileQuontiti * tilePrice;

            //3. Посчитать сумму скидки в 10%
            decimal discount;
            {
                const decimal MIN_TILE_FOR_DISCONT = 100;
                bool discountAvailable = tileQuontiti >= MIN_TILE_FOR_DISCONT;

                if (discountAvailable)
                {
                    const decimal DISCOUNT_PERSENTAGE = 10;
                    discount = tileCost / 100 * DISCOUNT_PERSENTAGE;
                }
                else
                {
                    discount = 0;
                }
            }

            //4. Посчитать сумму к оплате с учетом скидки.
            decimal paymentAmount = tileCost - discount;

            //5. Вывести на экран: общую стоимость, сумму скидки и сумму к оплате.
            Console.WriteLine($"Общая стоимость плитки: {tileCost} ");
            Console.WriteLine($"Скидка                : {discount}");
            Console.WriteLine($"Сумма к оплате        : {paymentAmount}");
        }
    }
}
