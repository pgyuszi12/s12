using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solitaire
{
    class Card
    {

        public static int NUMBER_OF_COLORS = 4;
        public static int NUMBER_OF_VALUES = 13;

        static String[] Colors = { "spade", "diamond", "heart", "club" };

        // The card is visible or not. If false we show the card cover.
        public bool visible { get; set; } = false;

        // Color of the card from { hearts, diamonds, clubs, spades }
        String color;

        // Value is from 1 to 13. Ace 2 3 4.. 9 10 J Q K
        int value;
            
        public void printCard()
        {
            Console.WriteLine("Color is:" + this.color + " Value: " + this.value + " Visible: " + visible);
        }

        public void flipCard()
        {
            visible = true;
        }

        public Card(int color, int value) {
            this.color = Colors[color];
            this.value = value;
        }

        

    }
}
