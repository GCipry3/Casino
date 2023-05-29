using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Resources;

namespace BlackJackGame
{
    public class BlackJackDeck
    {
        private Dictionary<string, Image> _oneDeckImages;
        private Dictionary<string, Image> _fourDecksImages;
        private Image _faceDownCard = ResourceManager.GetImage("Resources.Resources.cardBack.png");
        private Image _secondDealerCard;
        public BlackJackDeck() {
            _oneDeckImages = new Dictionary<string, Image>()
            {
                { "trefla_02", ResourceManager.GetImage("Resources.Resources.2trefla.jpg")},
                { "romb_02", ResourceManager.GetImage("Resources.Resources.2romb.jpg")},
                { "frunza_02", ResourceManager.GetImage("Resources.Resources.2frunza.jpg")},
                { "inima_02", ResourceManager.GetImage("Resources.Resources.2inima.jpg")},
                { "trefla_03", ResourceManager.GetImage("Resources.Resources.3trefla.jpg")},
                { "romb_03", ResourceManager.GetImage("Resources.Resources.3romb.jpg")},
                { "frunza_03", ResourceManager.GetImage("Resources.Resources.3frunza.jpg")},
                { "inima_03", ResourceManager.GetImage("Resources.Resources.3inima.jpg")},
                { "trefla_04", ResourceManager.GetImage("Resources.Resources.4trefla.jpg")},
                { "romb_04", ResourceManager.GetImage("Resources.Resources.4romb.jpg")},
                { "frunza_04", ResourceManager.GetImage("Resources.Resources.4frunza.jpg")},
                { "inima_04", ResourceManager.GetImage("Resources.Resources.4inima.jpg")},
                { "trefla_05", ResourceManager.GetImage("Resources.Resources.5trefla.jpg")},
                { "romb_05", ResourceManager.GetImage("Resources.Resources.5romb.jpg")},
                { "frunza_05", ResourceManager.GetImage("Resources.Resources.5frunza.jpg")},
                { "inima_05", ResourceManager.GetImage("Resources.Resources.5inima.jpg")},
                { "trefla_06", ResourceManager.GetImage("Resources.Resources.6trefla.jpg")},
                { "romb_06", ResourceManager.GetImage("Resources.Resources.6romb.jpg")},
                { "frunza_06", ResourceManager.GetImage("Resources.Resources.6frunza.jpg")},
                { "inima_06", ResourceManager.GetImage("Resources.Resources.6inima.jpg")},
                { "trefla_07", ResourceManager.GetImage("Resources.Resources.7trefla.jpg")},
                { "romb_07", ResourceManager.GetImage("Resources.Resources.7romb.jpg")},
                { "frunza_07", ResourceManager.GetImage("Resources.Resources.7frunza.jpg")},
                { "inima_07", ResourceManager.GetImage("Resources.Resources.7inima.jpg")},
                { "trefla_08", ResourceManager.GetImage("Resources.Resources.8trefla.jpg")},
                { "romb_08", ResourceManager.GetImage("Resources.Resources.8romb.jpg")},
                { "frunza_08", ResourceManager.GetImage("Resources.Resources.8frunza.jpg")},
                { "inima_08", ResourceManager.GetImage("Resources.Resources.8inima.jpg")},
                { "trefla_09", ResourceManager.GetImage("Resources.Resources.9trefla.jpg")},
                { "romb_09", ResourceManager.GetImage("Resources.Resources.9romb.jpg")},
                { "frunza_09", ResourceManager.GetImage("Resources.Resources.9frunza.jpg")},
                { "inima_09", ResourceManager.GetImage("Resources.Resources.9inima.jpg")},
                { "trefla_10", ResourceManager.GetImage("Resources.Resources.10trefla.jpg")},
                { "romb_10", ResourceManager.GetImage("Resources.Resources.10romb.jpg")},
                { "frunza_10", ResourceManager.GetImage("Resources.Resources.10frunza.jpg")},
                { "inima_10", ResourceManager.GetImage("Resources.Resources.10inima.jpg")},
                { "trefla_11", ResourceManager.GetImage("Resources.Resources.atrefla.jpg")},
                { "romb_11", ResourceManager.GetImage("Resources.Resources.aromb.jpg")},
                { "frunza_11", ResourceManager.GetImage("Resources.Resources.afrunza.jpg")},
                { "inima_11", ResourceManager.GetImage("Resources.Resources.ainima.jpg")},
                { "trefla_12", ResourceManager.GetImage("Resources.Resources.jtrefla.jpg")},
                { "romb_12", ResourceManager.GetImage("Resources.Resources.jromb.jpg")},
                { "frunza_12", ResourceManager.GetImage("Resources.Resources.jfrunza.jpg")},
                { "inima_12", ResourceManager.GetImage("Resources.Resources.jinima.jpg")},
                { "trefla_13", ResourceManager.GetImage("Resources.Resources.qtrefla.jpg")},
                { "romb_13", ResourceManager.GetImage("Resources.Resources.qromb.jpg")},
                { "frunza_13", ResourceManager.GetImage("Resources.Resources.qfrunza.jpg")},
                { "inima_13", ResourceManager.GetImage("Resources.Resources.qinima.jpg")},
                { "trefla_14", ResourceManager.GetImage("Resources.Resources.ktrefla.jpg")},
                { "romb_14", ResourceManager.GetImage("Resources.Resources.kromb.jpg")},
                { "frunza_14", ResourceManager.GetImage("Resources.Resources.kfrunza.jpg")},
                { "inima_14", ResourceManager.GetImage("Resources.Resources.kinima.jpg")}
            };
            _fourDecksImages = new Dictionary<string, Image>();
            //creates deck containing 208 cards ( 4 normal decks)
            for(int deckNum = 1; deckNum <= 4; deckNum++)
            {
                foreach(var card in _oneDeckImages)
                {
                    _fourDecksImages.Add($"{deckNum}#{card.Key}", card.Value);
                }
            }
        }
        private void Reshuffle()
        {
            _fourDecksImages.Clear();
            for (int deckNum = 1; deckNum <= 4; deckNum++)
            {
                foreach (var card in _oneDeckImages)
                {
                    _fourDecksImages.Add($"{deckNum}#{card.Key}", card.Value);
                }
            }
        }
        public (string,Image) DealCard()
        {
            Random random = new Random();

            // Check if _fourDecksImages has less than 2 decks left
            if (_fourDecksImages.Count < 104)
            {
                // Call your reshuffle method here
                Reshuffle();
            }
            //retunr a random pair of key and image and deletes it from the deck
            var randomCardKey = _fourDecksImages.Keys.ElementAt(random.Next(0, _fourDecksImages.Count));
            var cardImage = _fourDecksImages[randomCardKey];
            _fourDecksImages.Remove(randomCardKey);
            return (randomCardKey,cardImage);
        }

        //deals dealer card and places it in the center after the previous one 
        public PictureBox DisplayDealerCard(string cardKey,Image cardImage, Panel panel, int cardCount)
        {
            string[] parts = cardKey.Split('_');
            string cardValue = parts[1];

            int cardWidth = panel.Width / 16;
            int cardHeight = 150;

            PictureBox pictureBox = new PictureBox
            {
                Width = cardWidth,
                Height = cardHeight,
                Anchor = AnchorStyles.None,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Name = cardValue
            };
            if(cardCount==1)
            {
                pictureBox.Image = _faceDownCard;
                _secondDealerCard = cardImage;
            }
            else
            {
                pictureBox.Image = cardImage;
            }
            
            int totalCardWidth = cardCount * 2*cardWidth + cardWidth;
            int offsetX = (1300 - totalCardWidth) / 2;


            pictureBox.Left = offsetX + cardCount * 2 * cardWidth;
            pictureBox.Top = (panel.Height - cardHeight) / 2;

            panel.Controls.Add(pictureBox);

            return pictureBox;
        }

        //deals player card and by using flowlayoutpanel it automatically places it joined by the previous one
        public PictureBox DisplayPlayerCard(string cardKey, Image cardImage, FlowLayoutPanel panel)
        {
            string[] parts = cardKey.Split('_');
            string cardValue = parts[1];

            PictureBox pictureBox = new PictureBox
            {
                Image = cardImage,
                Width = panel.Width / 8,
                Height = 150,
                Anchor = AnchorStyles.None,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Name = cardValue
            };

            int topBottomMargin = (panel.Height - pictureBox.Height) / 2;
            pictureBox.Margin = new Padding(0, topBottomMargin, 0, topBottomMargin);

            panel.Controls.Add(pictureBox);

            return pictureBox;
        }

        //reveals dealer second card when player hand in handled
        public void RevealCard(PictureBox secondCard)
        {
            secondCard.Image = _secondDealerCard;
        }

    }
}
