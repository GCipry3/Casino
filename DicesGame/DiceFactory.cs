using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DicesGame
{
    public class DiceFactory : IDiceFactory
    {
        public string _diceType;
        public DiceFactory(string diceType)
        {
            _diceType = diceType;
        }

        public IDice CreateDice()
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
                default:
                    return new Dice(images);
            }
        }
    }
}
