namespace Tickets.v1.Tickets
{
    public abstract class IdLine:Line
    {
        public int Id { protected set; get; }
        public int Units { protected set; get; }
        protected IdLine(int id, int units)
        {
            Id = id;
            Units = units;
        }
        public override string ToString() => $"[id={Id}, units={Units + base.ToString()}]\n";
    }
}
