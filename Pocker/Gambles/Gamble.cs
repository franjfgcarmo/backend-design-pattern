using Poker.Cards;
using System.Collections.Generic;

namespace Poker.Gambles
{

	public class Gamble
	{

		protected internal GambleType gambleType;

		private readonly IList<Value> orderedValues;

		public Gamble(GambleType gambleType, IList<Value> orderedValues)
		{
			this.gambleType = gambleType;
			this.orderedValues = orderedValues;
		}

		public virtual Gamble whoIsWinner(Gamble gamble)
		{
            Gamble winner;
            if (this.gambleType.Equals((object)gamble.gambleType))
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
			if (this.orderedValues[i].Greater(orderedValues[i]))
			{
				return this;
			}
			else if (orderedValues[i].Greater(this.orderedValues[i]))
			{
				return gamble;
			}
			return null;
		}

        public override string ToString() => $"Gamble [gambleType={gambleType.ToString()}, orderedValues={orderedValues}]";

    }

}