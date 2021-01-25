using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Сечас произойджет создание пробной версии телефонного справочника \n" +
                $"Для использования полного функционала отправьте на номер ... )");
            int cRow = 5;
            int cColumn = 2;
            string[,] tellBook = new string[cRow, cColumn];
            for (int i = 0; i < cRow; i++)
            {
                Console.WriteLine("Введите ФИО для записи");
                tellBook[i, 0] = Console.ReadLine();
                Console.WriteLine("Телефон или emeil пользователя");
                tellBook[i, 1] = Console.ReadLine();
                Console.WriteLine();
            }

            for (int i = 0; i < cRow; i++)
            {
                Console.WriteLine($"ФИО пользователя {i+1}: {tellBook[i,0]} \n" +
                    $"Телефон/email: {tellBook[i, 1]}");
            }
            Console.ReadLine();
        }
    }
}
