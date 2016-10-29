using System;

namespace Casino
{
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Casino";
            Beginning();
        }

        public static void Beginning()
        {
            Console.WriteLine();
            Console.WriteLine("Choose action: ");
            Console.WriteLine("1. Blackjack");
            Console.WriteLine("2. Slot machine");
            Console.WriteLine("3. Check your money");
            Console.WriteLine("4. Check casino money");
            Console.WriteLine("5. Leave casino");

            ChooseGame(Console.ReadKey());
        }

        private static void ChooseGame(ConsoleKeyInfo i)
        {
            switch (i.Key)
            {
                case ConsoleKey.D1:
                    Blackjack.NewGame();
                    break;

                case ConsoleKey.D2:
                    SlotMachine.NewGame();
                    break;

                case ConsoleKey.D3:
                    Console.WriteLine();
                    Console.WriteLine(Player.GetMoney());
                    Beginning();
                    break;

                case ConsoleKey.D4:
                    Console.WriteLine();
                    Console.WriteLine(Vault.GetMoney());
                    Beginning();
                    break;

                case ConsoleKey.D5:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Bad input");
                    Beginning();
                    break;
            }
        }
    }
}