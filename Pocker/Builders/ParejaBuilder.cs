using Poker.Cards;

namespace Poker.Builders
{
    internal class ParejaBuilder : Builder
	{

		internal override void FillPlayer()
		{
			Value value = Value.random();
			Card card = deck.GetCard(value);
			player.add(card);
			player.Add(deck.GetCard(value));
			player.Add(deck.GetCard(value.next(1), card.Suite.next(1)));
			player.Add(deck.GetCard(value.next(2)));
			player.Add(deck.GetCard(value.next(3)));
		}
	}

}