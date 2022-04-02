using System;

namespace Arrays.PrintMonths
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Months = { "January","February", "March", "April", "May"
                    ,"June", "July", "August", "September", "October", "November", "December" };

            int i = Months.Length - 1;
            while (i >= 0)
            {
                Console.WriteLine(Months[i]);
                i--;
            }


            //string[] Months = { "January","February", "March", "April", "May"
            //        ,"June", "July", "August", "September", "October", "November", "December" };

            //int i = 0;
            //while (i <= Months.Length - 1)
            //{
            //    Console.WriteLine(Months[i]);
            //    i++;
            //}









        }
    }
}
