﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DicesGame
{
    public interface IDice
    {
        void RollTheDice(Random random); //Rolls the dice
        Image GetImage(); // Return the image for the current face of the dice
        int GetResult(); // Returns the number specific for the current face of the dice

        void GenerateRandomFace(Random random);
    }
}
