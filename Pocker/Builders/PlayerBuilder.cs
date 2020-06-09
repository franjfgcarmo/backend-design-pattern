using Poker.Builders;
using Poker.Gambles;
using Poker.Players;
using System.Collections.Generic;

namespace Poker.Builders
{

    public class PlayerBuilder
	{

		private static PlayerBuilder playerBuilder;

		public static PlayerBuilder Instance()
		{            
			playerBuilder ??= new PlayerBuilder();
			
			return playerBuilder;
		}

		private IDictionary<GambleType, Builder> builderMap;

		private PlayerBuilder()
		{
            builderMap = new Dictionary<GambleType, Builder>
            {
                [GambleType.CARTA_ALTA] = new CartaAltaBuilder(),
                [GambleType.PAREJA] = new ParejaBuilder(),
                [GambleType.DOBLE_PAREJA] = new DobleParejaBuilder(),
                [GambleType.TRIO] = new TrioBuilder(),
                [GambleType.ESCALERA] = new EscaleraBuilder(),
                [GambleType.COLOR] = new ColorBuilder(),
                [GambleType.FULL] = new FullBuilder(),
                [GambleType.POQUER] = new PoquerBuilder(),
                [GambleType.ESCALERA_COLOR] = new EscaleraColorBuilder(),
                [GambleType.ESCALERA_REAL] = new EscaleraRealBuilder()
            };
        }

		public virtual Player Build(GambleType gambleType)
		{
			return builderMap[gambleType].Build();
		}

	}

}