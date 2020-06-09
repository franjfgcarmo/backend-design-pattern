using Poker.Cards;
using System.Collections.Generic;

namespace Poker.Gambles
{

	internal class EscaleraRealAnalyzer : Analyzer
	{

		public EscaleraRealAnalyzer(Analyzer analyzer) : base(analyzer)
		{
		}

		public override Gamble GetGamble(PlayerStatistics playerStatistics)
		{
			if (playerStatistics.HasSameColor(5) && playerStatistics.HasStairStart(Value.DIEZ))
			{
				IList<Value> orderedValues = new List<Value>();
				orderedValues.Add(playerStatistics.MaxValue);
				return new Gamble(GambleType.ESCALERA_REAL, orderedValues);
			}
			else
			{
				return nextAnalyzer.GetGamble(playerStatistics);
			}
		}

	}

}