using Poker.Cards;
using System.Collections.Generic;

namespace Poker.Gambles
{

	public class Gamble
	{

		protected internal GambleType gambleType;

		private IList<Value> orderedValues;

		public Gamble(GambleType gambleType, IList<Value> orderedValues)
		{
			this.gambleType = gambleType;
			this.orderedValues = orderedValues;
		}

		public virtual Gamble whoIsWinner(Gamble gamble)
		{
			Gamble winner = null;
			if (this.gambleType.Equals(gamble.gambleType))
			{
				winner = this.whoIsWinnerWithSameGambleType(gamble);
			}
			else if (this.gambleType.greater(gamble.gambleType))
			{
				winner = this;
			}
			else
			{
				winner = gamble;
			}
			return winner;
		}

		protected internal virtual Gamble whoIsWinnerWithSameGambleType(Gamble gamble)
		{
			IList<Value> orderedValues = gamble.orderedValues;
			int i = 0;
			while (i < orderedValues.Count - 1 && this.orderedValues[i].Equals(orderedValues[i]))
			{
				i++;
			}
			if (this.orderedValues[i].greater(orderedValues[i]))
			{
				return this;
			}
			else if (orderedValues[i].greater(this.orderedValues[i]))
			{
				return gamble;
			}
			return null;
		}

		public override string ToString()
		{
			return "Gamble [gambleType=" + gambleType.ToString() + ", orderedValues=" + orderedValues + "]";
		}

	}

}