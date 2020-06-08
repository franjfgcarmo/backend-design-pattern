using System;
using System.Collections.Generic;

namespace Poker.Cards
{

	public sealed class Value
	{
		public static readonly Value DOS = new Value("DOS", InnerEnum.DOS, "2");
		public static readonly Value TRES = new Value("TRES", InnerEnum.TRES, "3");
		public static readonly Value CUATRO = new Value("CUATRO", InnerEnum.CUATRO, "4");
		public static readonly Value CINCO = new Value("CINCO", InnerEnum.CINCO, "5");
		public static readonly Value SEIS = new Value("SEIS", InnerEnum.SEIS, "6");
		public static readonly Value SIETE = new Value("SIETE", InnerEnum.SIETE, "7");
		public static readonly Value OCHO = new Value("OCHO", InnerEnum.OCHO, "8");
		public static readonly Value NUEVE = new Value("NUEVE", InnerEnum.NUEVE, "9");
		public static readonly Value DIEZ = new Value("DIEZ", InnerEnum.DIEZ, "10");
		public static readonly Value INFANTE = new Value("INFANTE", InnerEnum.INFANTE, "J");
		public static readonly Value REINA = new Value("REINA", InnerEnum.REINA, "Q");
		public static readonly Value REY = new Value("REY", InnerEnum.REY, "K");
		public static readonly Value AS = new Value("AS", InnerEnum.AS, "As");

		private static readonly List<Value> valueList = new List<Value>();

		static Value()
		{
			valueList.Add(DOS);
			valueList.Add(TRES);
			valueList.Add(CUATRO);
			valueList.Add(CINCO);
			valueList.Add(SEIS);
			valueList.Add(SIETE);
			valueList.Add(OCHO);
			valueList.Add(NUEVE);
			valueList.Add(DIEZ);
			valueList.Add(INFANTE);
			valueList.Add(REINA);
			valueList.Add(REY);
			valueList.Add(AS);
		}

		public enum InnerEnum
		{
			DOS,
			TRES,
			CUATRO,
			CINCO,
			SEIS,
			SIETE,
			OCHO,
			NUEVE,
			DIEZ,
			INFANTE,
			REINA,
			REY,
			AS
		}

		public readonly InnerEnum innerEnumValue;
		private readonly string nameValue;
		private readonly int ordinalValue;
		private static int nextOrdinal = 0;

		private string title;

		private Value(string name, InnerEnum innerEnum, string title)
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

		public bool greater(Value value)
		{
			return this.ordinal() > value.ordinal();
		}

		public static Value random(Value max)
		{
			Random random = new Random(DateTimeHelper.CurrentUnixTimeMillis());
			return Value.values()[random.Next(max.ordinal())];
		}

		public static Value random()
		{
			return Value.random(Value.AS);
		}

		private Value next()
		{
			return Value.values()[(this.ordinal() + 1) % Value.values().Length];
		}

		public Value next(int amount)
		{
			Value value = this;
			for (int i = 0; i < amount; i++)
			{
				value = value.next();
			}
			return value;
		}


		public static Value[] values()
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

		public static Value valueOf(string name)
		{
			foreach (Value enumInstance in Value.valueList)
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