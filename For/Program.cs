using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int index = 0, Number = 100; index <= Number; index++)
            {
                Console.WriteLine(index);
            }

         
            for (int index = 1001, Number1 = 2500; index <+ Number1; index += 3)
            {
                Console.WriteLine(index);
            }

            for (int index = 100, Number2 = 0; index >= Number2; index -= 4)
            {
                Console.WriteLine(index);
            }

            for (double index = 1.0, Number3 = 5.0; index <= Number3; index += 0.2)
            {
                Console.WriteLine(index);
            }
        }


    }
}
