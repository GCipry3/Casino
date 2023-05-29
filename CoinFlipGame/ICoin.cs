/*
 * Created by: Galbeaza Ciprian
 * 
 * Functionality: 
 * The ICoin interface provides the structure for creating coin objects in the CoinFlip game.
 * It includes methods to flip the coin, get the current coin image, and get the flip result.
 */

using System.Collections.Generic;
using System.Drawing;

namespace CoinFlipGame
{
    public interface ICoin
    {
        // Flips the coin and returns a sequence of images representing the flip animation
        List<Image> Flip();

        // Returns the current image of the coin (head or tail)
        Image GetImage();

        // Returns the result of the coin flip as a string ("Heads" or "Tails")
        string GetResult();
    }
}
