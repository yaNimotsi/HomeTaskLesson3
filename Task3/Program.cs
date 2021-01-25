using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку для выполнения разворота");
            char[] userStr = Console.ReadLine().ToCharArray();

            char[] inverCharArr = new char[userStr.Length];
            for(int i = userStr.Length-1, j = 0; i >= 0; i--, j++)
            {
                inverCharArr[j] = userStr[i];
            }

            Console.WriteLine($"Результат разворота строки ниже \n" +
                $"{new string(inverCharArr)}");
            Console.ReadLine();
        }
    }
}
