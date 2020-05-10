using System;
using TPV.v1.Tickets;

namespace TPV.v1.Tickets
{
    public class Header
    {
        public DateTime Date { get; private set; }
        public Header() => Date = DateTime.Now;
        public void Accept(ITicketVisitor ticketVisitor) => ticketVisitor.Visit(this);
        public override string ToString() => $"Head [date={Date}]";
    }
}