namespace Poker.Gambles
{
	internal class CartaAltaAnalyzer : Analyzer
	{

		public CartaAltaAnalyzer() : this(null)
		{
		}

		public CartaAltaAnalyzer(Analyzer analyzer) : base(analyzer)
		{
		}

		public override Gamble GetGamble(PlayerStatistics playerStatistics)
		{
			return new Gamble(GambleType.CARTA_ALTA, playerStatistics.GetOrderedValues(1));
		}

	}

}