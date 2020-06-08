using Poker.Players;
using System;

namespace Poker.Builders
{
	public class Poquer
	{

		private void play()
		{
			Player[] players = new Player[20];
			for (int i = 0; i < 10; i++)
			{
				players[i] = PlayerBuilder.instance().build(GambleType.values()[i]);
			}
			for (int i = 0; i < 10; i++)
			{
				players[i + 10] = PlayerBuilder.instance().build(GambleType.values()[i]);
			}
			for (int i = 0; i < players.Length; i++)
			{
				Console.WriteLine("===========================");
				players[i].show();
				for (int j = i; j < players.Length; j++)
				{
					Player winner = players[i].whoIsWinner(players[j]);
					Console.WriteLine("-------------------");
					Console.WriteLine(players[i]);
					Console.WriteLine(players[j]);
					if (winner == null)
					{
						Console.WriteLine("EMPATE!!!");
					}
					else
					{
						Console.WriteLine("GANADOR: " + winner);
					}
				}
			}
		}

		public static void Main(string[] args)
		{
			(new Poquer()).play();
		}
	}

}