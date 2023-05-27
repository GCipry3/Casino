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
        private bool leftFlag = false, rightFlag = false, leftDone = false, rightDone = false, split = false, gameDone=false;
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
        private void GameDone()
        {
            dealerCards.Clear();
            playerCards1.Clear();
            playerCards2.Clear();
            rightSideLabel.Visible = false;
            playerWinsLabel.Visible = false;
            leftSideLabel.Visible=false;
            dealerWinsLabel.Visible=false;
            leftFlag = false; rightFlag = false; leftDone = false; rightDone = false;split = false; gameDone = false;
            hitRightSideButton.Visible = false;
            standRightSideButton.Visible = false;
            hitLeftSideButton.Visible = false;
            standLeftSideButton.Visible = false;
        }
        private void DealCardsButton_Click(object sender, EventArgs e)
        {   if(gameDone)
            {
                GameDone();
            }
            (string cardKey, Image cardImage)=  _gameDeck.DealCard();
            dealerCards.Add(_gameDeck.DisplayDealerCard(cardKey,cardImage, dealerPanel, dealerCardCount++));
            (cardKey, cardImage) = _gameDeck.DealCard();
            playerCards2.Add(_gameDeck.DisplayPlayerCard(cardKey, cardImage, playerFlowPanel1));
            (cardKey, cardImage) = _gameDeck.DealCard();
            dealerCards.Add(_gameDeck.DisplayDealerCard(cardKey, cardImage, dealerPanel, dealerCardCount++));
            (cardKey, cardImage) = _gameDeck.DealCard();
            playerCards2.Add(_gameDeck.DisplayPlayerCard(cardKey, cardImage, playerFlowPanel2));
            DealCardsButton.Visible = false;

            int score = CalculatePlayerScore(playerCards2);
            if(score == 21)
            {
                playerWinsLabel.Visible = true;
                playerWinsLabel.Text = "Blackjack";
                gameDone=true;
            }
            else
            {
                hitButton.Visible = true;
                splitButton.Visible = true;
                standButton.Visible = true;
                playerScore2 = score;
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
            int score = CalculatePlayerScore(playerCards2);
            if (score == 21)
            {
                playerWinsLabel.Visible = true;   
                DealCardsButton.Visible = true;
                playerWinsLabel.Text = "Player Wins";
                gameDone = true;
            }
            else if (score > 21)
            {
                playerWinsLabel.Visible = true;
                playerWinsLabel.Text = "Player Busts";
                DealCardsButton.Visible = true;
                gameDone = true;
            }
            else
            {
                playerScore2 = score;
            }
        }
        private void HandleDealerHand(int playerScore, Label label)
        {
            int score = CalculatePlayerScore(dealerCards);
            if (score < 17)
            {
                (string cardKey, Image cardImage) = _gameDeck.DealCard();
                dealerCards.Add(_gameDeck.DisplayDealerCard(cardKey, cardImage, dealerPanel, dealerCardCount++));
                HandleDealerHand(playerScore, label);
            }
            else
            {
                if (score > 21)
                {
                    dealerWinsLabel.Visible = true;
                    DealCardsButton.Visible = true;
                    dealerWinsLabel.Text = "Dealer Busts";
                }
                else if (score == 21 || score > playerScore)
                {
                    DealCardsButton.Visible = true;
                    if (!split)
                    {
                        dealerWinsLabel.Visible = true;
                        dealerWinsLabel.Text = "Dealer Wins";
                    }
                    else
                    {
                        label.Visible = true;
                        label.Text = "Dealer Wins";
                    }
                }
                else if (score == playerScore)
                {
                    DealCardsButton.Visible = true;
                    label.Visible = true;
                    label.Text = "Draw";
                }
                else
                {
                    label.Visible = true;
                    label.Text = "Player wins";
                }
                gameDone = true;
            }
        }
        private void standButton_Click(object sender, EventArgs e)
        {
            _gameDeck.RevealCard(dealerCards.ElementAt(1));
            int score = CalculatePlayerScore(dealerCards);
            if (score == 21)
            {
                dealerWinsLabel.Visible = true;
                dealerWinsLabel.Text = "Push";
                gameDone = true;
                DealCardsButton.Visible = true;
            }
            else
            {
                HandleDealerHand(playerScore2, playerWinsLabel);
            }
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
            split = true;
            playerCards1.Add(playerCards2.ElementAt(1));
            playerCards2.RemoveAt(1);
            (string cardKey, Image cardImage) = _gameDeck.DealCard();
            playerCards2.Add(_gameDeck.DisplayPlayerCard(cardKey, cardImage, playerFlowPanel2));
            (cardKey, cardImage) = _gameDeck.DealCard();
            playerCards1.Add(_gameDeck.DisplayPlayerCard(cardKey, cardImage, playerFlowPanel1));
            playerScore1 = CalculatePlayerScore(playerCards1);
            playerScore2 = CalculatePlayerScore(playerCards2);
        }

        private void hitLeftSideButton_Click(object sender, EventArgs e)
        {
            (string cardKey, Image cardImage) = _gameDeck.DealCard();
            playerCards1.Add(_gameDeck.DisplayPlayerCard(cardKey, cardImage, playerFlowPanel1));
            int score = CalculatePlayerScore(playerCards1);
            if (score == 21)
            {
                hitLeftSideButton.Enabled = false;
                standLeftSideButton.Enabled = false;
                leftSideLabel.Visible = true;
                leftSideLabel.Text = "Player Wins";
                leftDone = true;
                if (rightDone)
                {
                    DealCardsButton.Visible = true;
                    gameDone = true;
                }
            }
            else if (score > 21)
            {
                hitLeftSideButton.Enabled = false;
                standLeftSideButton.Enabled = false;
                leftSideLabel.Visible = true;
                leftSideLabel.Text = "Player Busts";
                DealCardsButton.Visible = true;
                leftDone = true;
                if (rightDone)
                {
                    DealCardsButton.Visible = true;
                    gameDone = true;
                }
            }
            else
            {
                playerScore1 = score;
            }
        }

        private void standLeftSideButton_Click(object sender, EventArgs e)
        {
            HandleSplitPlayer(rightDone, rightFlag, playerScore1, leftSideLabel, false);
        }

        private void hitRightSideButton_Click(object sender, EventArgs e)
        {
            (string cardKey, Image cardImage) = _gameDeck.DealCard();
            playerCards2.Add(_gameDeck.DisplayPlayerCard(cardKey, cardImage, playerFlowPanel2));
            int score = CalculatePlayerScore(playerCards2);
            if (score == 21)
            {
                hitRightSideButton.Enabled = false;
                standRightSideButton.Enabled = false;
                rightSideLabel.Visible = true;
                rightSideLabel.Text = "Player Wins";
                rightDone = true;
                if (leftDone)
                {   
                    DealCardsButton.Visible= true;
                    gameDone = true;
                }
            }
            else if (score > 21)
            {
                hitRightSideButton.Enabled = false;
                standRightSideButton.Enabled = false;
                rightSideLabel.Visible = true;
                rightSideLabel.Text = "Player Busts";
                DealCardsButton.Visible = true;
                rightDone = true;
                if (leftDone)
                {
                    DealCardsButton.Visible = true;
                    gameDone = true;
                }
            }
            else
            {
                playerScore2 = score;
            }
        }

        private void standRightSideButton_Click(object sender, EventArgs e)
        {
            HandleSplitPlayer(leftDone, leftFlag, playerScore2, rightSideLabel, true);
        }

        private void HandleSplitPlayer(bool bustFlag, bool doneFlag,int playerScore, Label label, bool side)
        {
            if(doneFlag)
            {
                _gameDeck.RevealCard(dealerCards.ElementAt(1));
                int score = CalculatePlayerScore(dealerCards);
                HandleDealerHand(playerScore1, leftSideLabel);
                HandleDealerHand(playerScore2, rightSideLabel);
            }
            else if(bustFlag)
            {
                _gameDeck.RevealCard(dealerCards.ElementAt(1));
                int score = CalculatePlayerScore(dealerCards);
                HandleDealerHand(playerScore, label);
            }
            else if(side)
            {
                rightFlag = true;
            }
            else if(side == false)
            {
                leftFlag = true;
            }
        }

    }
}
