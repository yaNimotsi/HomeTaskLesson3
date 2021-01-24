using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter range array");
            int range = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[range, range];

            var rand = new Random();

            for (int i = 0; i < range; i++)
            {
                for (int j = 0; j < range; j++)
                {
                    arr[i, j] = rand.Next(100);
                }
                Console.WriteLine(arr[i, i]);
            }


        }
    }
}
