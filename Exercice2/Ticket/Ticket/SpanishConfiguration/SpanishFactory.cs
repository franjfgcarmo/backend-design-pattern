using System;
using Tickets.v1.Countries;
using Tickets.v1.Tickets;

namespace Tickets.v1.SpanishConfiguration
{
    public class SpanishFactory : CountryFactory
    {
        public SpanishFactory() {
            Menu = new SpanishMenu();
            this.ticketBuilder = new SpanishTicketBuilder();
        }
    }
}
