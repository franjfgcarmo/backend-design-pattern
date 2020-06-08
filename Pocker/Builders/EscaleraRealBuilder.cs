using Poker.Cards;

namespace Poker.Builders
{
        internal class EscaleraRealBuilder : Builder
	{

		internal override void FillPlayer()
		{
			Card card = deck.GetCard(Value.DIEZ);
			player.Add(card);
			player.Add(deck.GetCard(card.Value.next(1), card.Suite));
			player.Add(deck.GetCard(card.Value.next(2), card.Suite));
			player.Add(deck.GetCard(card.Value.next(3), card.Suite));
			player.Add(deck.GetCard(card.Value.next(4), card.Suite));
		}

	}
}