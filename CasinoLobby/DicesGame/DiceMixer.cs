using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CasinoLobby.DicesGame
{
    internal class DiceMixer : IDice
    {
        private List<Image> _diceFaces;
        private Image _currentDiceFace;
        private int _currentFaceIndex;
        private string _diceThrower;

        public DiceMixer(List<Image> diceFaces, string diceThrower)
        {
            _diceFaces = diceFaces;
            _diceThrower = diceThrower;
        }
        Image IDice.GetImage()
        {
            return _currentDiceFace;
        }

        int IDice.GetResult()
        {
            return _currentFaceIndex;
        }

        List<Image> IDice.RollTheDice()
        {
            Random random = new Random();
            int diceFace = random.Next(1, 7);

            _currentDiceFace = _diceFaces[diceFace - 1];
            _currentFaceIndex = diceFace;

            return new List<Image> { _currentDiceFace };
        }
    }
}