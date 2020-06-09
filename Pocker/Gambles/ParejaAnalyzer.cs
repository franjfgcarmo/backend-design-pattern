using System.Collections.Generic;

namespace Poker.Gambles
{

	using Value = Poker.Cards.Value;

	internal class ParejaAnalyzer : Analyzer
	{

		public ParejaAnalyzer(Analyzer analyzer) : base(analyzer)
		{
		}

		public override Gamble GetGamble(PlayerStatistics playerStatistics)
		{
			if (playerStatistics.HasSameValue(2))
			{
				IList<Value> orderedValues = playerStatistics.GetOrderedValues(2);
				((List<Value>)orderedValues).AddRange(playerStatistics.GetOrderedValues(1));
				return new Gamble(GambleType.PAREJA, orderedValues);
			}
			else
			{
				return nextAnalyzer.GetGamble(playerStatistics);
			}
		}

	}

}