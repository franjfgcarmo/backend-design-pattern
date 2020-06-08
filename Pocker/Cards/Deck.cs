using Poker.cards;
using Poker.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker.Cards
{

    public class Deck
	{

		private IList<Card> cardList;

		public Deck()
		{
			cardList = new List<Card>();
			for (int i = 0; i < Suite.values().Length; i++)
			{
				for (int j = 0; j < Value.values().Length; j++)
				{
					cardList.Add(CardFlyweight.instance().GetCard(Value.values()[j], Suite.values()[i]));
				}
			}
			cardList.Shuffle();
			//Collections.shuffle(cardList);
		}

        public virtual Card GetCard(Value value)
		{
			Card result = null;
			foreach (Card card in cardList)
			{
				if (card.Value.Equals(value))
				{
					result = card;
				}
			}
			if (result != null)
			{
				cardList.Remove(result);
			}
			return result;
		}

		public virtual Card GetCard(Suite suite)
		{
			Card result = null;
			foreach (Card card in cardList)
			{
				if (card.Suite.Equals(suite))
				{
					result = card;
				}
			}
			if (result != null)
			{
				cardList.Remove(result);
			}
			return result;
		}

		public virtual Card GetCard(Value value, Suite suite)
		{
			Card result = null;
			foreach (Card card in cardList)
			{
				if (card.Value.Equals(value) && card.Suite.Equals(suite))
				{
					result = card;
				}
			}
			if (result != null)
			{
				cardList.Remove(result);
			}
			return result;
		}

		public virtual Card Card
		{
			get
			{
				//todo:mirar
				cardList.RemoveAt(0);
				return cardList.FirstOrDefault();	
			}
		}
	}

}