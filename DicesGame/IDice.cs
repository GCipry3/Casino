using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DicesGame
{
    internal enum DiceFaces
    {
        DICE1 = 1,
        DICE2 = 2,
        DICE3 = 3,
        DICE4 = 4,
        DICE5 = 5,
        DICE6 = 6
    }
    internal interface IDice
    {
        List<Image> RollTheDice(); //Rolls the dice
        Image GetImage(); // Return the image for the current face of the dice
        int GetResult(); // Returns the number specific for the current face of the dice
    }
}
