namespace Poker.Gambles
{
	public class GambleAnalyzer
	{

		private static GambleAnalyzer gambleAnalyzer;

		public static GambleAnalyzer Instance()
		{
			if (gambleAnalyzer == null)
			{
				gambleAnalyzer = new GambleAnalyzer();
			}
			return gambleAnalyzer;
		}

		private Analyzer analyzer;

		private GambleAnalyzer()
		{
			analyzer = new EscaleraRealAnalyzer(new EscaleraColorAnalyzer(new PoquerAnalyzer(new FullAnalyzer(new ColorAnalyzer(new EscaleraAnalyzer(new TrioAnalyzer(new DobleParejaAnalyzer(new ParejaAnalyzer(new CartaAltaAnalyzer())))))))));
		}

		public virtual Gamble GetGamble(PlayerStatistics playerStatistics)
		{
			return analyzer.GetGamble(playerStatistics);
		}

	}

}