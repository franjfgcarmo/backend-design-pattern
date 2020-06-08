using Poker.Cards;

namespace Poker.Builders
{
    internal class TrioBuilder : Builder
	{

		internal override void FillPlayer()
		{
			Value value = Value.random();
			Card card = deck.GetCard(value);
            player.Add(card);
			player.Add(deck.GetCard(value));
			player.Add(deck.GetCard(value));
			player.Add(deck.GetCard(value.next(1), card.Suite.next(1)));
			player.Add(deck.GetCard(value.next(2)));
		}

	}

}