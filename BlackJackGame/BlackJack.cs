using Bunifu.UI.WinForms.BunifuButton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace BlackJackGame
{
    public partial class BlackJack : Form
    {
        private BlackJackDeck _gameDeck;
        private int _dealerCardCount = 0;
        //On Board Displayed Cards During the game
        private List<PictureBox> _dealerCards;
        private List<PictureBox> _splitLeftCards;
        private List<PictureBox> _normalSplitRightCards;
        //Normal Player Score or Split Scenario Score for both sides
        private int _splitLeftScore, _normalSplitRightScore;
        private bool leftDone = false, rightDone = false, split = false, gameDone = false;//leftFlag = false, rightFlag = false
        private BlackJackBetHandler _blackJackBetHandler;
        public BlackJack()
        {
            InitializeComponent();
            InitVariables();
        }

        private void InitVariables()
        {
            _gameDeck = new BlackJackDeck();
            _dealerCards = new List<PictureBox>();
            _splitLeftCards = new List<PictureBox>();
            _normalSplitRightCards = new List<PictureBox>();
            _blackJackBetHandler = new BlackJackBetHandler();
        }
        private void GameInit()
        {
            _dealerCards.Clear();
            _splitLeftCards.Clear();
            _normalSplitRightCards.Clear();
            SplitScenarioRightSideLabel.Visible = false;
            SplitScenarioLeftSideLabel.Visible = false;
            CenteredLabel.Visible = false;
            leftDone = false; rightDone = false; split = false; gameDone = false;
            SplitScenarioRightSideHitButton.Visible = false;
            SplitScenarioRightSideStandButton.Visible = false;
            SplitScenarioLeftSideHitButton.Visible = false;
            SplitScenarioLeftSideStandButton.Visible = false;
            // Reset the padding
            LeftRightPlayerFlowLayoutPanel.Padding = new Padding(0);
            LeftSidePlayerFlowLayoutPanel.Padding = new Padding(0);
            //enable the buttons that can be disabled while still being visible
            SplitScenarioRightSideHitButton.Enabled = true;
            SplitScenarioLeftSideHitButton.Enabled = true;
            SplitScenarioRightSideStandButton.Enabled = true;
            SplitScenarioLeftSideStandButton.Enabled = true;
            CenteredSplitButton.Enabled = true;
            foreach (Control control in DealerAndButtonsPanel.Controls.OfType<PictureBox>().ToList())
            {
                DealerAndButtonsPanel.Controls.Remove(control);
            }

            LeftSidePlayerFlowLayoutPanel.Controls.Clear();
            LeftRightPlayerFlowLayoutPanel.Controls.Clear();
            _dealerCardCount = 0;
        }

        private int CalculatePlayerScore(List<PictureBox> cards)
        {
            List<int> cardsValue = new List<int>();
            foreach (PictureBox card in cards)
            {
                cardsValue.Add(int.Parse(card.Name));
            }
            return _blackJackBetHandler.GetScore(cardsValue);
        }
        private void DealCardsButton_Click(object sender, EventArgs e)
        {
            if (gameDone)
            {
                GameInit();
            }
            DrawDealerCard();
            DrawPlayerCard(_normalSplitRightCards, LeftSidePlayerFlowLayoutPanel);
            DrawDealerCard();
            DrawPlayerCard(_normalSplitRightCards, LeftRightPlayerFlowLayoutPanel);
            DealCardsButton.Visible = false;

            int score = CalculatePlayerScore(_normalSplitRightCards);
            if (score == 21)
            {
                CenteredLabel.Visible = true;
                CenteredLabel.Text = "Blackjack";
                DealCardsButton.Visible = true;
                gameDone = true;
                return;
            }
            CenteredHitButton.Visible = true;
            CenteredSplitButton.Visible = true;
            // Enable split button if the two cards drawn are the same
            CenteredSplitButton.Enabled = _normalSplitRightCards[0].Name == _normalSplitRightCards[1].Name;
            CenteredStandButton.Visible = true;

            _normalSplitRightScore = score;
        }

        private void CenteredHitButton_Click(object sender, EventArgs e)
        {
            CenteredSplitButton.Enabled = false;
            DrawPlayerCard(_normalSplitRightCards, LeftRightPlayerFlowLayoutPanel);
            int score = CalculatePlayerScore(_normalSplitRightCards);

            HandleHitOutcome(score, ref _normalSplitRightScore, CenteredLabel);
        }

        private void HandleHitOutcome(int score, ref int scoreToUpdate, Label label)
        {
            if (score >= 21)
            {
                CenteredLabel.Visible = true;
                EndGame();
                HideCenteredControls();
                label.Text = score == 21 ? "Player Wins" : "Player Busts";
            }
            else
            {
                scoreToUpdate = score;
            }
        }

        private void DrawDealerCard()
        {
            (string cardKey, Image cardImage) = _gameDeck.DealCard();
            _dealerCards.Add(_gameDeck.DisplayDealerCard(cardKey, cardImage, DealerAndButtonsPanel, _dealerCardCount++));
        }

        private void DrawPlayerCard(List<PictureBox> cards, FlowLayoutPanel panel)
        {
            (string cardKey, Image cardImage) = _gameDeck.DealCard();
            cards.Add(_gameDeck.DisplayPlayerCard(cardKey, cardImage, panel));
        }
        private void HandleDealerHand(int playerScore, Label label)
        {
            int dealerScore = CalculatePlayerScore(_dealerCards);

            // Dealer draws until score is 17 or higher
            if (dealerScore < 17)
            {
                DrawDealerCard();
                HandleDealerHand(playerScore, label);
                return;
            }

            // Game resolution
            bool isDraw = dealerScore == playerScore;
            bool isDealerWin = dealerScore > playerScore && dealerScore <= 21;
            bool isPlayerWin = dealerScore < playerScore || dealerScore > 21;

            if (isDraw)
            {
                ResolveGame(label, "Draw");
            }
            else if (isDealerWin)
            {
                ResolveGame(label, "Dealer Wins");
            }
            else if (isPlayerWin)
            {
                ResolveGame(label, "Player wins");
            }
        }
        private void HideButtonsAndLabels()
        {
            //set all buttons and labels to hidden
            CenteredLabel.Visible = false;
            CenteredLabel.Visible = false;
            SplitScenarioRightSideHitButton.Visible = false;
            SplitScenarioRightSideStandButton.Visible = false;
            SplitScenarioLeftSideHitButton.Visible = false;
            SplitScenarioLeftSideStandButton.Visible = false;
            HideCenteredControls();
        }
        private void ResolveGame(Label label, string result)
        {
            HideButtonsAndLabels();

            // If game is not split or both sides are done
            if (!split || (leftDone && rightDone))
            {
                EndGame();
            }

            label.Visible = true;
            label.Text = result;

            // Only update CenteredLabel if the game isn't split
            if (!split && (result.Equals("Dealer Busts") || result.Equals("Dealer Wins")))
            {
                CenteredLabel.Visible = true;
                CenteredLabel.Text = result;
            }
        }

        private void CenteredStandButton_Click(object sender, EventArgs e)
        {
            _gameDeck.RevealCard(_dealerCards.ElementAt(1));
            int score = CalculatePlayerScore(_dealerCards);
            if (score == 21)
            {
                EndGame();
                CenteredLabel.Text = "Push";
                DealCardsButton.Visible = true;
                HideCenteredControls();
            }
            else
            {
                HandleDealerHand(_normalSplitRightScore, CenteredLabel);
            }
        }

        private void CenteredSplitButton_Click(object sender, EventArgs e)
        {
            HideCenteredControls();
            PerformSplit();

            // Adjust the padding here
            LeftRightPlayerFlowLayoutPanel.Padding = new Padding(50, 0, 0, 0); // Adjust the 50 to the value you want
            LeftSidePlayerFlowLayoutPanel.Padding = new Padding(50, 0, 0, 0); // Adjust the 50 to the value you want

            HandleSplitScenarios();
        }

        private void HideCenteredControls()
        {
            CenteredSplitButton.Visible = false;
            CenteredHitButton.Visible = false;
            CenteredStandButton.Visible = false;
        }

        private void PerformSplit()
        {
            split = true;
            _splitLeftCards.Add(_normalSplitRightCards.ElementAt(0));
            _normalSplitRightCards.RemoveAt(0);

            // You can adjust the padding or margin here for offset
            DrawPlayerCard(_normalSplitRightCards, LeftRightPlayerFlowLayoutPanel);
            DrawPlayerCard(_splitLeftCards, LeftSidePlayerFlowLayoutPanel);

            _splitLeftScore = CalculatePlayerScore(_splitLeftCards);
            _normalSplitRightScore = CalculatePlayerScore(_normalSplitRightCards);
        }

        private void HandleSplitScenarios()
        {
            if (_normalSplitRightScore == 21 && _splitLeftScore == 21)
            {
                EndGame();
                return;
            }

            HandleLeftSplitScenario();
            HandleRightSplitScenario();
        }

        private void EndGame()
        {
            DealCardsButton.Visible = true;
            gameDone = true;
        }

        private void HandleLeftSplitScenario()
        {
            if (_splitLeftScore == 21)
            {
                DisplayBlackjack(SplitScenarioLeftSideLabel);
                leftDone = true;
            }
            else
            {
                DisplaySplitScenarioControls(SplitScenarioLeftSideHitButton, SplitScenarioLeftSideStandButton);
            }
        }

        private void HandleRightSplitScenario()
        {
            if (_normalSplitRightScore == 21)
            {
                DisplayBlackjack(SplitScenarioRightSideLabel);
                rightDone = true;
            }
            else
            {
                DisplaySplitScenarioControls(SplitScenarioRightSideStandButton, SplitScenarioRightSideHitButton);
            }
        }

        private void DisplayBlackjack(Label label)
        {
            label.Visible = true;
            label.Text = "BlackJack";
        }

        private void DisplaySplitScenarioControls(BunifuButton hitButton, BunifuButton standButton)
        {
            hitButton.Visible = true;
            standButton.Visible = true;
        }



        private void SplitScenarioLeftSideHitButton_Click(object sender, EventArgs e)
        {
            DrawPlayerCard(_splitLeftCards, LeftSidePlayerFlowLayoutPanel);
            HandleHitAction(_splitLeftCards, SplitScenarioLeftSideHitButton, SplitScenarioLeftSideStandButton, SplitScenarioLeftSideLabel, ref leftDone, ref _splitLeftScore);
        }

        private void SplitScenarioRightSideHitButton_Click(object sender, EventArgs e)
        {
            DrawPlayerCard(_normalSplitRightCards, LeftRightPlayerFlowLayoutPanel);
            HandleHitAction(_normalSplitRightCards, SplitScenarioRightSideHitButton, SplitScenarioRightSideStandButton, SplitScenarioRightSideLabel, ref rightDone, ref _normalSplitRightScore);
        }

        private void HandleHitAction(List<PictureBox> cards, BunifuButton hitButton, BunifuButton standButton, Label resultLabel, ref bool isDone, ref int scoreToUpdate)
        {
            int score = CalculatePlayerScore(cards);

            if (score >= 21)
            {
                EndSplitTurn(hitButton, standButton, resultLabel, score);
                isDone = true;
                CheckIfGameIsDone();
            }
            else
            {
                scoreToUpdate = score;
            }
            if (isDone)
            {
                CheckIfGameIsDone();
            }
        }
        private void EndSplitTurn(BunifuButton hitButton, BunifuButton standButton, Label resultLabel, int score)
        {
            DisableSplitControls(hitButton, standButton);
            SetSplitLabel(resultLabel, score);
            CheckIfGameIsDone();
        }

        private void DisableSplitControls(BunifuButton hitButton, BunifuButton standButton)
        {
            hitButton.Enabled = false;
            standButton.Enabled = false;
        }

        private void SetSplitLabel(Label resultLabel, int score)
        {
            resultLabel.Visible = true;
            resultLabel.Text = score == 21 ? "Player Wins" : "Player Busts";
        }

        private void CheckIfGameIsDone()
        {
            if (leftDone && rightDone)
            {
                EndGame();
            }
        }
        private void SplitScenarioRightSideStandButton_Click(object sender, EventArgs e)
        {
            rightDone = true;
            SplitScenarioRightSideHitButton.Enabled = false;
            SplitScenarioRightSideStandButton.Enabled = false;
            HandleSplitPlayer();
        }

        private void SplitScenarioLeftSideStandButton_Click(object sender, EventArgs e)
        {
            leftDone = true;
            SplitScenarioLeftSideHitButton.Enabled = false;
            SplitScenarioLeftSideStandButton.Enabled = false;
            HandleSplitPlayer();
        }

        private void HandleSplitPlayer()
        {
            // Only proceed to dealer's turn when both players have decided (either stand or bust)
            if (leftDone && rightDone)
            {
                _gameDeck.RevealCard(_dealerCards.ElementAt(1));
                HandleDealerHand(_splitLeftScore, SplitScenarioLeftSideLabel);
                HandleDealerHand(_normalSplitRightScore, SplitScenarioRightSideLabel);
            }
        }
    }
}
