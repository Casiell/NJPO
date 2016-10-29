using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    internal class SlotMachine
    {
        private static int bet;
        private static List<int> column1;
        private static List<int> column2;
        private static List<int> column3;

        public static void NewGame()
        {
            Bet();
            Console.WriteLine("Press any key to start game...");
            Console.ReadKey();
            PlayTheGame();
        }

        private static void Bet()
        {
            Console.WriteLine();
            Console.WriteLine("How much would you like to bet?");
            string input = Console.ReadLine();
            while (!Int32.TryParse(input, out bet) || bet < 1 || bet > Player.GetMoney())
            {
                Console.WriteLine();
                Console.WriteLine("Illegal amount, bet again!");
                input = Console.ReadLine();
            }
        }

        private static void PlayTheGame()
        {
            column1 = new List<int>();
            column2 = new List<int>();
            column3 = new List<int>();

            Random rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                column1.Add(rand.Next(1, 10));
                column2.Add(rand.Next(1, 10));
                column3.Add(rand.Next(1, 10));
                while (column2[i] == column1[i])
                    column2[i] = rand.Next(1, 10);
                while (column3[i] == column1[i] || column3[i] == column2[i])
                    column3[i] = rand.Next(1, 10);
            }
            Console.WriteLine();
            Console.WriteLine("{0} {1} {2}\n{3} {4} {5}\n{6} {7} {8}", column1[0], column2[0], column3[0], column1[1], column2[1], column3[1], column1[2], column2[2], column3[2]);
            if (!CheckHorizontalLines() && !CheckDiagonalLines())
            {
                EndGame(GameResult.lose);
            }
        }

        private static bool CheckHorizontalLines()
        {
            for (int i = 0; i < 3; i++)
            {
                int value = column1[i];
                if (column2[i] == value && column3[i] == value)
                {
                    EndGame(GameResult.win);
                    return true;
                }
            }
            return false;
        }

        private static bool CheckDiagonalLines()
        {
            if (column1[0] == column2[1] && column1[0] == column3[2])
            {
                EndGame(GameResult.win);
                return true;
            }
            if (column1[2] == column2[1] && column1[2] == column3[0])
            {
                EndGame(GameResult.win);
                return true;
            }
            return false;
        }

        private static void EndGame(GameResult result)
        {
            switch (result)
            {
                case GameResult.win:
                    Console.WriteLine("You win!");
                    Player.AddMoney(bet);
                    break;

                case GameResult.lose:
                    Console.WriteLine("You lose!");
                    Player.SubstractMoney(bet);
                    break;

                case GameResult.tie:
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("What to do next?");
            Console.WriteLine("1. Play again");
            Console.WriteLine("2. Change game");
            ConsoleKey key = Console.ReadKey().Key;
            while (key != ConsoleKey.D1 && key != ConsoleKey.D2)
            {
                Console.WriteLine();
                Console.WriteLine("Illegal action");
                key = Console.ReadKey().Key;
            }
            switch (key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    NewGame();
                    break;

                case ConsoleKey.D2:
                    Console.Clear();
                    Program.Beginning();
                    break;
            }
        }
    }
}