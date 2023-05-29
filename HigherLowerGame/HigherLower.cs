/*
 * Created by: Ohriniuc Claudiu-Constantin
 *
 * Functionality: this Form handles the user interface of the HigherLowerGame
 *
*/
using Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Users;

namespace HigherLowerGame
{
    public partial class HigherLower : Form
    {
        // Initialize a new HigherLowerGame instance
        readonly HigherLowerGame higherLowerGame = new HigherLowerGame();
        IUser user;
        IUserDatabase database;
        int winnings;
        int balance;
        int bet;

        // Counter for the timer ticks
        int tickCounter = 0;

        // Variable to store the name of the last displayed card
        string lastCard;

        // Constants for the timer tick limit and game options
        private const int ShuffleTickLimit = 5;
        private const string OptionHigher = "higher";
        private const string OptionLower = "lower";

        public HigherLower()
        {
            InitializeComponent();
        }

        public HigherLower(IUser user, IUserDatabase database)
        {
            InitializeComponent();
            this.database = database;
            this.user = user;
        }

        private void HigherLower_Load(object sender, EventArgs e)
        {
            // Update the card image when the form loads
            UpdateCard();

            // Update the lastCard value and remove the card from the deck
            balance = database.GetUserBalance(user.Username);
            MoneyTextBox.Text = balance.ToString();

            lastCard = CardPictureBox.Name;
            higherLowerGame.RemoveCard(lastCard);
        }

        private void ShuffleTimer_Tick(object sender, EventArgs e)
        {
            tickCounter++;
            if (tickCounter == ShuffleTickLimit)
            {
                // Stop the timer after 5 ticks, reset the tick counter and enable the buttons
                ShuffleTimer.Stop();
                tickCounter = 0;
                HigherButton.Enabled = true;
                LowerButton.Enabled = true;

                // Calculate the winnings and update the lastCard value
                winnings = higherLowerGame.CalculateWinnings(lastCard, CardPictureBox.Name);
                if (winnings > higherLowerGame.BetValue)
                {
                    database.AddUserBalance(user.Username, winnings);
                }
                else if (winnings == 0)
                {
                    database.AddUserBalance(user.Username, -higherLowerGame.BetValue);
                }
                balance = database.GetUserBalance(user.Username);
                MoneyTextBox.Text = balance.ToString();

                WinningsTextBox.Text = winnings.ToString();

                lastCard = CardPictureBox.Name;
                higherLowerGame.RemoveCard(lastCard);
            }
            else
            {
                // Update the card image for each tick of the timer
                UpdateCard();
            }
        }

        private void HigherButton_Click(object sender, EventArgs e)
        {
            // Disable the buttons and set the game option to higher when the HigherButton is clicked
            SetGameOption(OptionHigher);
        }

        private void LowerButton_Click(object sender, EventArgs e)
        {
            // Disable the buttons and set the game option to lower when the LowerButton is clicked
            SetGameOption(OptionLower);
        }

        private void UpdateCard()
        {
            // Update the card image and the card name display
            KeyValuePair<string, Image> image = higherLowerGame.GetRandomImage();
            CardPictureBox.Image = image.Value;
            CardPictureBox.Name = image.Key;
        }

        private void SetGameOption(string option)
        {
            // Disable the buttons and set the game option
            LowerButton.Enabled = false;
            HigherButton.Enabled = false;
            higherLowerGame.Option = option;
            balance = database.GetUserBalance(user.Username);
            bet = (int)BetNumericUpDown.Value;
            if (balance >= bet)
            {
                higherLowerGame.BetValue = bet;
            }
            else
            {
                higherLowerGame.BetValue = 0;
                MessageBox.Show("Your bet cannot be bigger than your balance!");
            }
            ShuffleTimer.Enabled = true;
        }
    }
}
