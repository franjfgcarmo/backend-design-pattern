using System.Collections.Generic;

namespace Poker.Gambles
{

	using Value = Poker.Cards.Value;

	internal class ParejaAnalyzer : Analyzer
	{

		public ParejaAnalyzer(Analyzer analyzer) : base(analyzer)
		{
		}

		public override Gamble getGamble(PlayerStatistics playerStatistics)
		{
			if (playerStatistics.hasSameValue(2))
			{
				IList<Value> orderedValues = playerStatistics.getOrderedValues(2);
				((List<Value>)orderedValues).AddRange(playerStatistics.getOrderedValues(1));
				return new Gamble(GambleType.PAREJA, orderedValues);
			}
			else
			{
				return nextAnalyzer.getGamble(playerStatistics);
			}
		}

	}

}