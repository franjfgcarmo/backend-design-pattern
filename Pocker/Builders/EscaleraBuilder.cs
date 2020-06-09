using Poker.Cards;

namespace Poker.Builders
{

    internal class EscaleraBuilder : Builder
	{

		internal override void FillPlayer()
		{
			Value value = Value.Random(Value.NUEVE);
			Card card = deck.GetCard(value);
			player.Add(card);
			player.Add(deck.GetCard(value.Next(1), card.Suite.Next(1)));
			player.Add(deck.GetCard(value.Next(2)));
			player.Add(deck.GetCard(value.Next(3)));
			player.Add(deck.GetCard(value.Next(4)));
		}

	}

}