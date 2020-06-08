using Poker.Cards;

namespace Poker.Builders
{
    internal class PoquerBuilder : Builder
	{

		internal override void FillPlayer()
		{
			Value value = Value.random();
			player.Add(deck.GetCard(value));
			player.Add(deck.GetCard(value));
			player.Add(deck.GetCard(value));
			player.Add(deck.GetCard(value));
			player.Add(deck.Card);
		}
	}

}