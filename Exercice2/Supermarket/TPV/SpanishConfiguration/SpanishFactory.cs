using System;
using TPV.v1.Countries;

namespace TPV.v1.SpanishConfiguration
{
    public class SpanishFactory : CountryFactory
    {
        public SpanishFactory()
        {
            Menu = new SpanishMenu();
            ticketBuilder = new SpanishTicketBuilder();
        }
    }
}
