namespace Poker.Gambles
{
	internal class ColorAnalyzer : Analyzer
	{

		public ColorAnalyzer(Analyzer analyzer) : base(analyzer)
		{
		}

		public override Gamble getGamble(PlayerStatistics playerStatistics)
		{
			if (playerStatistics.hasSameColor(5))
			{
				return new Gamble(GambleType.COLOR, playerStatistics.OrderedValues);
			}
			else
			{
				return nextAnalyzer.getGamble(playerStatistics);
			}
		}

	}


}