using Poker.Cards;

namespace Poker.Builders
{

    internal class EscaleraBuilder : Builder
	{

		internal override void FillPlayer()
		{
			Value value = Value.random(Value.NUEVE);
			Card card = deck.GetCard(value);
			player.Add(card);
			player.Add(deck.GetCard(value.next(1), card.Suite.next(1)));
			player.Add(deck.GetCard(value.next(2)));
			player.Add(deck.GetCard(value.next(3)));
			player.Add(deck.GetCard(value.next(4)));
		}

	}

}