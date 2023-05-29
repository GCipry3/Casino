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
            CoinFlip coinFlip = new CoinFlip();  // Initialize the form
            coinFlip.Show();  // Show the form
        }

        private void SlotsButton_Click(object sender, EventArgs e)
        {
            Slots slots = new Slots();
            slots.Show();
        }

        private void DicesGameButton_Click(object sender, EventArgs e)
        {
            Dices dices = new Dices();
            dices.Show();
        }

        private void BlackJackButton_Click(object sender, EventArgs e)
        {
            BlackJack blackJack = new BlackJack();
            blackJack.Show();
        }
        private void PokerButton_Click(object sender, EventArgs e)
        {
            PokerForm poker = new PokerForm();
            poker.Show();
        }

        private void HigherLowerButton_Click(object sender, EventArgs e)
        {
            HigherLower higher = new HigherLower();
            higher.Show();
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
            
            if(user == null)
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
            database.CreateUser(username,proxyUser.EncryptPassword(password),"User");
            MessageBox.Show($"The user {username} have been created!");
        }
    }
}
