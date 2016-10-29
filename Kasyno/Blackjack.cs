using System;
using System.Collections.Generic;

namespace Casino
{
    internal class Blackjack
    {
        private static Card card = new Card();
        private static int bet;
        private static Deck deck;
        private static List<Card> playerHand;
        private static List<Card> dealerHand;

        public static void NewGame()
        {
            deck = new Deck();
            Bet();
            DealHand();
            PlayTheGame();
        }

        /// <summary>
        /// Bets some amount of money.
        /// </summary>
        /// <param name="playerMoney"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Deal new hands and check for blackjack in either of them.
        /// </summary>
        private static void DealHand()
        {
            playerHand = new List<Card>();
            playerHand.Add(deck.DrawACard());
            playerHand.Add(deck.DrawACard());

            foreach (Card card in playerHand)
            {
                if (card.Face == Face.Ace)
                {
                    card.Value += 10;
                    break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Player hand:");
            Console.WriteLine("Card 1: {0} of {1}", playerHand[0].Face, playerHand[0].Suit);
            Console.WriteLine("Card 2: {0} of {1}", playerHand[1].Face, playerHand[1].Suit);
            Console.WriteLine("Total value: {0}", CalculateHandValue(playerHand));

            dealerHand = new List<Card>();
            dealerHand.Add(deck.DrawACard());
            dealerHand.Add(deck.DrawACard());

            foreach (Card card in dealerHand)
            {
                if (card.Face == Face.Ace)
                {
                    card.Value += 10;
                    break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Dealer hand:");
            Console.WriteLine("Card 1: {0} of {1}", dealerHand[0].Face, dealerHand[0].Suit);
            Console.WriteLine("Card 2: {0} of {1}", dealerHand[1].Face, dealerHand[1].Suit);
            Console.WriteLine("Total value: {0}", CalculateHandValue(dealerHand));

            foreach (Card card in dealerHand)
            {
                if (card.Face == Face.Ace)
                {
                    card.Value += 10;
                    break;
                }
            }

            if (CheckForBlackjack(playerHand) && !CheckForBlackjack(dealerHand))
            {
                Console.WriteLine();
                Console.WriteLine("Player wins!");
                EndGame(GameResult.win);
            }
            else if (!CheckForBlackjack(playerHand) && CheckForBlackjack(dealerHand))
            {
                Console.WriteLine();
                Console.WriteLine("Dealer wins!");
                EndGame(GameResult.lose);
            }
            else if (CheckForBlackjack(playerHand) && CheckForBlackjack(dealerHand))
            {
                EndGame(GameResult.tie);
            }
        }

        private static void PlayTheGame()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Choose action: [S]tand or [H]it");
                ConsoleKey key = Console.ReadKey().Key;
                while (key != ConsoleKey.S && key != ConsoleKey.H)
                {
                    Console.WriteLine();
                    Console.WriteLine("Illegal action! Please choose again: [S]tand or [H]it");
                    key = Console.ReadKey().Key;
                }

                switch (key)
                {
                    #region Draw new card

                    case ConsoleKey.H:
                        playerHand.Add(deck.DrawACard());
                        Console.WriteLine();
                        Console.WriteLine("Drew {0} of {1}", playerHand[playerHand.Count - 1].Face, playerHand[playerHand.Count - 1].Suit);
                        Console.WriteLine("Total hand value: {0}", CalculateHandValue(playerHand));
                        if (CheckForBlackjack(playerHand))
                        {
                            Console.WriteLine();
                            Console.WriteLine("You have blackjack!");
                            EndGame(GameResult.win);
                        }
                        else if (CalculateHandValue(playerHand) >= 21)
                        {
                            Console.WriteLine();
                            Console.WriteLine("You bust!");
                            EndGame(GameResult.lose);
                        }
                        break;

                    #endregion Draw new card

                    #region Stand

                    case ConsoleKey.S:
                        while (CalculateHandValue(dealerHand) < 17)
                        {
                            System.Threading.Thread.Sleep(2000);
                            dealerHand.Add(deck.DrawACard());
                            Console.WriteLine();
                            Console.WriteLine("Dealer drew {0} of {1}", dealerHand[dealerHand.Count - 1].Face, dealerHand[dealerHand.Count - 1].Suit);
                            Console.WriteLine("Dealer hand value: {0}", CalculateHandValue(dealerHand));
                        }
                        if (CheckForBlackjack(dealerHand))
                        {
                            Console.WriteLine();
                            Console.WriteLine("Dealer has blackjack!");
                            EndGame(GameResult.lose);
                        }
                        else if (CalculateHandValue(dealerHand) > 21)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Dealer bust!");
                            EndGame(GameResult.win);
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("You: {0}, Dealer: {1}", CalculateHandValue(playerHand), CalculateHandValue(dealerHand));
                            if (CalculateHandValue(dealerHand) > CalculateHandValue(playerHand))
                            {
                                EndGame(GameResult.lose);
                            }
                            else if (CalculateHandValue(dealerHand) < CalculateHandValue(playerHand))
                            {
                                EndGame(GameResult.win);
                            }
                            else if (CalculateHandValue(dealerHand) == CalculateHandValue(playerHand))
                            {
                                EndGame(GameResult.tie);
                            }
                        }
                        break;

                        #endregion Stand
                }
            }
        }

        /// <summary>
        /// End game with some result
        /// </summary>
        /// <param name="result"></param>
        private static void EndGame(GameResult result)
        {
            switch (result)
            {
                case GameResult.win:
                    Console.WriteLine("You win!");
                    if (CheckForBlackjack(playerHand))
                    {
                        Vault.SubtractMoney(bet * 1.5f);
                        Player.AddMoney(bet * 1.5f);
                    }
                    else
                    {
                        Vault.SubtractMoney(bet);
                        Player.AddMoney(bet);
                    }
                    break;

                case GameResult.lose:
                    Console.WriteLine("You lose!");
                    Vault.AddMoney(bet);
                    Player.SubstractMoney(bet);
                    break;

                case GameResult.tie:
                    Console.WriteLine("Tie.");
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

        /// <summary>
        /// Checks if hand has blackjack.
        /// </summary>
        /// <param name="hand"></param>
        /// <returns></returns>
        private static bool CheckForBlackjack(List<Card> hand)
        {
            return CalculateHandValue(hand) == 21;
        }

        private static int CalculateHandValue(List<Card> hand)
        {
            int value = 0;

            foreach (Card card in hand)
            {
                value += card.Value;
            }
            return value;
        }
    }

    internal enum GameResult
    {
        win,
        lose,
        tie
    }

    internal enum Suit
    {
        Diamonds,
        Hearts,
        Spades,
        Clubs
    }

    internal enum Face
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    internal class Card
    {
        public Suit Suit { get; set; }
        public Face Face { get; set; }
        public int Value { get; set; }
    }

    internal class Deck
    {
        private List<Card> cards;

        public Deck()
        {
            this.Initialize();
        }

        private void Initialize()
        {
            cards = new List<Card>();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    cards.Add(new Card() { Suit = (Suit)i, Face = (Face)j });

                    if (j <= 8)
                        cards[cards.Count - 1].Value = j + 1;
                    else
                        cards[cards.Count - 1].Value = 10;
                }
            }
            this.Shuffle();
        }

        /// <summary>
        /// Shuffles decks
        /// </summary>
        public void Shuffle()
        {
            Random rand = new Random();
            int i = cards.Count;
            while (i > 1)
            {
                i--;
                int j = rand.Next(i + 1);
                Card card = cards[j];
                cards[j] = cards[i];
                cards[i] = card;
            }
        }

        public Card DrawACard()
        {
            if (cards.Count <= 0)
            {
                this.Initialize();
            }
            Card drawnCard = cards[0];
            cards.RemoveAt(0);
            return drawnCard;
        }
    }
}