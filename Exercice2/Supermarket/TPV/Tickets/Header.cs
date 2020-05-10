using System;
using TPV.v1.Tickets;

namespace TPV.v1.Tickets
{
    public class Header
    {
        public DateTime Date { get; private set; }
        public Header(DateTime date) => Date = date;
        public void Accept(TicketVisitor ticketVisitor) => ticketVisitor.Visit(this);
        public override string ToString() => $"Head [date={Date}]";
    }
}