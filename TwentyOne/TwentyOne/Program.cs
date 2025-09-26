using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck = Shuffle(deck);



            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
        public static Deck Shuffle(Deck deck)
        {
            Random random = new Random();
            for (int i = 0; i < deck.Cards.Count; i++)
            {
                int randomIndex = random.Next(0, deck.Cards.Count);
                Card temp = deck.Cards[i];
                deck.Cards[i] = deck.Cards[randomIndex];
                deck.Cards[randomIndex] = temp;
            }
            return deck;
        }
    }
}
