/*
 * Created by: Ohriniuc Claudiu-Constantin
 *
 * Functionality: This form implements the user interface of the poker game
 *
*/
using Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Users;

namespace PokerGame
{
    public partial class PokerForm : Form
    {
        // Instance of the poker game logic
        readonly IPoker poker = new Poker();
        IUser user;
        IUserDatabase database;
        int winnings;
        int balance;
        int bet;

        // Counters for keeping track of game state
        int gameTickCounter = 0;
        int interGameTickCounter = 0;

        // Arrays to hold the card image and button controls
        PictureBox[] pictureBoxes;
        Button[] buttons;

        public PokerForm()
        {
            InitializeComponent();
        }

        public PokerForm(IUser user, IUserDatabase database)
        {
            InitializeComponent();
            this.database = database;
            this.user = user;
        }


        // Load event for the form
        private void PokerForm_Load(object sender, EventArgs e)
        {
            // Initialize button and picturebox arrays with the respective controls
            buttons = new Button[] { Card1Button, Card2Button, Card3Button, Card4Button, Card5Button };
            pictureBoxes = new PictureBox[] { Card1PictureBox, Card2PictureBox, Card3PictureBox, Card4PictureBox, Card5PictureBox };

            balance = database.GetUserBalance(user.Username);
            MoneyTextBox.Text = balance.ToString();

            // Populate initial card images and remove them from the deck
            for (int i = 0; i < 5; i++)
            {
                UpdateCard(i);
                poker.RemoveCard(pictureBoxes[i].Name);
            }
        }

        // Click event handler for the Play button
        private void PlayButton_Click(object sender, EventArgs e)
        {
            // Disable Play button and Bet number input, enable GameTimer
            GameTimer.Enabled = true;
            PlayButton.Enabled = false;
            BetNumericUpDown.Enabled = false;


            // Get the bet value from the number input
            balance = database.GetUserBalance(user.Username);
            bet = (int)BetNumericUpDown.Value;
            if (balance >= bet)
            {
                poker.BetValue = bet;
            }
            else
            {
                poker.BetValue = 0;
                MessageBox.Show("Your bet cannot be bigger than your balance!");
            }

            // Disable all card buttons and add the card to the deck if it should be shuffled
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Enabled = false;
                if (buttons[i].Text == "Shuffle")
                {
                    poker.AddCard(pictureBoxes[i].Name, pictureBoxes[i].Image);
                }
            }
        }

        // Click event handlers for card buttons
        private void Card1Button_Click(object sender, EventArgs e) { ButtonChangeText(0); }
        private void Card2Button_Click(object sender, EventArgs e) { ButtonChangeText(1); }
        private void Card3Button_Click(object sender, EventArgs e) { ButtonChangeText(2); }
        private void Card4Button_Click(object sender, EventArgs e) { ButtonChangeText(3); }
        private void Card5Button_Click(object sender, EventArgs e) { ButtonChangeText(4); }

        // Tick event handler for the GameTimer
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            // If we have reached the end of the game ticks...
            if (gameTickCounter == 9)
            {
                // Reset the game tick counter, stop the game timer, calculate winnings and enable inter-game timer
                gameTickCounter = 0;
                GameTimer.Enabled = false;
                winnings = poker.CalculateWinnings(pictureBoxes.Select(p => p.Name).ToArray());
                if (winnings > poker.BetValue)
                {
                    database.AddUserBalance(user.Username, winnings);
                }
                else if (winnings == 0)
                {
                    database.AddUserBalance(user.Username, -poker.BetValue);
                }
                MoneyTextBox.Text = database.GetUserBalance(user.Username).ToString();

                WinningsTextBox.Text = winnings.ToString();
                InterGameTimer.Enabled = true;
            }
            else
            {
                // Shuffle cards and put the final cards down one by one
                for (int i = 0; i < pictureBoxes.Length; i++)
                {
                    if (buttons[i].Text == "Shuffle" && gameTickCounter - 4 <= i)
                    {
                        UpdateCard(i);
                        if (gameTickCounter - 4 == i)
                        {
                            poker.RemoveCard(pictureBoxes[i].Name);
                        }
                    }
                }
                gameTickCounter++;
            }
        }

        // Tick event handler for the InterGameTimer
        private void InterGameTimer_Tick(object sender, EventArgs e)
        {
            interGameTickCounter++;
            if (interGameTickCounter == 1)
            {
                // Renew the deck for the next hand
                poker.RenewDeck();
            }
            if (interGameTickCounter == 11)
            {
                // Hide all cards (flip them face down)
                for (int i = 0; i < 5; i++)
                {
                    pictureBoxes[i].Image = Resources.ResourceManager.GetImage("Resources.Resources.cardBack.png");
                }
            }
            if (interGameTickCounter > 12 && interGameTickCounter <= 17)
            {
                // Reveal one card at a time for a better experience
                int index = interGameTickCounter - 13;
                UpdateCard(index);
                poker.RemoveCard(pictureBoxes[index].Name);
            }
            if (interGameTickCounter == 18)
            {
                // Reset the inter-game tick counter, stop the inter-game timer, enable Play button and Bet number input, reset all card buttons
                interGameTickCounter = 0;
                InterGameTimer.Enabled = false;
                PlayButton.Enabled = true;
                BetNumericUpDown.Enabled = true;
                for (int i = 0; i < 5; i++)
                {
                    buttons[i].Text = "Keep";
                    buttons[i].Enabled = true;
                }
            }
        }

        // Toggles the text of a button between "Keep" and "Shuffle"
        private void ButtonChangeText(int index)
        {
            buttons[index].Text = (buttons[index].Text == "Keep") ? "Shuffle" : "Keep";
        }

        // Updates the image of a card with a new random image
        private void UpdateCard(int index)
        {
            KeyValuePair<string, System.Drawing.Image> image = poker.GetRandomImage();
            pictureBoxes[index].Image = image.Value;
            pictureBoxes[index].Name = image.Key;
        }
    }
}
