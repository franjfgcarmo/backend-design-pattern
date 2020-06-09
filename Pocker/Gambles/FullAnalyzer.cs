namespace Poker.Gambles
{
	internal class FullAnalyzer : Analyzer
	{

		public FullAnalyzer(Analyzer analyzer) : base(analyzer)
		{
		}

		public override Gamble GetGamble(PlayerStatistics playerStatistics)
		{
			if (playerStatistics.HasSameValue(3) && playerStatistics.HasSameValue(2))
			{
				return new Gamble(GambleType.FULL, playerStatistics.GetOrderedValues(3));
			}
			else
			{
				return nextAnalyzer.GetGamble(playerStatistics);
			}
		}

	}

}