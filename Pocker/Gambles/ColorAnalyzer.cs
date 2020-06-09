namespace Poker.Gambles
{
	internal class ColorAnalyzer : Analyzer
	{

		public ColorAnalyzer(Analyzer analyzer) : base(analyzer)
		{
		}

		public override Gamble GetGamble(PlayerStatistics playerStatistics)
		{
			if (playerStatistics.HasSameColor(5))
			{
				return new Gamble(GambleType.COLOR, playerStatistics.OrderedValues);
			}
			else
			{
				return nextAnalyzer.GetGamble(playerStatistics);
			}
		}

	}


}