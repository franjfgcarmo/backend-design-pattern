namespace Tickets.v1.Tickets
{
    public class Footer
    {
        public int TotalPrice { get; private set; }

        public void Accept(TicketVisitor ticketVisitor) => ticketVisitor.Visit(this);

        public override string ToString() => $"Footer [totalPrice={TotalPrice}]";
    }
}