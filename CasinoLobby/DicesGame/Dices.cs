using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasinoLobby.DicesGame
{
    public partial class Dices : Form
    {
        private List<IDice> _dices;
        private List<Image> _diceFaceImages;
        private IDiceFactory _factory;
        private GameRule _gameRule;
        private int _roundNumber = 0;
        private int counter = 0;

        public Dices()
        {
            InitializeComponent();
            _dices = new List<IDice>();
            _factory = new DiceFactory("MockDice");
            _dices.Add(_factory.CreateDice("Shooter"));
            _dices.Add(_factory.CreateDice("Shooter"));
            _dices.Add(_factory.CreateDice("Fader"));
            _dices.Add(_factory.CreateDice("Fader"));

            Random random = new Random();

        }

        private void ChangeGameRuleButton_Click(object sender, EventArgs e)
        {
            _gameRule.ChangeGameRule();
            GameRuleLabel.Text = _gameRule.CurrentRule;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            _roundNumber++;
            if(_roundNumber % 2 ==1)
            {
                timer1.Enabled = true;
                PlayerTurnLabel.Text = "House's turn to roll";
            }
            else
            {
                PlayerTurnLabel.Text = "Fader's turn to roll";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter == 10)
            {
                _dices[0].RollTheDice();
                _dices[1].RollTheDice();
                timer1.Enabled = true;
                counter = 0;
            }
        }
    }
}
