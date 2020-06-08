namespace Poker.Gambles
{
	internal class FullAnalyzer : Analyzer
	{

		public FullAnalyzer(Analyzer analyzer) : base(analyzer)
		{
		}

		public override Gamble getGamble(PlayerStatistics playerStatistics)
		{
			if (playerStatistics.hasSameValue(3) && playerStatistics.hasSameValue(2))
			{
				return new Gamble(GambleType.FULL, playerStatistics.getOrderedValues(3));
			}
			else
			{
				return nextAnalyzer.getGamble(playerStatistics);
			}
		}

	}

}