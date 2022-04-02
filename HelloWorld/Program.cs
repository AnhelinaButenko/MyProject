using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            string firstname = Console.ReadLine();
            Console.WriteLine("Введите отчество");
            string patronymic = Console.ReadLine();

            string HelloStr = "Hello " + name + " " + firstname + " " + patronymic;
            Console.WriteLine(HelloStr);
        }
    }
}
