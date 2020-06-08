using Poker.Cards;
using System.Collections.Generic;

namespace Poker.Gambles
{
	internal class EscaleraColorAnalyzer : Analyzer
	{

		public EscaleraColorAnalyzer(Analyzer analyzer) : base(analyzer)
		{
		}

		public override Gamble getGamble(PlayerStatistics playerStatistics)
		{
			if (playerStatistics.hasSameColor(5) && playerStatistics.hasStair())
			{
				IList<Value> orderedValues = new List<Value>();
				orderedValues.Add(playerStatistics.MaxValue);
				return new Gamble(GambleType.ESCALERA_COLOR, orderedValues);
			}
			else
			{
				return nextAnalyzer.getGamble(playerStatistics);
			}
		}

	}

}