using System.Threading.Tasks;

namespace Blackjack_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public int APieces = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
            btn_startGame.Visible = false;
            btn_cardRequest.Visible = true;
            btn_tourEnd.Visible = true;
            btn_exit.Visible = true;

            PlayerControll player = new PlayerControll();
            player.StartTour();

            lbl_playerHand.Text = "";
            var playerCards = player.getPlayerCards();
            APieces = player.APieces;
            foreach (var card in playerCards)
            {
                if(card.Rank == "A")
                {
                    APieces++;
                }
                lbl_playerHand.Text += $"{card.Rank}{card.Suit} ";
            }
            lbl_dealerHand.Text = "";
            var dealerCards = player.getDealerCards();
            foreach (var card in dealerCards)
            {
                lbl_dealerCardsinVisible.Text += $"{card.Rank}{card.Suit}";
            }
            lbl_dealerHand.Text += $"{dealerCards[0].Rank}{dealerCards[0].Suit} ??";
            

            lbl_playerValue.Text = player.getPlayerValue().ToString();
            lbl_dealerValueinVisible.Text = player.getDealerValue().ToString();
            lbl_dealerValue.Text = $"{dealerCards[0].Rank}+?";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_cardRequest.Visible = false;
            btn_tourEnd.Visible = false;
            btn_exit.Visible = false;
            lbl_Result.Visible = false;
            btn_restartGame.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
        }

        private void btn_cardRequest_Click(object sender, EventArgs e)
        {
            PlayerControll player = new PlayerControll();

            (string Suit, string Rank) newCard = player.RequestOneCard();
            lbl_playerHand.Text += $"{newCard.Rank}{newCard.Suit} ";

            int newValue = Convert.ToInt32(lbl_playerValue.Text) + player.CalculateCardValue(newCard);
            if (newValue >= 21)
            {
                if (APieces > 0)
                {
                    newValue -= 10;
                      
                    APieces--;
                }
                else
                {
                    btn_tourEnd.PerformClick();
                }
            }
            lbl_playerValue.Text = newValue.ToString();
        }

        private void btn_tourEnd_Click(object sender, EventArgs e)
        {
            btn_tourEnd.Visible = false;
            btn_cardRequest.Visible = false;
            btn_cardRequest.Enabled = false;
            btn_tourEnd.Enabled = false;
            PlayerControll player = new PlayerControll();

            if (Convert.ToInt32(lbl_playerValue.Text) > 21)
            {
                btn_tourEnd.PerformClick();
            }
            else
            {
                while (Convert.ToInt32(lbl_dealerValueinVisible.Text) < 16)
                {
                    (string Suit, string Rank) newCard = player.RequestOneCard();
                    lbl_dealerCardsinVisible.Text += $"{newCard.Rank}{newCard.Suit}";
                    int newValue = Convert.ToInt32(lbl_dealerValueinVisible.Text) + player.CalculateCardValue(newCard);
                    if (newValue >= 21)
                    {
                        for (int i = 0; i < lbl_dealerCardsinVisible.Text.Length; i++)
                        {
                            if (lbl_dealerCardsinVisible.Text[i] == 'A')
                            {
                                newValue -= 10;
                            }
                        }
                    }
                    lbl_dealerValueinVisible.Text = newValue.ToString();
                    
                }
            }
                
            lbl_dealerHand.Text = lbl_dealerCardsinVisible.Text;
            lbl_dealerValue.Text = lbl_dealerValueinVisible.Text;

            TourWinner();
            
        }

        
        private async void TourWinner()
        {
            int playervalue = Convert.ToInt32(lbl_playerValue.Text);
            int dealervalue = Convert.ToInt32(lbl_dealerValueinVisible.Text);

            if (playervalue > dealervalue && playervalue <= 21)
            {
                lbl_Result.ForeColor = Color.DarkOliveGreen;
                lbl_Result.Visible = true;
                lbl_Result.Text = "KAZANDIN!";
                await Task.Delay(2000);

                lbl_Result.Visible = false;
            }
            else if (dealervalue > playervalue && dealervalue <= 21)
            {
                lbl_Result.ForeColor = Color.Red;
                lbl_Result.Visible = true;
                lbl_Result.Text = "KAYBETTÝN!";
                await Task.Delay(2000);
                lbl_Result.Visible = false;
            }
            else if (playervalue > dealervalue && playervalue > 21)
            {
                lbl_Result.ForeColor = Color.Red;
                lbl_Result.Visible = true;
                lbl_Result.Text = "KAYBETTÝN!";
                await Task.Delay(2000);

                lbl_Result.Visible = false;
            }
            else if (dealervalue > playervalue && dealervalue > 21)
            {
                lbl_Result.ForeColor = Color.DarkOliveGreen;
                lbl_Result.Visible = true;
                lbl_Result.Text = "KAZANDIN!";
                await Task.Delay(2000);

                lbl_Result.Visible = false;
            }
            else
            {
                lbl_Result.ForeColor = Color.Yellow;
                lbl_Result.Visible = true;
                lbl_Result.Text = "BERABERE!";
                await Task.Delay(2000);

                lbl_Result.Visible = false;
            }
            btn_restartGame.Visible = true;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_restartGame_Click(object sender, EventArgs e)
        {
            APieces = 0;
            btn_restartGame.Visible=false;
            btn_cardRequest.Visible = true;
            btn_cardRequest.Enabled = true;
            btn_tourEnd.Visible = true;
            btn_tourEnd.Enabled = true;

            PlayerControll player = new PlayerControll();
            player.StartTour();

            lbl_playerHand.Text = "";
            var playerCards = player.getPlayerCards();
            foreach (var card in playerCards)
            {
                if (card.Rank == "A")
                {
                    APieces++;
                }
                lbl_playerHand.Text += $"{card.Rank}{card.Suit} ";
            }
            lbl_dealerCardsinVisible.Text = "";
            var dealerCards = player.getDealerCards();
            foreach (var card in dealerCards)
            {
                lbl_dealerCardsinVisible.Text += $"{card.Rank}{card.Suit}";
            }
            lbl_dealerHand.Text = $"{dealerCards[0].Rank} {dealerCards[0].Suit}";
            lbl_dealerValue.Text = $"{dealerCards[0].Rank}+?";

            lbl_playerValue.Text = player.getPlayerValue().ToString();
            lbl_dealerValueinVisible.Text = player.getDealerValue().ToString();


        }
    }
}
