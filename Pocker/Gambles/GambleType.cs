using System.Collections.Generic;

namespace Poker.Gambles
{
	public sealed class GambleType
	{
		public static readonly GambleType CARTA_ALTA = new GambleType("CARTA_ALTA", InnerEnum.CARTA_ALTA);
		public static readonly GambleType PAREJA = new GambleType("PAREJA", InnerEnum.PAREJA);
		public static readonly GambleType DOBLE_PAREJA = new GambleType("DOBLE_PAREJA", InnerEnum.DOBLE_PAREJA);
		public static readonly GambleType TRIO = new GambleType("TRIO", InnerEnum.TRIO);
		public static readonly GambleType ESCALERA = new GambleType("ESCALERA", InnerEnum.ESCALERA);
		public static readonly GambleType COLOR = new GambleType("COLOR", InnerEnum.COLOR);
		public static readonly GambleType FULL = new GambleType("FULL", InnerEnum.FULL);
		public static readonly GambleType POQUER = new GambleType("POQUER", InnerEnum.POQUER);
		public static readonly GambleType ESCALERA_COLOR = new GambleType("ESCALERA_COLOR", InnerEnum.ESCALERA_COLOR);
		public static readonly GambleType ESCALERA_REAL = new GambleType("ESCALERA_REAL", InnerEnum.ESCALERA_REAL);

		private static readonly List<GambleType> valueList = new List<GambleType>();

		static GambleType()
		{
			valueList.Add(CARTA_ALTA);
			valueList.Add(PAREJA);
			valueList.Add(DOBLE_PAREJA);
			valueList.Add(TRIO);
			valueList.Add(ESCALERA);
			valueList.Add(COLOR);
			valueList.Add(FULL);
			valueList.Add(POQUER);
			valueList.Add(ESCALERA_COLOR);
			valueList.Add(ESCALERA_REAL);
		}

		public enum InnerEnum
		{
			CARTA_ALTA,
			PAREJA,
			DOBLE_PAREJA,
			TRIO,
			ESCALERA,
			COLOR,
			FULL,
			POQUER,
			ESCALERA_COLOR,
			ESCALERA_REAL
		}

		public readonly InnerEnum innerEnumValue;
		private readonly string nameValue;
		private readonly int ordinalValue;
		private static int nextOrdinal = 0;

		private GambleType(string name, InnerEnum innerEnum)
		{
			nameValue = name;
			ordinalValue = nextOrdinal++;
			innerEnumValue = innerEnum;
		}

		public bool equals(GambleType gambleType)
		{
			return this.ordinal() == gambleType.ordinal();
		}

		public bool greater(GambleType gambleType)
		{
			return this.ordinal() > gambleType.ordinal();
		}


		public static GambleType[] values()
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

		public static GambleType valueOf(string name)
		{
			foreach (GambleType enumInstance in GambleType.valueList)
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