using System;
using System.Collections.Generic;

namespace Poker.Cards
{

	public sealed class Suite
	{
		public static readonly Suite CORAZONES = new Suite("CORAZONES", InnerEnum.CORAZONES, "C");
		public static readonly Suite DIAMANTES = new Suite("DIAMANTES", InnerEnum.DIAMANTES, "D");
		public static readonly Suite PICAS = new Suite("PICAS", InnerEnum.PICAS, "P");
		public static readonly Suite TREBOLES = new Suite("TREBOLES", InnerEnum.TREBOLES, "T");

		private static readonly List<Suite> valueList = new List<Suite>();

		static Suite()
		{
			valueList.Add(CORAZONES);
			valueList.Add(DIAMANTES);
			valueList.Add(PICAS);
			valueList.Add(TREBOLES);
		}

		public enum InnerEnum
		{
			CORAZONES,
			DIAMANTES,
			PICAS,
			TREBOLES
		}

		public readonly InnerEnum innerEnumValue;
		private readonly string nameValue;
		private readonly int ordinalValue;
		private static int nextOrdinal = 0;

		private string title;

		private Suite(string name, InnerEnum innerEnum, string title)
		{
			this.title = title;

			nameValue = name;
			ordinalValue = nextOrdinal++;
			innerEnumValue = innerEnum;
		}

		public string Title
		{
			get
			{
				return title;
			}
		}

		public static Suite Random()
		{
			Random random = new Random((int)DateTimeHelper.CurrentUnixTimeMillis());
			return Suite.Values()[random.Next(Suite.Values().Length)];
		}

		private Suite Next()
		{
			return Suite.Values()[(this.Ordinal() + 1) % Suite.Values().Length];
		}

		public Suite Next(int amount)
		{
			Suite suite = this;
			for (int i = 0; i < amount; i++)
			{
				suite = suite.Next();
			}
			return suite;
		}

		public static Suite[] Values()
		{
			return valueList.ToArray();
		}

		public int Ordinal()
		{
			return ordinalValue;
		}

		public override string ToString()
		{
			return nameValue;
		}

		public static Suite ValueOf(string name)
		{
			foreach (Suite enumInstance in Suite.valueList)
			{
				if (enumInstance.nameValue == name)
				{
					return enumInstance;
				}
			}
			throw new System.ArgumentException(name);
		}
	}

}