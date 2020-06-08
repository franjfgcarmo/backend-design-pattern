namespace Poker.Gambles
{
	internal class PoquerAnalyzer : Analyzer
	{

		public PoquerAnalyzer(Analyzer analyzer) : base(analyzer)
		{
		}

		public override Gamble getGamble(PlayerStatistics playerStatistics)
		{
			if (playerStatistics.hasSameValue(4))
			{
				return new Gamble(GambleType.POQUER, playerStatistics.getOrderedValues(4));
			}
			else
			{
				return nextAnalyzer.getGamble(playerStatistics);
			}
		}

	}

}