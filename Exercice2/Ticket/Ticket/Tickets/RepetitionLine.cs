namespace Tickets.v1.Tickets
{
    public class RepetitionLine : NumberLine
    {
        public RepetitionLine(int number) : base(number)
        {
        }

        public override void Accept(TicketVisitor ticketVisitor) => ticketVisitor.Visit(this);
        public override string ToString() => $"RepetitionLine " + base.ToString();
    }
}