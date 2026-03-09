using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Game
{
    public class Desk
    {
        public List<Card> Cards = new List<Card>(52);
        

        public Desk()
        {
            CreateDesk();
            Shuffle();
        }

        public void CreateDesk()
        {
            string[] suits = { "♠", "♣", "♥", "♦" };
            string[] rank = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 0; j < rank.Length; j++)
                {
                    Card card = new Card();
                    card.Suit = suits[i];
                    card.Rank = rank[j];

                    Cards.Add(card);
                }
            }
        }
        public void Shuffle() //Fisher-Yates Shuffle Methodu
        {
            Random rnd = new Random();
            Card temp;
            for (int i = 51;i>=0;i--)
            {
                int rand = rnd.Next(52);

                temp = Cards[rand];
                Cards[rand] = Cards[i];
                Cards[i] = temp;
            }
        }
    }
}
