using System;

namespace Metod
{
    class Program
    {
        static double Perimetr(int katet1, int katet2)
        {
            double hipotenusa = Math.Sqrt(Math.Pow(katet1, 2) + Math.Pow(katet2, 2));
            return (katet1 + katet2 + hipotenusa);
        }
        
        static void Main(string[] args)
        {
            int katet1 = 3;
            int katet2 = 4;

            Console.WriteLine(Perimetr(katet1, katet2));


            int katet3 = 7;
            int katet4 = 9;

            Console.WriteLine(Perimetr(katet3, katet4));





            //static int Sum( int numberOfEmploees, int cost1Day, int numberOfDays)
            //{
            //    return numberOfEmploees* numberOfDays* cost1Day;
            //}

            //static void Main(string[] args)
            //{
            //    Console.WriteLine("Количество сотрудников: ");
            //    string Emploees = Console.ReadLine();
            //    int numberOfEmploees = Convert.ToInt32(Emploees);

            //    Console.WriteLine("Цена за 1 день: ");
            //    string Cost = Console.ReadLine();
            //    int cost1Day = Convert.ToInt32(Cost);

            //    Console.WriteLine("Количество рабочих дней: ");
            //    string Days = Console.ReadLine();
            //    int numberOfDays = Convert.ToInt32(Days);

            //    // или так или ниже int Result = Sum(numberOfEmploees, cost1Day, numberOfDays);

            //    Console.WriteLine(Sum(numberOfEmploees, cost1Day, numberOfDays));
        }
    }

}
