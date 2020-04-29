namespace Tickets.v1.Tickets
{
    public class ReturnLine : IdLine
    {
        public ReturnLine(int id, int units) : base(id, units)
        {
        }

        public override void Accept(TicketVisitor ticketVisitor)
        {
            ticketVisitor.Visit(this);
        }
        public override string ToString()=> $"ReturnLine {base.ToString()}";
        
    }
}