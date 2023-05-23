using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CasinoLobby.CoinFlipGame;
using CasinoLobby.DicesGame;

namespace CasinoLobby
{
    public partial class Dices : Form
    {
        private List<IDice> _dices;
        private List<Image> _diceFaceImages;
        private IDiceFactory _factory;
        private GameRule _gameRule;

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
            Random random = new Random();

        }

        private void HouseRollButton_Click(object sender, EventArgs e)
        {
            // roll the House's dice and calculate the result
            _dices[0].RollTheDice(); 
            _dices[1].RollTheDice();
            int rollResult = _dices[0].GetResult() + _dices[1].GetResult();
            _gameRule.SetGameRule(rollResult);
            GameRuleLabel.Text = _gameRule.CurrentRule;
        }
    }
}
