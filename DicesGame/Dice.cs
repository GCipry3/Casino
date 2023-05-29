using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DicesGame
{
    internal class Dice : IDice
    {
        private List<Image> _diceFaces;
        private Image _currentDiceFace;
        private int _currentFaceIndex;

        public Dice(List<Image> diceFaces)
        {
            _diceFaces = diceFaces;
        }

        //returns current image
        public Image GetImage()
        {
            return _currentDiceFace;
        }

        //returns value of dice
        public int GetResult()
        {
            return _currentFaceIndex;
        }
    
        public void RollTheDice(Random random)
        {
            int diceFace = random.Next(1, 7);

            _currentDiceFace = _diceFaces[diceFace - 1];
            _currentFaceIndex = diceFace;
        }

        //generates random face for the animation
        public void GenerateRandomFace(Random random)
        {
           _currentDiceFace = _diceFaces[random.Next(0, 6)];
        }
    }
}
