namespace Poker.Cards
{
	public class Card
	{

		private Value value;

		private Suite suite;

		internal Card(Value value, Suite suite)
		{
			this.value = value;
			this.suite = suite;
		}

		public virtual Value Value
		{
			get
			{
				return value;
			}
		}

		public virtual Suite Suite
		{
			get
			{
				return suite;
			}
		}

		public virtual bool greater(Card card)
		{
			return value.greater(card.value);
		}

		public override string ToString()
		{
			return "Card [" + value.Title + ", " + suite.Title + "]";
		}




	}

}