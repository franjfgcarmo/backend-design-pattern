using Poker.Cards;
using System.Collections.Generic;

namespace Poker.Gambles
{
	internal class EscaleraColorAnalyzer : Analyzer
	{

		public EscaleraColorAnalyzer(Analyzer analyzer) : base(analyzer)
		{
		}

		public override Gamble GetGamble(PlayerStatistics playerStatistics)
		{
			if (playerStatistics.HasSameColor(5) && playerStatistics.HasStair())
			{
				IList<Value> orderedValues = new List<Value>();
				orderedValues.Add(playerStatistics.MaxValue);
				return new Gamble(GambleType.ESCALERA_COLOR, orderedValues);
			}
			else
			{
				return nextAnalyzer.GetGamble(playerStatistics);
			}
		}

	}

}