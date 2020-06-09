namespace Poker.Gambles
{
	internal class PoquerAnalyzer : Analyzer
	{

		public PoquerAnalyzer(Analyzer analyzer) : base(analyzer)
		{
		}

		public override Gamble GetGamble(PlayerStatistics playerStatistics)
		{
			if (playerStatistics.HasSameValue(4))
			{
				return new Gamble(GambleType.POQUER, playerStatistics.GetOrderedValues(4));
			}
			else
			{
				return nextAnalyzer.GetGamble(playerStatistics);
			}
		}

	}

}