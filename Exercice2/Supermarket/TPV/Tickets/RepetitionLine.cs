﻿using TPV.v1.Tickets;

namespace TPV.v1.Tickets
{
    public class RepetitionLine : NumberLine
    {
        public RepetitionLine(int number) : base(number)
        {
        }

        public override void Accept(ITicketVisitor ticketVisitor) => ticketVisitor.Visit(this);
        public override string ToString() => $"RepetitionLine " + base.ToString();
    }
}