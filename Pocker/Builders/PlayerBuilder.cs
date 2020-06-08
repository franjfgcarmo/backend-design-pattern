using Poker.Builders;
using Poker.Gambles;
using Poker.Players;
using System.Collections.Generic;

namespace Poker.Builders
{

    public class PlayerBuilder
	{

		private static PlayerBuilder playerBuilder;

		public static PlayerBuilder instance()
		{
			if (playerBuilder == null)
			{
				playerBuilder = new PlayerBuilder();
			}
			return playerBuilder;
		}

		private IDictionary<GambleType, Builder> builderMap;

		private PlayerBuilder()
		{
			builderMap = new Dictionary<GambleType, Builder>();
			builderMap[GambleType.CARTA_ALTA] = new CartaAltaBuilder();
			builderMap[GambleType.PAREJA] = new ParejaBuilder();
			builderMap[GambleType.DOBLE_PAREJA] = new DobleParejaBuilder();
			builderMap[GambleType.TRIO] = new TrioBuilder();
			builderMap[GambleType.ESCALERA] = new EscaleraBuilder();
			builderMap[GambleType.COLOR] = new ColorBuilder();
			builderMap[GambleType.FULL] = new FullBuilder();
			builderMap[GambleType.POQUER] = new PoquerBuilder();
			builderMap[GambleType.ESCALERA_COLOR] = new EscaleraColorBuilder();
			builderMap[GambleType.ESCALERA_REAL] = new EscaleraRealBuilder();
		}

		public virtual Player build(GambleType gambleType)
		{
			return builderMap[gambleType].Build();
		}

	}

}