﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoLobby.CoinFlipGame
{
    internal class FlipperCoin : ICoin
    {
        private readonly List<Image> _coinImages ;
        private Image _imageHead;
        private Image _imageTail;
        private Image _currentImage;
        private string _currentResult;

        public FlipperCoin(List<Image> coinImages, Image imageHead, Image imageTail)
        {
            _coinImages = coinImages;
            _imageHead = imageHead;
            _imageTail = imageTail;
        }

        public List<Image> Flip()
        {
            Random random = new Random();
            int coinSide = random.Next(0, 2); // 0 for heads, 1 for tails

            _currentImage = (coinSide == 0) ? _imageHead : _imageTail;
            _currentResult = (coinSide == 0) ? "Heads" : "Tails";

            List<Image> animatedImages = new List<Image>(_coinImages);
            animatedImages.Add(_currentImage); // Add the final image (head or tail) to the list

            return animatedImages;
        }

        public Image GetImage()
        {
            return _currentImage;
        }

        public string GetResult()
        {
            return _currentResult;
        }
    }
}
