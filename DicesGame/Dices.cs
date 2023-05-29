using Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Users;

namespace DicesGame
{
    public partial class Dices : Form
    {
        private List<IDice> _dices;
        private IDiceFactory _factory;
        private GameRule _gameRule;
        private int _roundNumber = 1;
        private int counter = 0;
        private int gameWinner;
        private Random random1;
        private Random random2;
        IUser user;
        IUserDatabase database;
        int winnings;
        int balance;
        int bet;

        public Dices()
        {
            InitializeComponent();
            InitVariables();
        }
        public Dices(IUser user, IUserDatabase database)
        {
            InitializeComponent();
            InitVariables();
            this.database = database;
            this.user = user;

            balance = database.GetUserBalance(user.Username);
            MoneyTextBox.Text = balance.ToString();
        }

        private void InitVariables()
        {
            _dices = new List<IDice>();
            _factory = new DiceFactory("Dice");
            //creates the 4 dices
            _dices.AddRange(new List<IDice>
            {
                _factory.CreateDice(),
                _factory.CreateDice(),
                _factory.CreateDice(),
                _factory.CreateDice()
            });
            _gameRule = new GameRule();
            random1 = new Random(123);
            random2 = new Random(345);
            GameRuleLabel.Text = _gameRule.CurrentRule;
        }
        private void ChangeGameRuleButton_Click(object sender, EventArgs e)
        {
            _gameRule.ChangeGameRule();
            GameRuleLabel.Text = _gameRule.CurrentRule;
        }
      
        //checks if its even or uneven turn and handles the button and label
        private void PlayGameButton_Click(object sender, EventArgs e)
        {
            PlayGameButton.Enabled = false;
            ChangeGameRuleButton.Enabled = false;
            BetNumericUpDown.Enabled = false;
            if (_roundNumber % 2 == 1)
            { 
                FaderRollButton.Enabled = false;
                PlayerTurnLabel.Text = "House's turn to roll!";
                timerHouseRoll.Enabled = true;
            }
            else
            {
                FaderRollButton.Enabled = true;
                PlayerTurnLabel.Text = "Fader's turn to roll!";
            }
        }

        //fader roll button
        private void FaderRollButton_Click(object sender, EventArgs e)
        {
            FaderRollButton.Enabled = false;
            timerFaderRoll.Enabled = true;
        }
        //animation for the dices and checks winner if round even
        private void timerHouseRoll_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter == 5)
            {
                timerHouseRoll.Stop();
                _dices[0].RollTheDice(random1);
                _dices[1].RollTheDice(random2);
                ShooterDice1.Image = _dices[0].GetImage();
                ShooterDice2.Image = _dices[1].GetImage();
                if(_roundNumber % 2 ==0)
                {
                    PlayGameButton.Enabled = true;
                    gameWinner = _gameRule.GetWinner(_dices[0].GetResult() + _dices[1].GetResult(), _dices[2].GetResult() + _dices[3].GetResult());
                    ChooseWinner(gameWinner);
                    _roundNumber++;
                    ChangeGameRuleButton.Enabled = true;
                    BetNumericUpDown.Enabled = true;
                }
                else
                {
                    FaderRollButton.Enabled = true;
                    PlayerTurnLabel.Text = "Fader's turn to roll!";
                }
                counter = 0;
            }
            else
            { 
                _dices[0].GenerateRandomFace(random1);
                ShooterDice1.Image = _dices[0].GetImage();
                _dices[1].GenerateRandomFace(random2);
                ShooterDice2.Image = _dices[1].GetImage();
            }
        }

        //handles winnings and labels
        private void ChooseWinner(int option)
        {
            bet = (int)BetNumericUpDown.Value;
            if (balance < bet)
            {
                bet = 0;
                MessageBox.Show("Your bet cannot be bigger than your balance!");
            }

            switch (option)
            {
                case 0:
                    GameWinnerLabel.Text = "Draw";
                    break;
                case 1:
                    GameWinnerLabel.Text = "Fader wins";
                    
                    winnings = (int)(BetNumericUpDown.Value);
                    database.AddUserBalance(user.Username, winnings);
                    balance = database.GetUserBalance(user.Username);
                    MoneyTextBox.Text = balance.ToString();

                    WinningsTextBox.Text = winnings.ToString();

                    break;

                case 2:
                    GameWinnerLabel.Text = "House wins";
                    winnings = 0;

                    database.AddUserBalance(user.Username, (int)-BetNumericUpDown.Value);
                    balance = database.GetUserBalance(user.Username);
                    MoneyTextBox.Text = balance.ToString();
                    WinningsTextBox.Text = winnings.ToString();
                    break;
                default:
                    break;
            }
        }

        //add animation to fader's roll and checks winner if uneven
        private void timerFaderRoll_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter == 5)
            {
                timerFaderRoll.Stop();
                _dices[2].RollTheDice(random1);
                _dices[3].RollTheDice(random2);
                FaderDice1.Image = _dices[2].GetImage();
                FaderDice2.Image = _dices[3].GetImage();
                if (_roundNumber % 2 == 0)
                {
                    timerHouseAfterFaderRoll.Enabled = true;
                    PlayerTurnLabel.Text = "House's turn to roll!";
                }
                else
                {
                    PlayGameButton.Enabled = true;
                    gameWinner = _gameRule.GetWinner(_dices[0].GetResult() + _dices[1].GetResult(), _dices[2].GetResult() + _dices[3].GetResult());
                    ChooseWinner(gameWinner);
                    _roundNumber++;
                    ChangeGameRuleButton.Enabled = true;
                    BetNumericUpDown.Enabled = true;
                }
                counter = 0;
            }
            else
            {
                _dices[2].GenerateRandomFace(random1);
                FaderDice1.Image = _dices[2].GetImage();
                _dices[3].GenerateRandomFace(random2);
                FaderDice2.Image = _dices[3].GetImage();
            }
        }

        //if even round after the house roll waits 5 ticks and then starts the animation for fader's roll
        private void timerHouseAfterFaderRoll_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter == 5)
            {
                timerHouseAfterFaderRoll.Stop();
                timerHouseRoll.Enabled = true;
                counter = 0;
                return;
            }
        }
    }
}
