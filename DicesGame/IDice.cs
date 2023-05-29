/*
 * Created by: Farcas Cosmin Catalin 
 *
 * Functionality: This interface represents a dice in a dice game. It includes methods 
 * for rolling the dice, getting the image for the current face of the dice, 
 * getting the result (number) of the current face of the dice, and generating a random face for the dice.
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
    /// <summary>
    /// Represents a dice in a dice game.
    /// </summary>
    public interface IDice
    {
        /// <summary>
        /// Rolls the dice, changing its face to a new random one.
        /// </summary>
        /// <param name="random">An instance of Random for generating random numbers.</param>
        void RollTheDice(Random random);

        /// <summary>
        /// Returns the image for the current face of the dice.
        /// </summary>
        /// <returns>An Image object representing the current face of the dice.</returns>
        Image GetImage();

        /// <summary>
        /// Returns the number associated with the current face of the dice.
        /// </summary>
        /// <returns>An integer representing the current dice number.</returns>
        int GetResult();

        /// <summary>
        /// Generates a new random face for the dice.
        /// </summary>
        /// <param name="random">An instance of Random for generating random numbers.</param>
        void GenerateRandomFace(Random random);
    }
}
