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

		public static Suite random()
		{
			Random random = new Random((int)DateTimeHelper.CurrentUnixTimeMillis());
			return Suite.values()[random.Next(Suite.values().Length)];
		}

		private Suite next()
		{
			return Suite.values()[(this.ordinal() + 1) % Suite.values().Length];
		}

		public Suite next(int amount)
		{
			Suite suite = this;
			for (int i = 0; i < amount; i++)
			{
				suite = suite.next();
			}
			return suite;
		}

		public static Suite[] values()
		{
			return valueList.ToArray();
		}

		public int ordinal()
		{
			return ordinalValue;
		}

		public override string ToString()
		{
			return nameValue;
		}

		public static Suite valueOf(string name)
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