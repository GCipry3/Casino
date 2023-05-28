using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HigherLowerGame
{
    public partial class HigherLower : Form
    {
        // Initialize a new HigherLowerGame instance
        readonly HigherLowerGame higherLowerGame = new HigherLowerGame();

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

        private void HigherLower_Load(object sender, EventArgs e)
        {
            // Update the card image when the form loads
            UpdateCard();

            // Update the lastCard value and remove the card from the deck
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
                WinningsTextBox.Text = higherLowerGame.CalculateWinnings(lastCard, CardPictureBox.Name).ToString();
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
            MoneyTextBox.Text = CardPictureBox.Name + " ";
        }

        private void SetGameOption(string option)
        {
            // Disable the buttons and set the game option
            LowerButton.Enabled = false;
            HigherButton.Enabled = false;
            higherLowerGame.Option = option;
            higherLowerGame.BetValue = (int)BetNumericUpDown.Value;
            ShuffleTimer.Enabled = true;
        }
    }
}
