using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DicesGame
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
                Resources.ResourceManager.GetImage("Resources.Resources.Dice1.png"),
                Resources.ResourceManager.GetImage("Resources.Resources.Dice2.png"),
                Resources.ResourceManager.GetImage("Resources.Resources.Dice3.png"),
                Resources.ResourceManager.GetImage("Resources.Resources.Dice4.png"),
                Resources.ResourceManager.GetImage("Resources.Resources.Dice5.png"),
                Resources.ResourceManager.GetImage("Resources.Resources.Dice6.png")
            };
            switch (_diceType)
            {
                case "MockDice":
                    return new MockDice(images, throwerType);
                default:
                    return new MockDice(images, throwerType);
            }
        }
    }
}
