using System.Collections.Generic;
using System.Linq;

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
			valueCont = new int[Value.Values().Length];
			colorCont = new int[Suite.Values().Length];
			foreach (Card card in cardList)
			{
				valueCont[card.Value.Ordinal]++;
				colorCont[card.Suite.Ordinal()]++;
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
						return Value.Values()[i];
					}
				}
				return null;
			}
		}

		public virtual bool HasSameValue(int amount)
		{
			//foreach (int cont in valueCont)
			//{
			//	if (cont == amount)
			//	{
			//		return true;
			//	}
			//}
			//return false;

			return  valueCont.Any(a => a == amount);
		}

		public virtual bool HasSameColor(int amount)
		{
			//foreach (int cont in colorCont)
			//{
			//	if (cont == amount)
			//	{
			//		return true;
			//	}
			//}
			//return false;
			return colorCont.Any(a => a == amount);
		}

		public virtual bool HasTwoPairs()
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

		public virtual IList<Value> GetOrderedValues(int amount)
		{
			IList<Value> result = new List<Value>();
			for (int i = valueCont.Length - 1; i >= 0; i--)
			{
				if (valueCont[i] == amount)
				{
					result.Add(Value.Values()[i]);
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
						orderedValues.Add(Value.Values()[i]);
					}
				}
				return orderedValues;
			}
		}

		public virtual bool HasStairStart(Value value)
		{
			for (int i = 0; i < 5; i++)
			{
				if (valueCont[i + value.Ordinal] != 1)
				{
					return false;
				}
			}
			return true;
		}

		public virtual bool HasStair()
		{
			for (int i = 0; i <= Value.DIEZ.Ordinal; i++)
			{
				if (this.HasStairStart(Value.Values()[i]))
				{
					return true;
				}
			}
			return false;
		}
	}

}