using Poker.Cards;
using System.Collections.Generic;

namespace Poker.Gambles
{
	internal class EscaleraAnalyzer : Analyzer
	{

		public EscaleraAnalyzer(Analyzer analyzer) : base(analyzer)
		{
		}

		public override Gamble getGamble(PlayerStatistics playerStatistics)
		{
			if (playerStatistics.hasStair())
			{
				IList<Value> orderedValues = new List<Value>();
				orderedValues.Add(playerStatistics.MaxValue);
				return new Gamble(GambleType.ESCALERA, orderedValues);
			}
			else
			{
				return nextAnalyzer.getGamble(playerStatistics);
			}
		}

	}

}