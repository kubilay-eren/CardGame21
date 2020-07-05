using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame21
{
    public class Card
    {
        public CardType? CardType { get; set; }
        public Game? Games { get; set; }

        public int CardValue()
        {
            int value = 0;

            switch (this.Games)
            {
                case Game.Jack:
                    value = 11;
                    break;
                default:
                    int.TryParse(this.Games.ToString(), out value);
                    break;
            }
            return value;
        }
    }
}
