using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DicesGame
{
    public partial class Dices : Form
    {
        private List<IDice> _dices;
        private List<Image> _diceFaceImages;
        private IDiceFactory _factory;
        private GameRule _gameRule;
        private int _roundNumber = 1;
        private int counter = 0;
        private int gameWinner;
        private Random random1;
        private Random random2;

        public Dices()
        {
            InitializeComponent();
            _dices = new List<IDice>();
            _factory = new DiceFactory("MockDice");
            _dices.Add(_factory.CreateDice("Shooter"));
            _dices.Add(_factory.CreateDice("Shooter"));
            _dices.Add(_factory.CreateDice("Fader"));
            _dices.Add(_factory.CreateDice("Fader"));
            _gameRule = new GameRule();
            random1 = new Random(123);
            random2 = new Random(345);
        }

        private void ChangeGameRuleButton_Click(object sender, EventArgs e)
        {
            _gameRule.ChangeGameRule();
            GameRuleLabel.Text = _gameRule.CurrentRule;
        }
      
        private void PlayGameButton_Click(object sender, EventArgs e)
        {
            PlayGameButton.Enabled = false;
            ChangeGameRuleButton.Enabled = false;
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

        private void FaderRollButton_Click(object sender, EventArgs e)
        {
            FaderRollButton.Enabled = false;
            timerFaderRoll.Enabled = true;
        }

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
                    if(gameWinner == 0)
                    {
                        GameWinnerLabel.Text = "Draw";
                    }
                    else if(gameWinner == 1)
                    {
                        GameWinnerLabel.Text = "Fader wins";
                    }
                    else
                    {
                        GameWinnerLabel.Text = "House wins";
                    }
                    _roundNumber++;
                    ChangeGameRuleButton.Enabled = true;
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
                    if (gameWinner == 0)
                    {
                        GameWinnerLabel.Text = "Draw";
                    }
                    else if (gameWinner == 1)
                    {
                        GameWinnerLabel.Text = "Fader wins";
                    }
                    else
                    {
                        GameWinnerLabel.Text = "House wins";
                    }
                    _roundNumber++;
                    ChangeGameRuleButton.Enabled = true;
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

        private void timerHouseAfterFaderRoll_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter == 5)
            {
                timerHouseAfterFaderRoll.Stop();
                timerHouseRoll.Enabled = true;
                counter = 0;
            }
            
        }
    }
}
