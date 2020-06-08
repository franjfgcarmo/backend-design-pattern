using Poker.Cards;
using Poker.Players;

namespace Poker.Builders
{
    internal abstract class Builder
    {

        protected internal Deck deck;

        protected internal Player player;

        internal virtual Player Build()
        {
            deck = new Deck();
            player = new Player();
            FillPlayer();
            return player;
        }

        internal abstract void FillPlayer();
    }

}