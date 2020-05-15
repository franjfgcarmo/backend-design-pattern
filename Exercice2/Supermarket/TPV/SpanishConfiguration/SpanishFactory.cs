using System;
using TPV.v1.Countries;

namespace TPV.v1.SpanishConfiguration
{

    public class SpanishFactory : CountryFactory
    {
        public SpanishFactory()
        {
            //Acabo de ligar el abstract factory con el templete method.
            Menu = new SpanishMenu();
            ticketBuilder = new SpanishTicketBuilder();
        }
    }
}
