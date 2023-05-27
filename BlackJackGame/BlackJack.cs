using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BlackJackGame
{
    public partial class BlackJack : Form
    {
        private BlackJackDeck _gameDeck;
        private int dealerCardCount=0;
        List<PictureBox> dealerCards;
        List<PictureBox> playerCards1;
        List<PictureBox> playerCards2;
        private bool leftFlag = false,rightFlag= false;
        public BlackJack()
        {
            InitializeComponent();
            InitVariables();
        }

        private void InitVariables()
        {
            _gameDeck = new BlackJackDeck();
            dealerCards = new List<PictureBox>();
            playerCards1 = new List<PictureBox>();
            playerCards2 = new List<PictureBox>();
        }

        private void DealCardsButton_Click(object sender, EventArgs e)
        {
            (string cardKey, Image cardImage)=  _gameDeck.DealCard();
            dealerCards.Add(_gameDeck.DisplayDealerCard(cardKey,cardImage, dealerPanel, dealerCardCount++));
            (cardKey, cardImage) = _gameDeck.DealCard();
            playerCards1.Add(_gameDeck.DisplayPlayerCard(cardKey, cardImage, playerFlowPanel1));
            (cardKey, cardImage) = _gameDeck.DealCard();
            dealerCards.Add(_gameDeck.DisplayDealerCard(cardKey, cardImage, dealerPanel, dealerCardCount++));
            (cardKey, cardImage) = _gameDeck.DealCard();
            playerCards1.Add(_gameDeck.DisplayPlayerCard(cardKey, cardImage, playerFlowPanel2));
            DealCardsButton.Visible = false;
            int score = CalculatePlayerScore(playerCards1);
            if(score == 21)
            {
                playerWinsLabel.Visible = true;
                playerWinsLabel.Text = "Blackjack";
            }
            else
            {
                score = CalculatePlayerScore(dealerCards);
                if(score == 21)
                {
                    dealerWinsLabel.Visible = true;
                    dealerWinsLabel.Text = "Push";
                }
            }
        }
        private int CalculatePlayerScore(List<PictureBox> cards)
        {
            int score = 0;
            int aceCount = 0;
            foreach (PictureBox card in cards)
            {
                int value = int.Parse(card.Name);
                if(value<=11)
                {
                    if (value == 11)
                        aceCount++;
                    score += value;
                }
                else 
                {
                    score += 10;
                }
            }
            while(score >21 &&aceCount > 0)
            {
                score -= 10;
                aceCount--;
            }
            return score;
        }
        private void hitButton_Click(object sender, EventArgs e)
        {
            splitButton.Enabled = false;
            (string cardKey, Image cardImage) = _gameDeck.DealCard();
            playerCards1.Add(_gameDeck.DisplayDealerCard(cardKey, cardImage, dealerPanel, dealerCardCount++));
            int score = CalculatePlayerScore(playerCards1);
            if (score >= 21)
            {
                playerWinsLabel.Visible = true;   
                DealCardsButton.Visible = true;
                playerWinsLabel.Text = "Player Wins";
            }
            else if (score > 21)
            {
                playerWinsLabel.Visible = true;
                playerWinsLabel.Text = "Player Busts";
                DealCardsButton.Visible = true;
            }
            else
            {

            }

        }

        private void standButton_Click(object sender, EventArgs e)
        {
            
        }

        private void splitButton_Click(object sender, EventArgs e)
        {

        }

        private void hitLeftSideButton_Click(object sender, EventArgs e)
        {

        }

        private void standLeftSideButton_Click(object sender, EventArgs e)
        {

        }

        private void hitRightSideButton_Click(object sender, EventArgs e)
        {

        }

        private void standRightSideButton_Click(object sender, EventArgs e)
        {

        }
    }
}
