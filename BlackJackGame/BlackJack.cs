using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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
        private int playerScore1, playerScore2;
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
            playerCards2.Add(_gameDeck.DisplayPlayerCard(cardKey, cardImage, playerFlowPanel1));
            (cardKey, cardImage) = _gameDeck.DealCard();
            dealerCards.Add(_gameDeck.DisplayDealerCard(cardKey, cardImage, dealerPanel, dealerCardCount++));
            (cardKey, cardImage) = _gameDeck.DealCard();
            playerCards2.Add(_gameDeck.DisplayPlayerCard(cardKey, cardImage, playerFlowPanel2));
            DealCardsButton.Visible = false;
            hitButton.Visible = true;
            splitButton.Visible = true;
            standButton.Visible= true;
            int score = CalculatePlayerScore(playerCards2);
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
            playerCards2.Add(_gameDeck.DisplayPlayerCard(cardKey, cardImage, playerFlowPanel2));
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
                playerScore2 = score;
                return;
            }
        }
        private void HandleDealerHand(int score,int playerScore, Label label)
        {
            if (score < 17)
            {
                (string cardKey, Image cardImage) = _gameDeck.DealCard();
                dealerCards.Add(_gameDeck.DisplayDealerCard(cardKey, cardImage, dealerPanel, dealerCardCount++));
                score = CalculatePlayerScore(dealerCards);
                HandleDealerHand(score, playerScore, label);
            }
            else if (score > 21)
            {
                dealerWinsLabel.Visible = true;
                DealCardsButton.Visible = true;
                dealerWinsLabel.Text = "Dealer Busts";
            }
            else if (score == 21 || score > playerScore)
            {
                dealerWinsLabel.Visible = true;
                DealCardsButton.Visible = true;
                dealerWinsLabel.Text = "Dealer Wins";
            }
            else if(score == playerScore)
            {
                DealCardsButton.Visible = true;
                label.Visible = true;
                label.Text = "Draw";
            }
        }
        private void standButton_Click(object sender, EventArgs e)
        {
            _gameDeck.RevealCard(dealerCards.ElementAt(1));
            int score = CalculatePlayerScore(dealerCards);
            HandleDealerHand(score,playerScore2, playerWinsLabel);
        }

        private void splitButton_Click(object sender, EventArgs e)
        {
            splitButton.Visible = false;
            hitButton.Visible = false;
            standButton.Visible=false;
            hitLeftSideButton.Visible = true;
            standLeftSideButton.Visible = true;
            standRightSideButton.Visible = true;
            hitRightSideButton.Visible = true;
            playerCards1.Add(playerCards2.ElementAt(1));
            playerCards2.RemoveAt(1);

        }

        private void hitLeftSideButton_Click(object sender, EventArgs e)
        {
            splitButton.Enabled = false;
            (string cardKey, Image cardImage) = _gameDeck.DealCard();
            playerCards1.Add(_gameDeck.DisplayPlayerCard(cardKey, cardImage, playerFlowPanel1));
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
                playerScore1 = score;
                return;
            }
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
