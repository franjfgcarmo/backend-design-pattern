using Poker.Cards;

namespace Poker.Builders
{
    
    internal class EscaleraColorBuilder : Builder
	{

		internal override void FillPlayer()
		{
			Value value = Value.Random(Value.NUEVE);
			Card card = deck.GetCard(value);
			player.Add(card);
			player.Add(deck.GetCard(value.Next(1), card.Suite));
			player.Add(deck.GetCard(value.Next(2), card.Suite));
			player.Add(deck.GetCard(value.Next(3), card.Suite));
			player.Add(deck.GetCard(value.Next(4), card.Suite));
		}

	}

}