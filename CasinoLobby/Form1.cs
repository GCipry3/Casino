using System;
using System.Windows.Forms;
using CoinFlipGame;
using SlotsGame;
using DicesGame;
using Users;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Database;
using BlackJackGame;
using PokerGame;
using HigherLowerGame;

namespace CasinoLobby
{
    public partial class Form1 : Form
    {
        ProxyUser connectedUser;
        IUserDatabase database;
        public Form1()
        {
            InitializeComponent();
            database = new SQLiteUserDatabase();
        }

        private void CoinFlipButton_Click(object sender, EventArgs e)
        {
            CoinFlip coinFlip = new CoinFlip(connectedUser,database);  // Initialize the form
            coinFlip.Show();  // Show the form
        }

        private void SlotsButton_Click(object sender, EventArgs e)
        {
            Slots slots = new Slots(connectedUser, database);
            slots.Show();
        }

        private void DicesGameButton_Click(object sender, EventArgs e)
        {
            Dices dices = new Dices(connectedUser, database);
            dices.Show();
        }

        private void BlackJackButton_Click(object sender, EventArgs e)
        {
            BlackJack blackJack = new BlackJack(connectedUser, database);
            blackJack.Show();
        }
        private void PokerButton_Click(object sender, EventArgs e)
        {
            PokerForm poker = new PokerForm(connectedUser, database);
            poker.Show();
        }

        private void HigherLowerButton_Click(object sender, EventArgs e)
        {
            HigherLower higher = new HigherLower(connectedUser,database);
            higher.Show();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to our Casino Extravaganza App! Your ultimate destination for virtual casino gaming.\r\n\r\nOur platform offers an exciting array of mini-games, designed to replicate the thrill of a real-life casino. We have Blackjack, Slots, Dices, Higher Lower, Poker Slots, and Flip The Coin games, all at your fingertips.\r\n\r\nGeneral Rules\r\n\r\nBlackjack: The aim is to get a hand with a value as close to 21 as possible, without going over. You're playing against the dealer, not the other players.\r\n\r\nSlots: Spin the reels and if the symbols line up right, you'll win. Each slot machine has its own specific payout table to consult.\r\n\r\nDices: Depending on the specific game you choose, the goal is to predict the outcome of the dice roll. It could be the total number or a range of possible outcomes.\r\n\r\nHigher Lower: In this game, you need to guess whether the next card dealt will be higher or lower than the previous one.\r\n\r\nPoker Slots: This is a mix of slot machine and video poker. Your aim is to create the best 5-card poker hand possible." +
                "\r\n\r\nFlip The Coin: Simply guess whether the coin will land on heads or tails.\r\n\r\nYour success in each of these games will contribute to your total balance, visible on your screen. This balance is virtual currency and used for game purposes only. Remember, gambling should be fun. Always play responsibly and understand that the odds in any casino game are in favor of the house.\r\n\r\nIf you need any assistance or have queries regarding the rules of the game, please feel free to tap on the \"Help\" button at any time. Enjoy your time and may luck be on your side!");

        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter a username and password");
                return;
            }

            IUser user = database.GetUser(username);

            if (user == null)
            {
                MessageBox.Show("User does not exist");
                return;
            }

            connectedUser = new ProxyUser(user);

            if (connectedUser.ValidatePassword(password))
            {
                BlackJackButton.Visible = true;
                CoinFlipButton.Visible = true;
                DicesGameButton.Visible = true;
                HigherLowerButton.Visible = true;
                PokerButton.Visible = true;
                SlotsButton.Visible = true;
                AddMoneyGroupBox.Visible = true;

                LogOutButton.Visible = true;

                UsernameTextBox.Visible = false;
                PasswordTextBox.Visible = false;
                RegisterButton.Visible = false;
                LoginButton.Visible = false;

                UsernameLabel.Visible = false;
                PasswordLabel.Visible = false;
            }
            else
            {
                MessageBox.Show("The password is incorrect");
            }
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            BlackJackButton.Visible = false;
            CoinFlipButton.Visible = false;
            DicesGameButton.Visible = false;
            HigherLowerButton.Visible = false;
            PokerButton.Visible = false;
            SlotsButton.Visible = false;

            LogOutButton.Visible = false;

            UsernameTextBox.Visible = true;
            PasswordTextBox.Visible = true;
            RegisterButton.Visible = true;
            LoginButton.Visible = true;

            UsernameLabel.Visible = true;
            PasswordLabel.Visible = true;
            AddMoneyGroupBox.Visible = false;

            connectedUser = null;

            UsernameTextBox.Text = "";
            PasswordTextBox.Text = "";
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter a username and password");
                return;
            }

            IUser user = database.GetUser(username);
            if (user != null)
            {
                MessageBox.Show("There is a player with this username");
                return;
            }

            ProxyUser proxyUser = new ProxyUser();
            database.CreateUser(username, proxyUser.EncryptPassword(password), "User");
            MessageBox.Show($"The user {username} have been created!");
        }

        private void AddMoneyButton_Click(object sender, EventArgs e)
        {
            if(AddMoneyNumbericUpDown.Value <= 0)
            {
                MessageBox.Show("Please enter a valid amount");
                return;
            }
            database.AddUserBalance(connectedUser.Username, (int)AddMoneyNumbericUpDown.Value);
        }
    }
}

