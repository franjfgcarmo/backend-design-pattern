using Poker.Cards;
using System.Collections.Generic;

namespace Poker.Gambles
{
	internal class DobleParejaAnalyzer : Analyzer
	{

		public DobleParejaAnalyzer(Analyzer analyzer) : base(analyzer)
		{
		}

		public override Gamble getGamble(PlayerStatistics playerStatistics)
		{
			if (playerStatistics.hasTwoPairs())
			{
				IList<Value> orderedValues = playerStatistics.getOrderedValues(2);
				((List<Value>)orderedValues).AddRange(playerStatistics.getOrderedValues(1));
				return new Gamble(GambleType.DOBLE_PAREJA, orderedValues);
			}
			else
			{
				return nextAnalyzer.getGamble(playerStatistics);
			}
		}

	}

}