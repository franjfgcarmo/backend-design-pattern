using Poker.Cards;

namespace Poker.Builders
{

    internal class DobleParejaBuilder : Builder
    {

        internal override void FillPlayer()
        {
            Value value = Value.random();
            player.Add(deck.GetCard(value));
            player.Add(deck.GetCard(value));
            player.Add(deck.GetCard(value.next(1)));
            player.Add(deck.GetCard(value.next(1)));
            player.Add(deck.GetCard(value.next(2)));
        }

    }

}