using System.Collections.Generic;

namespace Poker.Gambles
{

	using Card = Poker.Cards.Card;
	using Suite = Poker.Cards.Suite;
	using Value = Poker.Cards.Value;

	public class PlayerStatistics
	{

		private int[] valueCont;

		private int[] colorCont;

		public PlayerStatistics(IList<Card> cardList)
		{
			valueCont = new int[Value.values().Length];
			colorCont = new int[Suite.values().Length];
			foreach (Card card in cardList)
			{
				valueCont[card.Value.ordinal()]++;
				colorCont[card.Suite.ordinal()]++;
			}
		}

		public virtual Value MaxValue
		{
			get
			{
				for (int i = valueCont.Length - 1; i >= 0; i--)
				{
					if (valueCont[i] != 0)
					{
						return Value.values()[i];
					}
				}
				return null;
			}
		}

		public virtual bool hasSameValue(int amount)
		{
			foreach (int cont in valueCont)
			{
				if (cont == amount)
				{
					return true;
				}
			}
			return false;
		}

		public virtual bool hasSameColor(int amount)
		{
			foreach (int cont in colorCont)
			{
				if (cont == amount)
				{
					return true;
				}
			}
			return false;
		}

		public virtual bool hasTwoPairs()
		{
			int pairs = 0;
			foreach (int cont in valueCont)
			{
				if (cont == 2)
				{
					pairs++;
				}
			}
			return pairs == 2;
		}

		public virtual IList<Value> getOrderedValues(int amount)
		{
			IList<Value> result = new List<Value>();
			for (int i = valueCont.Length - 1; i >= 0; i--)
			{
				if (valueCont[i] == amount)
				{
					result.Add(Value.values()[i]);
				}
			}
			return result;
		}

		public virtual IList<Value> OrderedValues
		{
			get
			{
				IList<Value> orderedValues = new List<Value>();
				for (int i = valueCont.Length - 1; i >= 0; i--)
				{
					for (int j = 0; j < valueCont[i]; j++)
					{
						orderedValues.Add(Value.values()[i]);
					}
				}
				return orderedValues;
			}
		}

		public virtual bool hasStairStart(Value value)
		{
			for (int i = 0; i < 5; i++)
			{
				if (valueCont[i + value.ordinal()] != 1)
				{
					return false;
				}
			}
			return true;
		}

		public virtual bool hasStair()
		{
			for (int i = 0; i <= Value.DIEZ.ordinal(); i++)
			{
				if (this.hasStairStart(Value.values()[i]))
				{
					return true;
				}
			}
			return false;
		}
	}

}