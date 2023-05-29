﻿/*
 * Created by: Farcas Cosmin Catalin 
 *
 * Functionality:
 * The following program is a BlackJack card game simulator. It involves simulating a deck of cards,
 * dealing cards to the dealer and the player, and applying the rules of BlackJack to determine the winner.
 * The program also supports bet placing and splitting hands.
 * The program connects to a database for user authentication and balance management.
*/
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
using System.Xml.Linq;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using Users;
using Database;

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
        private bool _splitLeftHandDone = false;
        private bool _splitRightHandDone = false;
        private bool _splitGameScenario = false;
        private bool _splitLeftHandBust = false;
        private bool _splitRightHandBust = false;
        private bool _gameDone = false;//leftFlag = false, rightFlag = false
        private BlackJackBetHandler _blackJackBetHandler;
        private decimal _bet;
        private decimal _winnings;
        private int _balance;
        //database and user
        private IUser _user;
        private IUserDatabase _database;

        
        public BlackJack()
        {
            InitializeComponent();
            InitVariables();
        }

        public BlackJack(IUser user, IUserDatabase database)
        {
            InitializeComponent();
            InitVariables();
            this._user = user;
            this._database = database;
        }

        private void BlackJack_Load(object sender, EventArgs e)
        {
            // Fetch user balance from the database when the form is loaded
            _balance = _database.GetUserBalance(_user.Username);
            BalanceTextBox.Text = _balance.ToString();
        }

        private void InitVariables()
        {
            // Initialize the necessary variables for the game to function
            _gameDeck = new BlackJackDeck();
            _dealerCards = new List<PictureBox>();
            _splitLeftCards = new List<PictureBox>();
            _normalSplitRightCards = new List<PictureBox>();
            _blackJackBetHandler = new BlackJackBetHandler();
        }
        private void GameInit()
        {
            //Clear dealt cards
            _dealerCards.Clear();
            _splitLeftCards.Clear();
            _normalSplitRightCards.Clear();
            SplitScenarioRightSideLabel.Visible = false;
            SplitScenarioLeftSideLabel.Visible = false;
            CenteredLabel.Visible = false;
            //reset flags
            _splitLeftHandDone = false;
            _splitRightHandDone = false;
            _splitGameScenario = false;
            _splitLeftHandBust = false;
            _splitRightHandBust = false;
            _gameDone = false;
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

        public int CalculatePlayerScore(List<PictureBox> cards)
        {
            List<int> cardsValue = new List<int>();
            foreach (PictureBox card in cards)
            {
                cardsValue.Add(int.Parse(card.Name));
            }
            return _blackJackBetHandler.GetScore(cardsValue);
        }
        //deals the initial 4 cards
        private void DealCardsButton_Click(object sender, EventArgs e)
        {
            if (_gameDone)
            {
                GameInit();
            }
            DrawDealerCard();
            DrawPlayerCard(_normalSplitRightCards, LeftSidePlayerFlowLayoutPanel);
            DrawDealerCard();
            DrawPlayerCard(_normalSplitRightCards, LeftRightPlayerFlowLayoutPanel);
            DealCardsButton.Visible = false;
            //checks if blackjack
            int score = CalculatePlayerScore(_normalSplitRightCards);
            CheckBalanceGreaterThanBet();
            UpdateDatabaseBalance();
            if (score == 21)
            {
                CenteredLabel.Visible = true;
                CenteredLabel.Text = "Blackjack";
                DealCardsButton.Visible = true;
                _gameDone = true;
                _winnings = _bet*2;
                WinningsTextbox.Text = _winnings.ToString();
                UpdateDatabaseIfWin();
                return;
            }
           
            _winnings = 0;
            WinningsTextbox.Text = _winnings.ToString();

            CenteredHitButton.Visible = true;
            CenteredSplitButton.Visible = true;
            // Enable split button if the two cards drawn are the same
            CenteredSplitButton.Enabled = _normalSplitRightCards[0].Name == _normalSplitRightCards[1].Name;
            CenteredStandButton.Visible = true;

            _normalSplitRightScore = score;
        }

        private void CheckBalanceGreaterThanBet()
        {
            _balance = _database.GetUserBalance(_user.Username);
            _bet = BetNumericUpDown.Value;
            if (_balance < _bet)
            {
                _bet = 0;
                BetNumericUpDown.Value = _bet;
                MessageBox.Show("Your bet cannot be bigger than your balance!");
            }
        }
        
        private void UpdateDatabaseIfWin()
        {
            _database.AddUserBalance(_user.Username, (int)_winnings);
            _balance = _database.GetUserBalance(_user.Username);
            BalanceTextBox.Text = _balance.ToString();
        }

        private void UpdateDatabaseBalance()
        {
            if (_balance >= _bet)
            {
                _balance -= (int)_bet;
                _database.UpdateUserBalance(_user.Username, _balance);
                BalanceTextBox.Text = _balance.ToString();
            }
        }

        private void CenteredHitButton_Click(object sender, EventArgs e)
        {
            // When hit button is clicked, draw a new card and calculate the new score
            // Then checks the updated score and handles the game logic accordingly
            CenteredSplitButton.Enabled = false;
            DrawPlayerCard(_normalSplitRightCards, LeftRightPlayerFlowLayoutPanel);
            int score = CalculatePlayerScore(_normalSplitRightCards);
            CheckBalanceGreaterThanBet();
            if(_balance >=_bet)
                HandleHitOutcome(score, ref _normalSplitRightScore, CenteredLabel);
        }

        private void CenteredStandButton_Click(object sender, EventArgs e)
        {
            // When stand button is clicked, reveal dealer's card and calculate the score
            // Then checks the updated score and handles the game logic accordingly
            CheckBalanceGreaterThanBet();
            _gameDeck.RevealCard(_dealerCards.ElementAt(1));
            int score = CalculatePlayerScore(_dealerCards);
            if (score == 21)
            {
                EndGame();
                CenteredLabel.Visible = true;
                CenteredLabel.Text = "Push";
                DealCardsButton.Visible = true;
                HideCenteredControls();
                _winnings = _bet * 2;
                WinningsTextbox.Text = _winnings.ToString();
                UpdateDatabaseIfWin();
                return;
            }
            HandleDealerHand(_normalSplitRightScore, CenteredLabel);
        }

        // This method is triggered when split button is clicked
        private void CenteredSplitButton_Click(object sender, EventArgs e)
        {
            // When split button is clicked, check the user balance and update the bet
            // The user's hand is split into two if the user has sufficient balance
            _balance = _database.GetUserBalance(_user.Username);
            _bet = BetNumericUpDown.Value;
            //check so that the balance is bigger than double the bet
            if (_balance < _bet * 2)
            {
                _bet = 0;
                BetNumericUpDown.Value = _bet;
                MessageBox.Show("You cannot split if double the bet is bigger than your balance!");
            }
            else
            {
                // Update the bet to reflect the split scenario
                //When the split button is pressed the initial bet value would be doubled while the bet for each hand would stay the same
                BetNumericUpDown.Value = _bet * 2;
                _database.AddUserBalance(_user.Username, (int)-_bet);
                _balance = _database.GetUserBalance(_user.Username);
                BalanceTextBox.Text = _balance.ToString();
                HideCenteredControls();
                PerformSplit();
                HandleSplitScenarios();
                // Adjust the padding here
                LeftRightPlayerFlowLayoutPanel.Padding = new Padding(50, 0, 0, 0); // Adjust the 50 to the value you want
                LeftSidePlayerFlowLayoutPanel.Padding = new Padding(50, 0, 0, 0); // Adjust the 50 to the value you want
            }
        }


        //handles hit outcome
        private void HandleHitOutcome(int score, ref int scoreToUpdate, Label label)
        {
            if (score >= 21)
            {
                CenteredLabel.Visible = true;
                EndGame();
                HideCenteredControls();
                if (score == 21)
                {
                    label.Text = "Player Wins";
                    _winnings = 2 * _bet;
                    UpdateDatabaseIfWin();
                }
                else
                {
                    label.Text = "Player Busts";
                }
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
            if (!_splitGameScenario || (_splitLeftHandDone && _splitRightHandDone))
            {
                EndGame();
            }

            label.Visible = true;
            label.Text = result;
            
            //update winnings if player wins / draws
            if (result == "Player wins")
            {
                _winnings = _bet * 2;
                
            }
            else if (result == "Draw")
            {
                _winnings = _bet;
            }
            // Show winnings
            WinningsTextbox.Text = _winnings.ToString();
            if(result == "Player wins" || result =="Draw")
                UpdateDatabaseIfWin();

            // Only update CenteredLabel if the game isn't split
            if (!_splitGameScenario && (result.Equals("Dealer Busts") || result.Equals("Dealer Wins")))
            {
                CenteredLabel.Visible = true;
                CenteredLabel.Text = result;
                if (result == "Dealer Busts")
                {
                    _winnings = _bet * 2;
                    UpdateDatabaseIfWin();
                    return;
                }
            }
        }

        private void HideCenteredControls()
        {
            CenteredSplitButton.Visible = false;
            CenteredHitButton.Visible = false;
            CenteredStandButton.Visible = false;
        }
        //splits the hand into 2 hands and deals 1 card to each
        private void PerformSplit()
        {
            _splitGameScenario = true;
            _splitLeftCards.Add(_normalSplitRightCards.ElementAt(0));
            _normalSplitRightCards.RemoveAt(0);

            // You can adjust the padding or margin here for offset
            DrawPlayerCard(_normalSplitRightCards, LeftRightPlayerFlowLayoutPanel);
            DrawPlayerCard(_splitLeftCards, LeftSidePlayerFlowLayoutPanel);

            _splitLeftScore = CalculatePlayerScore(_splitLeftCards);
            _normalSplitRightScore = CalculatePlayerScore(_normalSplitRightCards);
        }
        //checks if blackjack on either hands or both
        private void HandleSplitScenarios()
        {
            if (_normalSplitRightScore == 21 && _splitLeftScore == 21)
            {
                _winnings = _bet * 4;
                UpdateDatabaseIfWin();
                DisplayBlackjack(SplitScenarioLeftSideLabel);
                DisplayBlackjack(SplitScenarioRightSideLabel);
                EndGame();
                return;
            }

            HandleLeftSplitScenario();
            HandleRightSplitScenario();
        }
        //ends game
        private void EndGame()
        {
            DealCardsButton.Visible = true;
            _gameDone = true;
        }
        //checks if left hand hits blackjack
        private void HandleLeftSplitScenario()
        {
            if (_splitLeftScore == 21)
            {
                DisplayBlackjack(SplitScenarioLeftSideLabel);
                _splitLeftHandDone = true;
                _winnings = _bet * 2;
                UpdateDatabaseIfWin();
            }
            else
            {
                DisplaySplitScenarioControls(SplitScenarioLeftSideHitButton, SplitScenarioLeftSideStandButton);
            }
        }

        //checks if right hand hits blackjack
        private void HandleRightSplitScenario()
        {
            if (_normalSplitRightScore == 21)
            {
                DisplayBlackjack(SplitScenarioRightSideLabel);
                _splitRightHandDone = true;
                 _winnings = _bet * 2;
                UpdateDatabaseIfWin();
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

        //handles left hand hit button
        private void SplitScenarioLeftSideHitButton_Click(object sender, EventArgs e)
        {
            DrawPlayerCard(_splitLeftCards, LeftSidePlayerFlowLayoutPanel);
            HandleHitAction(_splitLeftCards, SplitScenarioLeftSideHitButton, SplitScenarioLeftSideStandButton, SplitScenarioLeftSideLabel, ref _splitLeftHandDone, ref _splitLeftScore, ref _splitLeftHandBust);
        }

        //handles right hand hit button
        private void SplitScenarioRightSideHitButton_Click(object sender, EventArgs e)
        {
            DrawPlayerCard(_normalSplitRightCards, LeftRightPlayerFlowLayoutPanel);
            HandleHitAction(_normalSplitRightCards, SplitScenarioRightSideHitButton, SplitScenarioRightSideStandButton, SplitScenarioRightSideLabel, ref _splitRightHandDone, ref _normalSplitRightScore, ref _splitRightHandBust);
        }

        //handles split scenario hit button on either hand that called this method
        private void HandleHitAction(List<PictureBox> cards, BunifuButton hitButton, BunifuButton standButton, Label resultLabel, ref bool isDone, ref int scoreToUpdate, ref bool isBusted)
        {
            int score = CalculatePlayerScore(cards);

            if (score >= 21)
            {
                EndSplitTurn(hitButton, standButton, resultLabel, score);
                isDone = true;
                isBusted = score > 21; // Set isBusted to true if score > 21
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

        //ends split scenario
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
            if (_splitLeftHandDone && _splitRightHandDone)
            {
                HandleSplitPlayer();
            }
            if (_splitLeftHandBust && _splitRightHandBust)
            {
                EndGame();
            }
        }

        //handles right hand stand button
        private void SplitScenarioRightSideStandButton_Click(object sender, EventArgs e)
        {
            _splitRightHandDone = true;
            _splitRightHandBust = false; // Set this to false because we stand, not bust
            SplitScenarioRightSideHitButton.Enabled = false;
            SplitScenarioRightSideStandButton.Enabled = false;
            CheckIfGameIsDone();
        }

        //handles left hand stand button
        private void SplitScenarioLeftSideStandButton_Click(object sender, EventArgs e)
        {
            _splitLeftHandDone = true;
            _splitLeftHandBust = false; // Set this to false because we stand, not bust
            SplitScenarioLeftSideHitButton.Enabled = false;
            SplitScenarioLeftSideStandButton.Enabled = false;
            CheckIfGameIsDone();
        }

    
    
        private void HandleSplitPlayer()
        {
            // Only proceed to dealer's turn when both players have decided (either stand or bust)
            if (_splitLeftHandDone && _splitRightHandDone)
            {
                _gameDeck.RevealCard(_dealerCards.ElementAt(1));
                if (CalculatePlayerScore(_dealerCards) == 21)
                {
                    EndGame();
                    DealCardsButton.Visible = true;
                    HideButtonsAndLabels();
                    CenteredLabel.Visible = true;
                    CenteredLabel.Text = "Push";
                    _bet = BetNumericUpDown.Value;
                    _winnings = _bet;
                    WinningsTextbox.Text = _winnings.ToString();
                    _database.AddUserBalance(_user.Username, (int)_winnings);
                    _balance = _database.GetUserBalance(_user.Username);
                    BalanceTextBox.Text = _balance.ToString();
                    return;
                }
                if (!_splitLeftHandBust) // Check if left hand has busted before processing it
                {
                    HandleDealerHand(_splitLeftScore, SplitScenarioLeftSideLabel);
                }
                if (!_splitRightHandBust) // Check if right hand has busted before processing it
                {
                    HandleDealerHand(_normalSplitRightScore, SplitScenarioRightSideLabel);
                }
            }
        }
    }
}
