namespace Tickets.v1.Tickets
{
    public abstract class Line
    {
        public int Price { get; set; }
        public abstract void Accept(TicketVisitor ticketVisitor);
        public override string ToString() => $",price={Price}";
    }
}