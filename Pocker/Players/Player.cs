using Poker.Cards;
using Poker.Gambles;
using System;
using System.Collections.Generic;

namespace Poker.Players
{

	public class Player
	{

		private IList<Card> cardList;

		private Gamble gamble;

		public Player()
		{
			cardList = new List<Card>();
		}

		public virtual void Add(Card card)
		{
			cardList.Add(card);
		}

		public virtual Player WhoIsWinner(Player player)
		{
			Gamble winner = Gamble.whoIsWinner(player.Gamble);
            if (winner == Gamble)
			{
				return this;
			}
			else if (winner == player.Gamble)
			{
				return player;
			}
			else
			{
				return null;
			}
		}

		private Gamble Gamble
		{
			get
			{
				if (gamble == null)
				{
					gamble = GambleAnalyzer.instance().getGamble(new PlayerStatistics(cardList));
				}
				return gamble;
			}
		}

		public virtual void Show()
		{
			Console.WriteLine("-------------------");
			Console.WriteLine("Player: " + this.ToString());

			PlayerStatistics playerStatistics = new PlayerStatistics(cardList);
			Console.WriteLine("getMaxValue(); " + playerStatistics.MaxValue);
			Console.WriteLine("getOrderedValues(); " + playerStatistics.OrderedValues);
			for (int i = 1; i <= 5; i++)
			{
				Console.WriteLine("hasSameValue(" + i + "); " + playerStatistics.HasSameValue(i));
				Console.WriteLine("getOrderedValues(" + i + "); " + playerStatistics.GetOrderedValues(i));
			}
			for (int i = 1; i <= 5; i++)
			{
				Console.WriteLine("hasSameColor(" + i + "); " + playerStatistics.HasSameColor(i));
			}
			Console.WriteLine("hasTwoPairs(); " + playerStatistics.HasTwoPairs());
			foreach (Value value in Value.Values())
			{
				if (Value.INFANTE.Greater(value))
				{
					Console.WriteLine("hasStairStart(" + value.Title + "); " + playerStatistics.HasStairStart(value));
				}
			}
			Console.WriteLine("hasStair(); " + playerStatistics.HasStair());
		}

        public override string ToString() => $"Player [\ncardList={cardList}, \ngamble={gamble}]";

    }

}