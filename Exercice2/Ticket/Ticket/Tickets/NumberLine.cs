namespace Tickets.v1.Tickets
{
    public abstract class   NumberLine:Line
    {
        public int Number { protected set; get; }
        protected NumberLine(int number)
        {
            Number = number;
        }
        public override string ToString() => $"[number={Number + base.ToString()}]\n";
    }
}
