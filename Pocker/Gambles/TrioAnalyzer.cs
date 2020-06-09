using Poker.Cards;
using System.Collections.Generic;

namespace Poker.Gambles
{

	internal class TrioAnalyzer : Analyzer
	{

		public TrioAnalyzer(Analyzer analyzer) : base(analyzer)
		{
		}

        public override Gamble GetGamble(PlayerStatistics playerStatistics)
		{
			if (playerStatistics.HasSameValue(3))
			{
				IList<Value> orderedValues = playerStatistics.GetOrderedValues(3);
	//			orderedValues.addAll(playerStatistics.getOrderedValues(1));
				return new Gamble(GambleType.TRIO, orderedValues);
			}
			else
			{
				return nextAnalyzer.GetGamble(playerStatistics);
			}
		}

	}

}