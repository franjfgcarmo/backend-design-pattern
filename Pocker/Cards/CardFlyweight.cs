using Poker.Cards;

namespace Poker.cards
{
    public class CardFlyweight
    {

        private static CardFlyweight cardFlyweight;

        public static CardFlyweight instance()
        {
            if (cardFlyweight == null)
            {
                cardFlyweight = new CardFlyweight();
            }
            return cardFlyweight;
        }

        private Card[][] cards;

        private CardFlyweight()
        {
            //JAVA TO C# CONVERTER NOTE: The following call to the 'RectangularArrays' helper class reproduces the rectangular array initialization that is automatic in Java:
            //ORIGINAL LINE: cards = new Card[Suite.values().Length][Value.values().Length];
            cards = RectangularArrays.RectangularCardArray(Suite.values().Length, Value.values().Length);
            for (int i = 0; i < Suite.values().Length; i++)
            {
                for (int j = 0; j < Value.values().Length; j++)
                {
                    cards[i][j] = new Card(Value.values()[j], Suite.values()[i]);
                }
            }
        }

        public virtual Card GetCard(Value value, Suite suite)
        {
            return cards[suite.ordinal()][value.ordinal()];
        }

    }

}