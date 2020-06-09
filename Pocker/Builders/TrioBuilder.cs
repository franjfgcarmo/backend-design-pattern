using Poker.Cards;

namespace Poker.Builders
{
    internal class TrioBuilder : Builder
	{

		internal override void FillPlayer()
		{
			Value value = Value.Random();
			Card card = deck.GetCard(value);
            player.Add(card);
			player.Add(deck.GetCard(value));
			player.Add(deck.GetCard(value));
			player.Add(deck.GetCard(value.Next(1), card.Suite.Next(1)));
			player.Add(deck.GetCard(value.Next(2)));
		}

	}

}