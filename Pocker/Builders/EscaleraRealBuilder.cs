using Poker.Cards;

namespace Poker.Builders
{
        internal class EscaleraRealBuilder : Builder
	{

		internal override void FillPlayer()
		{
			Card card = deck.GetCard(Value.DIEZ);
			player.Add(card);
			player.Add(deck.GetCard(card.Value.Next(1), card.Suite));
			player.Add(deck.GetCard(card.Value.Next(2), card.Suite));
			player.Add(deck.GetCard(card.Value.Next(3), card.Suite));
			player.Add(deck.GetCard(card.Value.Next(4), card.Suite));
		}

	}
}