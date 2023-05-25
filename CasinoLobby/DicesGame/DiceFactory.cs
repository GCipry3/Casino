using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CasinoLobby.DicesGame
{
    internal class DiceFactory : IDiceFactory
    {
        private string _diceType;
        public DiceFactory(string diceType)
        {
            _diceType = diceType;
        }

        public IDice CreateDice(string throwerType)
        {
            List<Image> images = new List<Image>(){
                Properties.Resources.Dice1,
                Properties.Resources.Dice2,
                Properties.Resources.Dice3,
                Properties.Resources.Dice4,
                Properties.Resources.Dice5,
                Properties.Resources.Dice6
            };
            switch(_diceType)
            {
                case "MockDice":
                    return new MockDice(images, throwerType);
                default:
                    return new MockDice(images, throwerType);
            }
        }
    }
}