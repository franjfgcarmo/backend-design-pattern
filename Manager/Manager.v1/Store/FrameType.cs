using System.Collections.Generic;

namespace Manager.v1.Store
{
	public sealed class FrameType
	{
		public static readonly FrameType ADD = new FrameType("ADD", InnerEnum.ADD);
		public static readonly FrameType REMOVE = new FrameType("REMOVE", InnerEnum.REMOVE);
		public static readonly FrameType EXIST = new FrameType("EXIST", InnerEnum.EXIST);
		public static readonly FrameType LIST = new FrameType("LIST", InnerEnum.LIST);
		public static readonly FrameType CLOSE = new FrameType("CLOSE", InnerEnum.CLOSE);

		private static readonly List<FrameType> valueList = new List<FrameType>();

		static FrameType()
		{
			valueList.Add(ADD);
			valueList.Add(REMOVE);
			valueList.Add(EXIST);
			valueList.Add(LIST);
			valueList.Add(CLOSE);
		}

		public enum InnerEnum
		{
			ADD,
			REMOVE,
			EXIST,
			LIST,
			CLOSE
		}

		public readonly InnerEnum innerEnumValue;
		private readonly string nameValue;
		private readonly int ordinalValue;
		private static int nextOrdinal = 0;

		private FrameType(string name, InnerEnum innerEnum)
		{
			nameValue = name;
			ordinalValue = nextOrdinal++;
			innerEnumValue = innerEnum;
		}

		public static FrameType Parser(string @string)
		{
			foreach (FrameType frameType in FrameType.Values())
			{
				if (frameType.ToString().Equals(@string))
				{
					return frameType;
				}
			}
			return null;
		}

		public static FrameType[] Values()
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

		public static FrameType ValueOf(string name)
		{
			foreach (FrameType enumInstance in FrameType.valueList)
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