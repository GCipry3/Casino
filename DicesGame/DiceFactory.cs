/*
 * Created by: Farcas Cosmin Catalin
 *
 * Functionality: The DiceFactory class is a factory design pattern implementation that creates 
 *                a dice object with appropriate images for each face of the dice. It currently 
 *                only supports one default type of dice, but the design allows for easily adding 
 *                different types of dices in the future.
 *
*/
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
        // Variable to hold the type of dice to create.
        public string _diceType;
        public DiceFactory(string diceType)
        {
            _diceType = diceType;
        }

        /// <summary>
        /// Creates a dice object with appropriate images for each face, 
        /// based on the type of dice requested.
        /// </summary>
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
