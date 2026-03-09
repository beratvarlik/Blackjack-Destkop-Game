using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Game
{
    internal class PlayerControll
    {
        public int APieces { get; set; }

        List<(string Suit, string Rank)> playerCards = new List<(string,string)>();
        public int PlayerValue { get; set; }

        List<(string Suit, string Rank)> dealerCards = new List<(string, string)>();
        public int DealerValue { get; set; }    // Dealer'ın eli kaç?

        Desk tourDesk = new Desk();

        public void StartTour()
        {
            StartingDealCards(tourDesk, playerCards);
            StartingDealCards(tourDesk, dealerCards);

            PlayerValue = CalculateStartingValue(playerCards);
            DealerValue = CalculateStartingValue(dealerCards);
        }
        public List<(string Suit, string Rank)> getPlayerCards()
        {
            return playerCards;
        }
        public int getPlayerValue()
        {
            return PlayerValue;
        }
        public List<(string Suit, string Rank)> getDealerCards()
        {
            return dealerCards;
        }
        public int getDealerValue()
        {
            return DealerValue;
        }


        public void StartingDealCards(Desk tourDesk, List<(string Suit, string Rank)> givenCards)
        {
            Random rnd = new Random();
            int random = 0;
            for (int i = 0; i<2; i++)
            {
                random = rnd.Next(52);
                givenCards.Add((tourDesk.Cards[random].Suit, tourDesk.Cards[random].Rank));

            }
            
        }
        public int CalculateStartingValue(List<(string Suit, string Rank)> givenCards)
        {
            int startingValue = 0;
            foreach (var item in givenCards)
            {
                switch (item.Rank) 
                {
                    case "A":
                        startingValue += 11;
                        break;
                        
                    case "1":
                        startingValue++;
                        break;

                    case "2":
                        startingValue += 2;
                        break;

                    case "3":
                        startingValue += 3;
                        break;

                    case "4":
                        startingValue += 4;
                        break;

                    case "5":
                        startingValue += 5;
                        break;

                    case "6":
                        startingValue += 6;
                        break;

                    case "7":
                        startingValue += 7;
                        break;

                    case "8":
                        startingValue += 8;
                        break;

                    case "9":
                        startingValue += 9;
                        break;

                    case "10":
                        startingValue += 10;
                        break;

                    case "J":
                        startingValue += 10;
                        break;

                    case "K":
                        startingValue += 10;
                        break;

                    case "Q":
                        startingValue += 10;
                        break;
                        
                    default:
                        return 0;
                }
            }
            return startingValue;
            
        }

        public (string Suit, string Rank) RequestOneCard()
        {
            Random rnd = new Random();
            int random = rnd.Next(52);

            return (
                tourDesk.Cards[random].Suit,
                tourDesk.Cards[random].Rank
            );
        }

        public int CalculateCardValue((string Suit, string Rank) valueCards)
        {
            int temp = 0;
            switch (valueCards.Rank)
            {
                case "A":
                    temp += 11;
                    break;

                case "1":
                    temp++;
                    break;

                case "2":
                    temp += 2;
                    break;

                case "3":
                    temp += 3;
                    break;

                case "4":
                    temp += 4;
                    break;

                case "5":
                    temp += 5;
                    break;

                case "6":
                    temp += 6;
                    break;

                case "7":
                    temp += 7;
                    break;

                case "8":
                    temp += 8;
                    break;

                case "9":
                    temp += 9;
                    break;

                case "10":
                    temp += 10;
                    break;

                case "J":
                    temp += 10;
                    break;

                case "K":
                    temp += 10;
                    break;

                case "Q":
                    temp += 10;
                    break;

                default:
                    return 0;
            }
            return temp;

        }
    }

    
}
