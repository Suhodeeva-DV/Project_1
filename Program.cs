using System;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите Ваше имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Привет, " + name + "!");
            Console.Read();
            Console.Clear();
        }
    }
}
