using Poker.Cards;
using System.Collections.Generic;

namespace Poker.Gambles
{
	internal class DobleParejaAnalyzer : Analyzer
	{

		public DobleParejaAnalyzer(Analyzer analyzer) : base(analyzer)
		{
		}

		public override Gamble GetGamble(PlayerStatistics playerStatistics)
		{
			if (playerStatistics.HasTwoPairs())
			{
				IList<Value> orderedValues = playerStatistics.GetOrderedValues(2);
				((List<Value>)orderedValues).AddRange(playerStatistics.GetOrderedValues(1));
				return new Gamble(GambleType.DOBLE_PAREJA, orderedValues);
			}
			else
			{
				return nextAnalyzer.GetGamble(playerStatistics);
			}
		}

	}

}