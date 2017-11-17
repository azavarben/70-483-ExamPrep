using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep.Objective._2_1
{
    class Listing210
    {
        internal static void IndexerDemo()
        {
            var deck = new Deck();

            var firstCard = deck[1];

            //vs
            deck.Cards.ElementAt(1);
        }
    }

    public class Deck
    {
        public ICollection<Card> Cards { get; private set; }

        public Card this[int index]
        {
            get
            {
                return Cards.ElementAt(index);
            }
        }
    }

    public class Card
    {

    }
}
