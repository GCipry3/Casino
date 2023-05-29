/*
 * Created by: Galbeaza Ciprian
 * 
 * Functionality: This class contains the game logic for the CoinFlip game.
 *                  It handles the button clicks and the timer ticks.
 *                  Also here we take care of the betting system.
 * 
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Users;
using Database;
using System.Threading;

namespace CoinFlipGame
{
    public partial class CoinFlip : Form
    {
        public ICoin coin;
        public int heads;
        public int tails;
        public bool flippingFlag = false;

        public List<Image> coinFrames;
        public int currentFrame = 0;
        public CoinState state;
        private IUser user;
        private IUserDatabase database;

        public CoinFlip(IUser user, IUserDatabase database)
        {
            InitializeComponent();

            coin = new CoinFactory("FlipperCoin").CreateCoin();
            comboBoxCoinFace.SelectedIndex = 0;
            state = new NotFlippingState(this);
            
            this.user = user;
            this.database = database;

            // Update the balance label every 2 seconds
            System.Threading.Timer timer = new System.Threading.Timer(
                new TimerCallback(UpdateBalanceLabel),
                null,
                0,
                2000 // set the interval to 2 seconds
            );
        }
        private void UpdateBalanceLabel(object state)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    FundsTextBox.Text = $"{database.GetUserBalance(user.Username)}";
                }));
            }
            else
            {
                FundsTextBox.Text = $"{database.GetUserBalance(user.Username)}";
            }
        }

        private void bunifuButtonFlipCoin_Click(object sender, EventArgs e)
        {
            // Check if the user has enough funds to place the bet
            if (database.GetUserBalance(user.Username) < BetNumericUpDown.Value)
            {
                MessageBox.Show("You don't have enough funds to place this bet.");
                return;
            }

            // Subtract the bet from the user's balance and start the coin flip using the state machine
            database.AddUserBalance(user.Username, -1 * (int)BetNumericUpDown.Value);
            state.FlipCoin();
        }

        private void timerFlip_Tick(object sender, EventArgs e)
        {
            // Start the coin flip animation
            state.Tick();
        }
        private int GetWinning()
        {
            string selectedCoinFace = comboBoxCoinFace.SelectedItem?.ToString();
            string resultText = coin.GetResult(); 

            // If the user has selected the same coin face as the result, he wins
            return (int)((selectedCoinFace == resultText) ? BetNumericUpDown.Value*2 : 0);
        }
        
        // Update the result label and the user's balance
        public void UpdateResult()
        {
            string resultText = coin.GetResult();
            int winning = GetWinning();
            if (winning > 0)
            {
                database.AddUserBalance(user.Username, winning);
            }

            bunifuLabelResult.Text = (winning > 0) ? $"You win! The result is {resultText}" : $"You lose. The result is {resultText}";
            
            // Count the number of heads and tails
            if (resultText == "Heads")
                HeadsCountLabel.Text = $"Heads: {++heads}";
            else
                TailsCountLabel.Text = $"Tails: {++tails}";

            FundsTextBox.Text = $"{database.GetUserBalance(user.Username)}";
            state = new NotFlippingState(this);
        }
    }
    
}
