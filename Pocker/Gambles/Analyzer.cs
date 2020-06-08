namespace Poker.Gambles
{
	internal abstract class Analyzer
	{

		protected internal Analyzer nextAnalyzer;

		public Analyzer(Analyzer nextAnalyzer)
		{
			this.nextAnalyzer = nextAnalyzer;
		}

		public abstract Gamble getGamble(PlayerStatistics playerStatistics);


	}

}