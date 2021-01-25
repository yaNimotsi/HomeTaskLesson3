using System;

namespace Task4
{
    class Program
    {
        //Так как методы мы еще не проходили пишу все сплошняком)
        static void Main(string[] args)
        {
            char[,] gameList = {{'X', 'O', 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'X' },
                                {'O', 'O', 'O', 'X', 'X', 'O', 'O', 'O', 'O', 'O' },
                                {'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O' },
                                {'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O' },
                                {'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'X' },
                                {'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'X' },
                                {'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'X' },
                                {'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'X' },
                                {'O', 'X', 'X', 'X', 'O', 'X', 'X', 'X', 'O', 'O' },
                                {'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'X' },};

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(gameList[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        
    }
}
