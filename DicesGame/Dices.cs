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
        private int _counter = 0;
        private int _gameWinner;
        private Random _random1;
        private Random _random2;
        private IUser _user;
        private IUserDatabase _database;
        private int _winnings;
        private int _balance;
        private int _bet;

        public Dices()
        {
            InitializeComponent();
            InitVariables();
        }
        public Dices(IUser user, IUserDatabase database)
        {
            InitializeComponent();
            InitVariables();
            this._database = database;
            this._user = user;

            _balance = database.GetUserBalance(user.Username);
            MoneyTextBox.Text = _balance.ToString();
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
            _random1 = new Random(123);
            _random2 = new Random(345);
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
            _counter++;
            if (_counter == 5)
            {
                timerHouseRoll.Stop();
                _dices[0].RollTheDice(_random1);
                _dices[1].RollTheDice(_random2);
                ShooterDice1.Image = _dices[0].GetImage();
                ShooterDice2.Image = _dices[1].GetImage();
                if(_roundNumber % 2 ==0)
                {
                    PlayGameButton.Enabled = true;
                    _gameWinner = _gameRule.GetWinner(_dices[0].GetResult() + _dices[1].GetResult(), _dices[2].GetResult() + _dices[3].GetResult());
                    ChooseWinner(_gameWinner);
                    _roundNumber++;
                    ChangeGameRuleButton.Enabled = true;
                    BetNumericUpDown.Enabled = true;
                }
                else
                {
                    FaderRollButton.Enabled = true;
                    PlayerTurnLabel.Text = "Fader's turn to roll!";
                }
                _counter = 0;
            }
            else
            { 
                _dices[0].GenerateRandomFace(_random1);
                ShooterDice1.Image = _dices[0].GetImage();
                _dices[1].GenerateRandomFace(_random2);
                ShooterDice2.Image = _dices[1].GetImage();
            }
        }

        //handles winnings and labels
        private void ChooseWinner(int option)
        {
            _bet = (int)BetNumericUpDown.Value;
            if (_balance < _bet)
            {
                _bet = 0;
                MessageBox.Show("Your bet cannot be bigger than your balance!");
            }

            switch (option)
            {
                case 0:
                    GameWinnerLabel.Text = "Draw";
                    break;
                case 1:
                    GameWinnerLabel.Text = "Fader wins";

                    _winnings = (int)(BetNumericUpDown.Value);
                    _database.AddUserBalance(_user.Username, _winnings);
                    _balance = _database.GetUserBalance(_user.Username);
                    MoneyTextBox.Text = _balance.ToString();

                    WinningsTextBox.Text = _winnings.ToString();

                    break;

                case 2:
                    GameWinnerLabel.Text = "House wins";
                    _winnings = 0;

                    _database.AddUserBalance(_user.Username, (int)-BetNumericUpDown.Value);
                    _balance = _database.GetUserBalance(_user.Username);
                    MoneyTextBox.Text = _balance.ToString();
                    WinningsTextBox.Text = _winnings.ToString();
                    break;
                default:
                    break;
            }
        }

        //add animation to fader's roll and checks winner if uneven
        private void timerFaderRoll_Tick(object sender, EventArgs e)
        {
            _counter++;
            if (_counter == 5)
            {
                timerFaderRoll.Stop();
                _dices[2].RollTheDice(_random1);
                _dices[3].RollTheDice(_random2);
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
                    _gameWinner = _gameRule.GetWinner(_dices[0].GetResult() + _dices[1].GetResult(), _dices[2].GetResult() + _dices[3].GetResult());
                    ChooseWinner(_gameWinner);
                    _roundNumber++;
                    ChangeGameRuleButton.Enabled = true;
                    BetNumericUpDown.Enabled = true;
                }
                _counter = 0;
            }
            else
            {
                _dices[2].GenerateRandomFace(_random1);
                FaderDice1.Image = _dices[2].GetImage();
                _dices[3].GenerateRandomFace(_random2);
                FaderDice2.Image = _dices[3].GetImage();
            }
        }

        //if even round after the house roll waits 5 ticks and then starts the animation for fader's roll
        private void timerHouseAfterFaderRoll_Tick(object sender, EventArgs e)
        {
            _counter++;
            if (_counter == 5)
            {
                timerHouseAfterFaderRoll.Stop();
                timerHouseRoll.Enabled = true;
                _counter = 0;
                return;
            }
        }
    }
}
