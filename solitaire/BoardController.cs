using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace solitaire
{
    class BoardController
    {

        private static int NUMBER_OF_COLUMNS = 7;

        List<Card> drawingCards = new List<Card>();

        List<Card> foundationHeartCards = new List<Card>();
        List<Card> foundationClubCards = new List<Card>();
        List<Card> foundationDiamondCards = new List<Card>();
        List<Card> foundationSpadeCards = new List<Card>();

        List<List<Card>> columnCards = new List<List<Card>>();

        public BoardController()
        {
            initialize();
        }

        public void startNewGame()
        {
            initialize();
        }

        private void initialize()
        {
            clearBoard();
            generateCards();
            shuffleCards();
            dealCards();
            flipTopCards();
            printColumns();
        }

        private void clearBoard()
        {
            drawingCards.Clear();
            foundationClubCards.Clear();
            foundationDiamondCards.Clear();
            foundationHeartCards.Clear();
            foundationSpadeCards.Clear();
            columnCards = new List<List<Card>>();
            createColumns();
        }

        private void createColumns()
        {
            for(int i = 0; i < NUMBER_OF_COLUMNS; i++)
            {
                columnCards.Add(new List<Card>());
            }
        }

        private void dealCards()
        {
            for (int i = 0; i < NUMBER_OF_COLUMNS; i++)
            {
                for (int j = i; j < NUMBER_OF_COLUMNS; j++)
                {
                    columnCards[j].Add(drawingCards[drawingCards.Count - 1]);
                    drawingCards.RemoveAt(drawingCards.Count - 1);
                }
            }
          
        }

        private void printColumns()
        {
            for(int i = 0; i < columnCards.Count; i++)
            {
                Console.WriteLine("Column is: " + (i + 1));
                foreach(Card card in columnCards[i])
                {
                    card.printCard();
                }
            }
        }

        private void flipTopCards()
        {
            foreach(List<Card> cards in columnCards)
            {
                cards[cards.Count - 1].flipCard();
            }
        }

        private void generateCards()
        {
            for (int color = 0; color < Card.NUMBER_OF_COLORS; color++)
            {
                for (int value = 0; value < Card.NUMBER_OF_VALUES; value++)
                {
                    generateCard(color, value + 1);
                }

            }
        }

        private void generateCard(int color, int value)
        {
            Card card = new Card(color, value);
            drawingCards.Add(card);

        
        }


        private void shuffleCards()
        {
            var rnd = new Random();
            drawingCards = drawingCards.OrderBy(c => rnd.Next()).ToList();
        }


    }
}
