using Poker.Gambles;
using Poker.Players;
using System;

namespace Poker.Builders
{
	public class Poquer
	{

		private void Play()
		{
			Player[] players = new Player[20];
			for (int i = 0; i < 10; i++)
			{
				players[i] = PlayerBuilder.Instance().Build(GambleType.values()[i]);
			}
			for (int i = 0; i < 10; i++)
			{
				players[i + 10] = PlayerBuilder.Instance().Build(GambleType.values()[i]);
			}
			for (int i = 0; i < players.Length; i++)
			{
				Console.WriteLine("===========================");
				players[i].Show();
				for (int j = i; j < players.Length; j++)
				{
					Player winner = players[i].WhoIsWinner(players[j]);
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
			(new Poquer()).Play();
		}
	}

}