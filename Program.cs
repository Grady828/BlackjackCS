using System;
using System.Collections.Generic;

namespace Mikes_Code
{
    public class Card
    {
        public string Face;
        public int Value;
        public String Suit;


    }


    class Player
    {
        public string Name { get; set; }
        public List<Card> Hand = new List<Card>();



        public int HandValue()
        {
            var total = 0;
            foreach (var C in Hand)
            {
                total = total + C.Value;


            }
            return total;
        }
    }

    class Deck
    {
        private List<Card> cards;
        public void Shuffle()
        {
            Console.WriteLine("Shuffling");
            ResetTheDeck();
            ShuffleTheDeck();
        }

        private void ResetTheDeck()
        {
            Console.WriteLine("Resetting the deck");
            cards = new List<Card>();
            var suits = new List<string> { "Diamonds", "Hearts", "Spades", "Clubs" };
            var faces = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            foreach (var s in suits)
            {
                for (var i = 0; i < 13; i++)
                {
                    int value = 0;
                    if (i < 9)
                        value = i + 2;
                    else if (i > 7 && i < 12)
                        value = 10;
                    else if (i == 12)
                        value = 11;

                    var suit = s;
                    var face = faces[i];

                    var card = new Card();
                    card.Value = value;
                    card.Suit = suit;
                    card.Face = face;

                    cards.Add(card);
                }
            }
        }

        private void ShuffleTheDeck()
        {
            Console.WriteLine("Fischer Yates Shuffle");
            var numberOfCards = cards.Count;
            var randomNumberGenerator = new Random();

            for (var rightIndex = cards.Count - 1; rightIndex >= 1; rightIndex--)
            {
                var leftIndex = randomNumberGenerator.Next(rightIndex);
                var leftCard = cards[leftIndex];
                var rightCard = cards[rightIndex];
                cards[leftIndex] = rightCard;
                cards[rightIndex] = leftCard;
            }
        }

        public Card Draw()
        {
            if (cards == null)
                Shuffle();

            var drawnCard = cards[0];
            var isDrawn = cards.Remove(drawnCard);
            return drawnCard;
        }

        public void printToConsole()
        {
            if (cards == null)
                ResetTheDeck();
            foreach (var c in cards)
                Console.WriteLine(c);
        }
    }

    class Game
    {
        public Deck Deck { get; set; }
        public Player Dealer { get; set; }
        public Player Mike { get; set; }

        public void PlayGame()
        {
            Deck.Shuffle();
            Dealer.Hand = new List<Card>();
            Mike.Hand = new List<Card>();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello Playa, what is your name? ");
            var playerName = Console.ReadLine();


            var player1 = new Player();
            player1.Name = playerName;

            Console.WriteLine($"Hello, {player1.Name}");

            var shoe = new Deck();
            shoe.Shuffle();

            var Card1 = shoe.Draw();
            player1.Hand.Add(Card1);
            var Card2 = shoe.Draw();
            player1.Hand.Add(Card2);

            var initialTotal = player1.HandValue();
            Console.WriteLine($"{player1.Name} got {Card1.Face} of {Card1.Suit} and {Card2.Face} of {Card2.Suit}");
            Console.WriteLine($"With a total of {initialTotal}");


            if (initialTotal == 21)
            {
                Console.WriteLine("Congrats on 21");
                return;

            }

            Console.WriteLine("Would you like to hit or stand? ");
            var Userinput = Console.ReadLine();
            if (Userinput.ToLower() == "h")
            {
                var hitCard = shoe.Draw();
                player1.Hand.Add(hitCard);
                Console.WriteLine($"{player1.Name} Hit");

            }
            else if (Userinput.ToLower() == "s")
            {
                Console.WriteLine($"{player1.Name} Stands");
            }

            Console.WriteLine($"{player1.Name} got a {player1.HandValue()}");



















        }
    }
}