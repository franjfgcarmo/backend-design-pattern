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
			for (int i = 0; i < Suite.Values().Length; i++)
			{
				for (int j = 0; j < Value.Values().Length; j++)
				{
					cardList.Add(CardFlyweight.Instance().GetCard(Value.Values()[j], Suite.Values()[i]));
				}
			}
			cardList.Shuffle();
			//todo:mirar
			//Collections.shuffle(cardList);
		}

        public virtual Card GetCard(Value value)
		{
			Card result = null;
            foreach (var card in from Card card in cardList
                                 where card.Value.Equals(value)
                                 select card)
            {
                result = card;
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
            foreach (var card in from Card card in cardList
                                 where card.Suite.Equals(suite)
                                 select card)
            {
                result = card;
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
            foreach (var card in from Card card in cardList
                                 where card.Value.Equals(value) && card.Suite.Equals(suite)
                                 select card)
            {
                result = card;
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