using Poker.Cards;

namespace Poker.Builders
{
    internal class ColorBuilder : Builder
    {

        internal override void FillPlayer()
        {
            Value value = Value.random();
            Card card = deck.GetCard(value);
            player.Add(card);
            player.Add(deck.GetCard(value.next(1), card.Suite));
            player.Add(deck.GetCard(value.next(2), card.Suite));
            player.Add(deck.GetCard(value.next(3), card.Suite));
            player.Add(deck.GetCard(value.next(5), card.Suite));
        }

    }

}