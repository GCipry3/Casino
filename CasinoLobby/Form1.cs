using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoinFlipGame;
using SlotsGame;
using HigherLowerGame;
using DicesGame;
using Users;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Database;

namespace CasinoLobby
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void higherLowerButton_Click(object sender, EventArgs e)
        {
            HigherLower higher = new HigherLower();
            higher.Show();
        }

        private void DicesGameButton_Click(object sender, EventArgs e)
        {
            Dices dices = new Dices();
            dices.Show();
        }

        private void InsertUserButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;
            string role = "Admin";

            IUserDatabase db = new SQLiteUserDatabase();
            db.CreateUser(username, password, role);
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            IUserDatabase db = new SQLiteUserDatabase();
            db.DeleteUser(username);
        }

        private void GetUserInfoButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            IUserDatabase db = new SQLiteUserDatabase();
            IUser user = db.GetUser(username);

            if (user != null)
            {
                UserInfoLabel.Text = $"Username: {user.Username} ;Password: {user.Password} ;Balance: {user.Balance} ;Role: {user.Role}";
            }
            else
            {
                UserInfoLabel.Text = "User not found";
            }
        }

        private void UpdateUserButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;
            string role = RoleTextBox.Text;

            IUserDatabase db = new SQLiteUserDatabase();

            if (username == "") {
                UserInfoLabel.Text = "Username is null";
                return;
            }

            if (password != "")
            {
                db.UpdateUserPassword(username, password);
            }

            if (role != "")
            {
                db.UpdateUserRole(username, role);
            }

            int balance;
            try {
                balance  = int.Parse(BalanceTextBox.Text);
            }
            catch (Exception)
            {
                UserInfoLabel.Text = "Balance is not a number";
                return;
            }

            db.UpdateUserBalance(username, balance);
        }

        private void AddMoneyButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            int amount = int.Parse(AddMoneyTextBox.Text);

            IUserDatabase db = new SQLiteUserDatabase();
            db.AddUserBalance(username, amount);
        }
    }
}
