namespace Poker.Cards
{
	public class Card
	{

		private readonly Value value;

		private readonly Suite suite;

		internal Card(Value value, Suite suite)
		{
			this.value = value;
			this.suite = suite;
		}

        public virtual Value Value => value;

        public virtual Suite Suite => suite;

        public virtual bool greater(Card card) => value.Greater(card.value);

        public override string ToString() => $"Card [{value.Title}, {suite.Title}]";

    }

}