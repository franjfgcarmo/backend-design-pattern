using Poker.Cards;

namespace Poker.Builders
{

    internal class DobleParejaBuilder : Builder
    {

        internal override void FillPlayer()
        {
            Value value = Value.Random();
            player.Add(deck.GetCard(value));
            player.Add(deck.GetCard(value));
            player.Add(deck.GetCard(value.Next(1)));
            player.Add(deck.GetCard(value.Next(1)));
            player.Add(deck.GetCard(value.Next(2)));
        }

    }

}