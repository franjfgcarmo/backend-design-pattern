using Poker.Cards;

namespace Poker.cards
{
    public class CardFlyweight
    {

        private static CardFlyweight cardFlyweight;

        public static CardFlyweight Instance()
        {
            if (cardFlyweight == null)
            {
                cardFlyweight = new CardFlyweight();
            }
            return cardFlyweight;
        }

        private readonly Card[,] cards;

        private CardFlyweight()
        {
            cards = new Card[Suite.Values().Length, Value.Values().Length];
            for (int i = 0; i < Suite.Values().Length; i++)
            {
                for (int j = 0; j < Value.Values().Length; j++)
                {
                    cards[i,j] = new Card(Value.Values()[j], Suite.Values()[i]);
                }
            }
        }

        public virtual Card GetCard(Value value, Suite suite)
        {
            return cards[suite.Ordinal(),value.Ordinal];
        }

    }

}