using System.Collections.Generic;

namespace Poker.Gambles
{

	using Value = Poker.Cards.Value;

	internal class TrioAnalyzer : Analyzer
	{

		public TrioAnalyzer(Analyzer analyzer) : base(analyzer)
		{
		}

		public override Gamble getGamble(PlayerStatistics playerStatistics)
		{
			if (playerStatistics.hasSameValue(3))
			{
				IList<Value> orderedValues = playerStatistics.getOrderedValues(3);
	//			orderedValues.addAll(playerStatistics.getOrderedValues(1));
				return new Gamble(GambleType.TRIO, orderedValues);
			}
			else
			{
				return nextAnalyzer.getGamble(playerStatistics);
			}
		}

	}

}